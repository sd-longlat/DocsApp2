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
                    comboBoxAddress.Text = "ул. Московская, 19/8 (БЦ Кремлевская Плаза)";
                    break;
                case 2:
                    comboBoxAddress.Text = "ул.Петербургская, д.1, ТЦ Кольцо";
                    break;
                case 3:
                    comboBoxAddress.Text = "Проспект Победы, 141, СТЦ МЕГА";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2(Convert.ToInt32(comboBoxBranch.SelectedItem),
                comboBoxAddress.Text,
                Convert.ToInt32(numericUpDownTill.Value),
                comboBoxFIO.Text);
            Form2.ShowDialog();
        }
    }
}
