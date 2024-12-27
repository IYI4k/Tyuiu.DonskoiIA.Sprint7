namespace Project.V3
{
    partial class FormMain_DIA
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_DIA));
            toolTipTips_DIA = new ToolTip(components);
            buttonSearchCancel_DIA = new Button();
            buttonSearch_DIA = new Button();
            buttonAdd_DIA = new Button();
            toolStripCommandPanel_DIA = new ToolStrip();
            toolStripSplitButtonManageFile_DIA = new ToolStripSplitButton();
            toolStripMenuItemCreateFile_DIA = new ToolStripMenuItem();
            toolStripMenuItemOpenFile_DIA = new ToolStripMenuItem();
            toolStripMenuItemSaveFile_DIA = new ToolStripMenuItem();
            toolStripMenuItemSaveFileAs_DIA = new ToolStripMenuItem();
            toolStripSplitButtonHelp = new ToolStripSplitButton();
            toolStripMenuItemOpenManual_DIA = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuItemOpenAbout_DIA = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPageMain = new TabPage();
            panel1 = new Panel();
            dataGridViewBrowseTable_DIA = new DataGridView();
            tabPageChart = new TabPage();
            openFileDialogOpenFile_DIA = new OpenFileDialog();
            saveFileDialogSaveFile_DIA = new SaveFileDialog();
            toolStripCommandPanel_DIA.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageMain.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBrowseTable_DIA).BeginInit();
            SuspendLayout();
            // 
            // buttonSearchCancel_DIA
            // 
            buttonSearchCancel_DIA.Image = Properties.Resources.magnifier_zoom_out;
            buttonSearchCancel_DIA.Location = new Point(46, 3);
            buttonSearchCancel_DIA.Name = "buttonSearchCancel_DIA";
            buttonSearchCancel_DIA.Size = new Size(37, 37);
            buttonSearchCancel_DIA.TabIndex = 1;
            toolTipTips_DIA.SetToolTip(buttonSearchCancel_DIA, "Отменить результаты поиска");
            buttonSearchCancel_DIA.UseVisualStyleBackColor = true;
            buttonSearchCancel_DIA.Click += buttonSearchCancel_DIA_Click;
            // 
            // buttonSearch_DIA
            // 
            buttonSearch_DIA.Image = Properties.Resources.magnifier;
            buttonSearch_DIA.Location = new Point(3, 3);
            buttonSearch_DIA.Name = "buttonSearch_DIA";
            buttonSearch_DIA.Size = new Size(37, 37);
            buttonSearch_DIA.TabIndex = 0;
            toolTipTips_DIA.SetToolTip(buttonSearch_DIA, "Поиск");
            buttonSearch_DIA.UseVisualStyleBackColor = true;
            buttonSearch_DIA.Click += buttonSearch_DIA_Click;
            // 
            // buttonAdd_DIA
            // 
            buttonAdd_DIA.Image = Properties.Resources.add;
            buttonAdd_DIA.Location = new Point(89, 3);
            buttonAdd_DIA.Name = "buttonAdd_DIA";
            buttonAdd_DIA.Size = new Size(37, 37);
            buttonAdd_DIA.TabIndex = 2;
            toolTipTips_DIA.SetToolTip(buttonAdd_DIA, "Отменить результаты поиска");
            buttonAdd_DIA.UseVisualStyleBackColor = true;
            buttonAdd_DIA.Click += buttonAdd_DIA_Click;
            // 
            // toolStripCommandPanel_DIA
            // 
            toolStripCommandPanel_DIA.Items.AddRange(new ToolStripItem[] { toolStripSplitButtonManageFile_DIA, toolStripSplitButtonHelp });
            toolStripCommandPanel_DIA.Location = new Point(0, 0);
            toolStripCommandPanel_DIA.Name = "toolStripCommandPanel_DIA";
            toolStripCommandPanel_DIA.Size = new Size(784, 25);
            toolStripCommandPanel_DIA.TabIndex = 2;
            toolStripCommandPanel_DIA.Text = "toolStrip1";
            // 
            // toolStripSplitButtonManageFile_DIA
            // 
            toolStripSplitButtonManageFile_DIA.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButtonManageFile_DIA.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemCreateFile_DIA, toolStripMenuItemOpenFile_DIA, toolStripMenuItemSaveFile_DIA, toolStripMenuItemSaveFileAs_DIA });
            toolStripSplitButtonManageFile_DIA.Image = (Image)resources.GetObject("toolStripSplitButtonManageFile_DIA.Image");
            toolStripSplitButtonManageFile_DIA.ImageTransparentColor = Color.Magenta;
            toolStripSplitButtonManageFile_DIA.Name = "toolStripSplitButtonManageFile_DIA";
            toolStripSplitButtonManageFile_DIA.Size = new Size(52, 22);
            toolStripSplitButtonManageFile_DIA.Text = "Файл";
            toolStripSplitButtonManageFile_DIA.ToolTipText = "Файл";
            // 
            // toolStripMenuItemCreateFile_DIA
            // 
            toolStripMenuItemCreateFile_DIA.Name = "toolStripMenuItemCreateFile_DIA";
            toolStripMenuItemCreateFile_DIA.Size = new Size(180, 22);
            toolStripMenuItemCreateFile_DIA.Text = "Новый";
            // 
            // toolStripMenuItemOpenFile_DIA
            // 
            toolStripMenuItemOpenFile_DIA.Name = "toolStripMenuItemOpenFile_DIA";
            toolStripMenuItemOpenFile_DIA.Size = new Size(180, 22);
            toolStripMenuItemOpenFile_DIA.Text = "Открыть...";
            toolStripMenuItemOpenFile_DIA.Click += toolStripMenuItemOpenFile_DIA_Click;
            // 
            // toolStripMenuItemSaveFile_DIA
            // 
            toolStripMenuItemSaveFile_DIA.Name = "toolStripMenuItemSaveFile_DIA";
            toolStripMenuItemSaveFile_DIA.Size = new Size(180, 22);
            toolStripMenuItemSaveFile_DIA.Text = "Сохранить";
            // 
            // toolStripMenuItemSaveFileAs_DIA
            // 
            toolStripMenuItemSaveFileAs_DIA.Name = "toolStripMenuItemSaveFileAs_DIA";
            toolStripMenuItemSaveFileAs_DIA.Size = new Size(180, 22);
            toolStripMenuItemSaveFileAs_DIA.Text = "Сохранить как...";
            toolStripMenuItemSaveFileAs_DIA.Click += toolStripMenuItemSaveFileAs_DIA_Click;
            // 
            // toolStripSplitButtonHelp
            // 
            toolStripSplitButtonHelp.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButtonHelp.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemOpenManual_DIA, toolStripSeparator1, toolStripMenuItemOpenAbout_DIA });
            toolStripSplitButtonHelp.Image = (Image)resources.GetObject("toolStripSplitButtonHelp.Image");
            toolStripSplitButtonHelp.ImageTransparentColor = Color.Magenta;
            toolStripSplitButtonHelp.Name = "toolStripSplitButtonHelp";
            toolStripSplitButtonHelp.Size = new Size(69, 22);
            toolStripSplitButtonHelp.Text = "Справка";
            // 
            // toolStripMenuItemOpenManual_DIA
            // 
            toolStripMenuItemOpenManual_DIA.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripMenuItemOpenManual_DIA.Name = "toolStripMenuItemOpenManual_DIA";
            toolStripMenuItemOpenManual_DIA.Size = new Size(149, 22);
            toolStripMenuItemOpenManual_DIA.Text = "Руководство";
            toolStripMenuItemOpenManual_DIA.ToolTipText = "Открыть руководство пользователя";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(146, 6);
            // 
            // toolStripMenuItemOpenAbout_DIA
            // 
            toolStripMenuItemOpenAbout_DIA.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripMenuItemOpenAbout_DIA.Name = "toolStripMenuItemOpenAbout_DIA";
            toolStripMenuItemOpenAbout_DIA.Size = new Size(149, 22);
            toolStripMenuItemOpenAbout_DIA.Text = "О программе";
            toolStripMenuItemOpenAbout_DIA.ToolTipText = "Открыть справочную информацию о ПО";
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Left;
            tabControl1.Controls.Add(tabPageMain);
            tabControl1.Controls.Add(tabPageChart);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 25);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(784, 536);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 3;
            // 
            // tabPageMain
            // 
            tabPageMain.Controls.Add(panel1);
            tabPageMain.Controls.Add(dataGridViewBrowseTable_DIA);
            tabPageMain.Location = new Point(27, 4);
            tabPageMain.Name = "tabPageMain";
            tabPageMain.Padding = new Padding(3);
            tabPageMain.Size = new Size(753, 528);
            tabPageMain.TabIndex = 0;
            tabPageMain.Text = "Главная";
            tabPageMain.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonAdd_DIA);
            panel1.Controls.Add(buttonSearchCancel_DIA);
            panel1.Controls.Add(buttonSearch_DIA);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(747, 43);
            panel1.TabIndex = 1;
            // 
            // dataGridViewBrowseTable_DIA
            // 
            dataGridViewBrowseTable_DIA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBrowseTable_DIA.Location = new Point(0, 49);
            dataGridViewBrowseTable_DIA.Name = "dataGridViewBrowseTable_DIA";
            dataGridViewBrowseTable_DIA.Size = new Size(753, 479);
            dataGridViewBrowseTable_DIA.TabIndex = 0;
            dataGridViewBrowseTable_DIA.Sorted += dataGridViewBrowseTable_DIA_Sorted;
            // 
            // tabPageChart
            // 
            tabPageChart.Location = new Point(27, 4);
            tabPageChart.Name = "tabPageChart";
            tabPageChart.Padding = new Padding(3);
            tabPageChart.Size = new Size(753, 528);
            tabPageChart.TabIndex = 1;
            tabPageChart.Text = "График";
            tabPageChart.UseVisualStyleBackColor = true;
            // 
            // FormMain_DIA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(tabControl1);
            Controls.Add(toolStripCommandPanel_DIA);
            MinimumSize = new Size(800, 600);
            Name = "FormMain_DIA";
            Text = "Спринт 7 | Вариант 3 | Донской И. А.";
            toolStripCommandPanel_DIA.ResumeLayout(false);
            toolStripCommandPanel_DIA.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageMain.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBrowseTable_DIA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelUp;
        private Button buttonLoadTable;
        private Button buttonSaveTable;
        private ToolTip toolTipTips_DIA;
        private Button buttonSaveTable_DIA;
        private Button buttonLoadTable_DIA;
        private ToolStrip toolStripCommandPanel_DIA;
        private ToolStripSplitButton toolStripSplitButtonManageFile_DIA;
        private ToolStripMenuItem toolStripMenuItemOpenFile_DIA;
        private ToolStripMenuItem toolStripMenuItemCreateFile_DIA;
        private ToolStripMenuItem toolStripMenuItemSaveFile_DIA;
        private ToolStripMenuItem toolStripMenuItemSaveFileAs_DIA;
        private ToolStripSplitButton toolStripSplitButtonHelp;
        private ToolStripMenuItem toolStripMenuItemOpenManual_DIA;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItemOpenAbout_DIA;
        private TabControl tabControl1;
        private TabPage tabPageMain;
        private TabPage tabPageChart;
        private DataGridView dataGridViewBrowseTable_DIA;
        private OpenFileDialog openFileDialogOpenFile_DIA;
        private Panel panel1;
        private Button buttonSearch_DIA;
        private Button buttonSearchCancel_DIA;
        private Button buttonAdd_DIA;
        private SaveFileDialog saveFileDialogSaveFile_DIA;
    }
}
