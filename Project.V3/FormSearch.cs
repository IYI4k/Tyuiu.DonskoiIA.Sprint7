using Project.V3.Lib;
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
    public partial class FormSearch_DIA : Form
    {
        public FormSearch_DIA()
        {
            InitializeComponent();
        }

        bool search = false;

        public bool Search()
        {
            return search;
        }

        string search_text;

        public string Search_text()
        {
            return search_text;
        }

        private void buttonCancel_DIA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_DIA_Click(object sender, EventArgs e)
        {
            search_text = textBoxInputSearch_DIA.Text;
            search = true;
            this.Close();
        }
    }
}
