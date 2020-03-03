using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBoxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(Convert.ToInt32(comboBoxBranch.SelectedItem))
            {
                case 1:

                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }
    }
}
