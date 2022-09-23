using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGeneratorForms
{
    public partial class Form1 : Form
    {
        List<RadioButton> c;
        public Form1()
        {
            InitializeComponent();
        }


        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton r in c)
            {
                r.Checked = false;
                Debug.WriteLine(r.Name.ToString());
            }
            RadioButton rb = (RadioButton)sender;
            rb.Checked = true;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            c = Controls.OfType<RadioButton>().ToList();
            Debug.WriteLine(c.Count);
        }
    }
}
