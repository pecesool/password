using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        { int kolichestvo=0, dlina=0;
            string elements = textBox1.Text;
            try {int dl = Convert.ToInt32(textBox2.Text);
            int kol = Convert.ToInt32(textBox3.Text);
                kolichestvo = kol;
                dlina = dl;
            }
            
            catch
            {
                MessageBox.Show("Убедитесь что ввели числовые данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Text = "";
                textBox2.Text = "";
            }

            
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                int b = elements.Length;
                string[] val = new string[b];
                for(int i = 0; i < b; i++)
                {
                   val[i]=elements[i].ToString() ;
                    
                }
                
                for(int i = 0; i < kolichestvo + 1; i++)
                {
                    for(int j = 0; j < dlina + 1; j++)
                    {
                        Random rand = new Random();
                        int r = rand.Next(0, b);
                        richTextBox1.Text = richTextBox1.Text + val[r];
                    }
                    richTextBox1.Text = richTextBox1.Text + "\n";
                }
            }

        }
    }
}
