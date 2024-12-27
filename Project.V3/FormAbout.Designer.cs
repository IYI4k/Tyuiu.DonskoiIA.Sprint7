namespace Project.V3
{
    partial class FormAbout_DIA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_DIA));
            pictureBoxAvatar_DIA = new PictureBox();
            textBoxInfo_DIA = new TextBox();
            buttonOK_DIA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_DIA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_DIA
            // 
            pictureBoxAvatar_DIA.Image = Properties.Resources.FotoResized;
            pictureBoxAvatar_DIA.Location = new Point(12, 12);
            pictureBoxAvatar_DIA.Name = "pictureBoxAvatar_DIA";
            pictureBoxAvatar_DIA.Size = new Size(316, 400);
            pictureBoxAvatar_DIA.TabIndex = 2;
            pictureBoxAvatar_DIA.TabStop = false;
            // 
            // textBoxInfo_DIA
            // 
            textBoxInfo_DIA.Location = new Point(334, 12);
            textBoxInfo_DIA.Multiline = true;
            textBoxInfo_DIA.Name = "textBoxInfo_DIA";
            textBoxInfo_DIA.ReadOnly = true;
            textBoxInfo_DIA.Size = new Size(454, 353);
            textBoxInfo_DIA.TabIndex = 3;
            textBoxInfo_DIA.Text = resources.GetString("textBoxInfo_DIA.Text");
            // 
            // buttonOK_DIA
            // 
            buttonOK_DIA.Location = new Point(713, 389);
            buttonOK_DIA.Name = "buttonOK_DIA";
            buttonOK_DIA.Size = new Size(75, 23);
            buttonOK_DIA.TabIndex = 4;
            buttonOK_DIA.Text = "OK";
            buttonOK_DIA.UseVisualStyleBackColor = true;
            buttonOK_DIA.Click += buttonOK_DIA_Click;
            // 
            // FormAbout_DIA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 424);
            Controls.Add(buttonOK_DIA);
            Controls.Add(textBoxInfo_DIA);
            Controls.Add(pictureBoxAvatar_DIA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormAbout_DIA";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_DIA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAvatar_DIA;
        private TextBox textBoxInfo_DIA;
        private Button buttonOK_DIA;
    }
}