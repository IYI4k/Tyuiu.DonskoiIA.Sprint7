using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using Project.V3.Lib;

namespace Project.V3
{
    public partial class FormMain_DIA : Form
    {
        public FormMain_DIA()
        {
            InitializeComponent();
        }

        Table table = new Table();
        string[,] old_table;

        bool SortingWay = true;
        private void toolStripMenuItemOpenFile_DIA_Click(object sender, EventArgs e)
        {
            openFileDialogOpenFile_DIA.ShowDialog();
            string path = openFileDialogOpenFile_DIA.FileName;

            table.LoadTable(path);

            string[,] temp_table = table.GetTable();

            int ColumnsCount = temp_table.GetUpperBound(1) + 1;
            int LinesCount = temp_table.GetUpperBound(0) + 1;

            dataGridViewBrowseTable_DIA.ColumnCount = ColumnsCount;
            dataGridViewBrowseTable_DIA.RowCount = LinesCount + 1;

            dataGridViewBrowseTable_DIA.RowHeadersVisible = false;
            dataGridViewBrowseTable_DIA.ColumnHeadersVisible = true;
            dataGridViewBrowseTable_DIA.AllowUserToAddRows = false;

            string[] keys = table.GetKeys();

            for (int i = 0; i < LinesCount; i++)
            {
                for (int j = 0; j < ColumnsCount; j++)
                {
                    dataGridViewBrowseTable_DIA.Rows[i].Cells[j].Value = temp_table[i, j];
                }
            }



            for (int j = 0; j < ColumnsCount; j++)
            {
                dataGridViewBrowseTable_DIA.Columns[j].HeaderText = keys[j];
            }
        }

        private void dataGridViewBrowseTable_DIA_Sorted(object sender, EventArgs e)
        {
            string[] keys = table.GetKeys();

            string[,] temp_table = table.SortBy(keys[dataGridViewBrowseTable_DIA.SortedColumn.Index], SortingWay);

            int ColumnsCount = temp_table.GetUpperBound(1) + 1;
            int LinesCount = temp_table.GetUpperBound(0) + 1;

            for (int i = 0; i < LinesCount; i++)
            {
                for (int j = 0; j < ColumnsCount; j++)
                {
                    dataGridViewBrowseTable_DIA.Rows[i].Cells[j].Value = temp_table[i, j];
                }
            }

            SortingWay = !SortingWay;
        }

        private void buttonSearch_DIA_Click(object sender, EventArgs e)
        {
            FormSearch_DIA formSearch = new FormSearch_DIA();

            formSearch.ShowDialog();

            if (formSearch.Search())
            {
                old_table = table.GetTable();
                string[,] temp_table = table.Search(formSearch.Search_text());

                int ColumnsCount = temp_table.GetUpperBound(1) + 1;
                int LinesCount = temp_table.GetUpperBound(0) + 1;

                for (int i = 0; i < LinesCount; i++)
                {
                    for (int j = 0; j < ColumnsCount; j++)
                    {
                        dataGridViewBrowseTable_DIA.Rows[i].Cells[j].Value = temp_table[i, j];
                    }
                }
            }
        }

        private void buttonSearchCancel_DIA_Click(object sender, EventArgs e)
        {
            table.ReplaceTable(old_table);
            string[,] temp_table = table.GetTable();

            int ColumnsCount = temp_table.GetUpperBound(1) + 1;
            int LinesCount = temp_table.GetUpperBound(0) + 1;

            for (int i = 0; i < LinesCount; i++)
            {
                for (int j = 0; j < ColumnsCount; j++)
                {
                    dataGridViewBrowseTable_DIA.Rows[i].Cells[j].Value = temp_table[i, j];
                }
            }
        }

        private void buttonAdd_DIA_Click(object sender, EventArgs e)
        {
            FormAddLine formAddLine = new FormAddLine();

            formAddLine.ReplaceHeaders(table.GetKeys());

            formAddLine.ShowDialog();

            if (formAddLine.OK())
            {
                table.AddLine(formAddLine.GetStroka());
            }

            string[,] temp_table = table.GetTable();

            int ColumnsCount = temp_table.GetUpperBound(1) + 1;
            int LinesCount = temp_table.GetUpperBound(0) + 1;

            dataGridViewBrowseTable_DIA.ColumnCount = ColumnsCount;
            dataGridViewBrowseTable_DIA.RowCount = LinesCount + 1;

            dataGridViewBrowseTable_DIA.RowHeadersVisible = false;
            dataGridViewBrowseTable_DIA.ColumnHeadersVisible = true;
            dataGridViewBrowseTable_DIA.AllowUserToAddRows = false;

            for (int i = 0; i < LinesCount; i++)
            {
                for (int j = 0; j < ColumnsCount; j++)
                {
                    dataGridViewBrowseTable_DIA.Rows[i].Cells[j].Value = temp_table[i, j];
                }
            }
        }

        private void toolStripMenuItemSaveFileAs_DIA_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogSaveFile_DIA.FileName = "Таблица.csv";
                saveFileDialogSaveFile_DIA.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialogSaveFile_DIA.ShowDialog();

                string path = saveFileDialogSaveFile_DIA.FileName;

                FileInfo f = new FileInfo(path);
                if (f.Exists)
                {
                    File.Delete(path);
                }

                string s = "";
                string[] s2 = table.GetKeys();

                for (int i = 0; i < s2.GetUpperBound(0); i++)
                {
                    s += s2[i] + ";";
                }
                s += s2[s2.GetUpperBound(0)]+Environment.NewLine;

                string[] s3 = table.GetTypes();

                for (int i = 0; i < s3.GetUpperBound(0); i++)
                {
                    s += s3[i] + ";";
                }
                s += s3[s3.GetUpperBound(0)] + Environment.NewLine;

                string[,] temp_table = table.GetTable();

                int ColumnsCount = temp_table.GetUpperBound(1);
                int LinesCount = temp_table.GetUpperBound(0);

                for (int i = 0; i < LinesCount; i++)
                {
                    for (int j = 0; j < ColumnsCount; j++)
                    {
                        s+= temp_table[i, j]+";";
                    }
                    s += temp_table[i, ColumnsCount] + Environment.NewLine;
                }

                for (int j = 0; j < ColumnsCount; j++)
                {
                    s += temp_table[LinesCount, j] + ";";
                }
                s += temp_table[LinesCount, ColumnsCount];

                File.AppendAllText(path, s.TrimEnd());
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
