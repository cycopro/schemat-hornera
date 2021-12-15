using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace schemat_hornera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            podstawa.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(podstawa.Text);
            string s = liczba.Text;
            s = s.ToUpper();
            int x;
            int y =0;

            for (int i = 0; i < s.Length; i++)
            {
                x = s[i] - 48;
                if(s[i]>64)
                {
                    x = 10 + (s[i] - 65);
                }
                y = y * p + x;
            }

            wynik.Text = Convert.ToString(y);
            
            
        }

        private void TextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            liczba.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
