namespace Project.V3
{
    partial class FormSearch_DIA
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
            groupBoxInputSearch_DIA = new GroupBox();
            buttonCancel_DIA = new Button();
            buttonOK_DIA = new Button();
            textBoxInputSearch_DIA = new TextBox();
            groupBoxInputSearch_DIA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxInputSearch_DIA
            // 
            groupBoxInputSearch_DIA.Controls.Add(buttonCancel_DIA);
            groupBoxInputSearch_DIA.Controls.Add(buttonOK_DIA);
            groupBoxInputSearch_DIA.Controls.Add(textBoxInputSearch_DIA);
            groupBoxInputSearch_DIA.Dock = DockStyle.Fill;
            groupBoxInputSearch_DIA.Location = new Point(0, 0);
            groupBoxInputSearch_DIA.Name = "groupBoxInputSearch_DIA";
            groupBoxInputSearch_DIA.Size = new Size(366, 165);
            groupBoxInputSearch_DIA.TabIndex = 0;
            groupBoxInputSearch_DIA.TabStop = false;
            groupBoxInputSearch_DIA.Text = "Найти:";
            // 
            // buttonCancel_DIA
            // 
            buttonCancel_DIA.Location = new Point(279, 130);
            buttonCancel_DIA.Name = "buttonCancel_DIA";
            buttonCancel_DIA.Size = new Size(75, 23);
            buttonCancel_DIA.TabIndex = 2;
            buttonCancel_DIA.Text = "Отмена";
            buttonCancel_DIA.UseVisualStyleBackColor = true;
            buttonCancel_DIA.Click += buttonCancel_DIA_Click;
            // 
            // buttonOK_DIA
            // 
            buttonOK_DIA.Location = new Point(198, 130);
            buttonOK_DIA.Name = "buttonOK_DIA";
            buttonOK_DIA.Size = new Size(75, 23);
            buttonOK_DIA.TabIndex = 1;
            buttonOK_DIA.Text = "ОК";
            buttonOK_DIA.UseVisualStyleBackColor = true;
            buttonOK_DIA.Click += buttonOK_DIA_Click;
            // 
            // textBoxInputSearch_DIA
            // 
            textBoxInputSearch_DIA.Location = new Point(12, 22);
            textBoxInputSearch_DIA.Name = "textBoxInputSearch_DIA";
            textBoxInputSearch_DIA.Size = new Size(342, 23);
            textBoxInputSearch_DIA.TabIndex = 0;
            // 
            // FormSearch_DIA
            // 
            AcceptButton = buttonOK_DIA;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel_DIA;
            ClientSize = new Size(366, 165);
            Controls.Add(groupBoxInputSearch_DIA);
            Name = "FormSearch_DIA";
            Text = "Поиск";
            groupBoxInputSearch_DIA.ResumeLayout(false);
            groupBoxInputSearch_DIA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxInputSearch_DIA;
        private Button buttonCancel_DIA;
        private Button buttonOK_DIA;
        private TextBox textBoxInputSearch_DIA;
    }
}