using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.V3
{
    public partial class FormAddLine : Form
    {
        public FormAddLine()
        {
            InitializeComponent();
        }

        string stroka;

        bool ok = false;

        public void ReplaceHeaders(string[] headers)
        {
            int ColumnsCount = headers.GetUpperBound(0) + 1;

            dataGridViewNewLine_DIA.ColumnCount = ColumnsCount;
            dataGridViewNewLine_DIA.RowCount = 2;

            dataGridViewNewLine_DIA.RowHeadersVisible = false;
            dataGridViewNewLine_DIA.ColumnHeadersVisible = true;
            dataGridViewNewLine_DIA.AllowUserToAddRows = false;

            for (int j = 0; j < ColumnsCount; j++)
            {
                dataGridViewNewLine_DIA.Columns[j].HeaderText = headers[j];
            }
        }

        private void buttonOK_DIA_Click(object sender, EventArgs e)
        {
            stroka = "";

            for (int i = 0; i < dataGridViewNewLine_DIA.ColumnCount - 1; i++)
            {
                stroka += dataGridViewNewLine_DIA.Rows[0].Cells[i].Value + ";";
            }
            stroka += ""+dataGridViewNewLine_DIA.Rows[0].Cells[dataGridViewNewLine_DIA.ColumnCount - 1].Value;

            ok = true;

            this.Close();
        }

        public string GetStroka()
        {
            return stroka;
        }

        public bool OK()
        {
            return ok;
        }

        private void buttonCancel_DIA_Click(object sender, EventArgs e)
        {
            ok = false;
            this.Close();
        }
    }
}
