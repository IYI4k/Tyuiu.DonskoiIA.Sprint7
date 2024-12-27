namespace Project.V3
{
    partial class FormAddLine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewNewLine_DIA = new DataGridView();
            buttonOK_DIA = new Button();
            buttonCancel_DIA = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNewLine_DIA).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewNewLine_DIA
            // 
            dataGridViewNewLine_DIA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewNewLine_DIA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNewLine_DIA.Location = new Point(12, 12);
            dataGridViewNewLine_DIA.Name = "dataGridViewNewLine_DIA";
            dataGridViewNewLine_DIA.Size = new Size(360, 91);
            dataGridViewNewLine_DIA.TabIndex = 0;
            // 
            // buttonOK_DIA
            // 
            buttonOK_DIA.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonOK_DIA.Location = new Point(12, 184);
            buttonOK_DIA.Name = "buttonOK_DIA";
            buttonOK_DIA.Size = new Size(75, 23);
            buttonOK_DIA.TabIndex = 1;
            buttonOK_DIA.Text = "ОК";
            buttonOK_DIA.UseVisualStyleBackColor = true;
            buttonOK_DIA.Click += buttonOK_DIA_Click;
            // 
            // buttonCancel_DIA
            // 
            buttonCancel_DIA.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel_DIA.Location = new Point(297, 184);
            buttonCancel_DIA.Name = "buttonCancel_DIA";
            buttonCancel_DIA.Size = new Size(75, 23);
            buttonCancel_DIA.TabIndex = 2;
            buttonCancel_DIA.Text = "Отмена";
            buttonCancel_DIA.UseVisualStyleBackColor = true;
            buttonCancel_DIA.Click += buttonCancel_DIA_Click;
            // 
            // FormAddLine
            // 
            AcceptButton = buttonCancel_DIA;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel_DIA;
            ClientSize = new Size(384, 219);
            Controls.Add(buttonCancel_DIA);
            Controls.Add(buttonOK_DIA);
            Controls.Add(dataGridViewNewLine_DIA);
            MinimumSize = new Size(205, 212);
            Name = "FormAddLine";
            Text = "Добавить запись";
            ((System.ComponentModel.ISupportInitialize)dataGridViewNewLine_DIA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewNewLine_DIA;
        private Button buttonOK_DIA;
        private Button buttonCancel_DIA;
    }
}