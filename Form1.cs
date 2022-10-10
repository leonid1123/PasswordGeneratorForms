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
    /*
    class AllRadioButtons
    {
        public List<RadioButton> RadioButtons;

        public void GetAllRadioButtons()
        {
            RadioButtons = new List<RadioButton>();
            Form1 form1 = new Form1();
            RadioButtons = form1.Controls.OfType<RadioButton>().ToList();
        }
    }
    */
    public partial class Form1 : Form
    {
        //AllRadioButtons allRadioButtons = new AllRadioButtons();
        List<RadioButton> c;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bigLetters = "ABCDEFGHIGKLMNOPQRSTUVWXYZ";
            string smallLetters = "abcdefghijklmnopqrstuvwxyz";
            string numbers = "0123456789";
            string spChars = "~!@#$%^&*()_+/?<>,.:;''[]{}`";
            int numberOfPasswords = trackBar1.Value;
            int passwordLength = 0;
            if (radioButton1.Checked)
            {
                passwordLength = 8;
            } else if (radioButton2.Checked)
            {
                passwordLength = 16;
            } else
            {
                passwordLength = 24;
            }
            for(int i = 0; i < numberOfPasswords; i++)
            {
                for (int j = 0; j < passwordLength; j++)
                {
                    int x = rnd.Next(1,4);
                    switch (x)
                    {
                        case 1:
                            
                            break

                    }
                }
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton r in c) //allRadioButtons.RadioButtons
            {
                r.Checked = false;
            }
            RadioButton rb = (RadioButton)sender;
            rb.Checked = true;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //allRadioButtons.GetAllRadioButtons();
            c = Controls.OfType<RadioButton>().ToList();
            Debug.WriteLine(c.Count);
        }
    }
}
