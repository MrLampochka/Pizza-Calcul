using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Calcul
{
    public partial class UC : UserControl
    {
        public UC()
        {
            InitializeComponent();
        }

        public void metroButton1_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(metroTextBox1.Text) >= Convert.ToDouble(metroTextBox2.Text))
                metroTextBox5.Text = Convert.ToString(Math.Round(Math.Pow(Convert.ToDouble(metroTextBox1.Text) - Convert.ToDouble(metroTextBox2.Text), 2) / 4 * Math.PI, 2));
            else metroTextBox5.Text = "0";
            metroTextBox3.Text = Convert.ToString(Math.Round(Math.Pow(Convert.ToDouble(metroTextBox1.Text), 2) / 4 * Math.PI, 2));
            metroTextBox6.Text = Convert.ToString(Math.Round(Convert.ToDouble(metroTextBox4.Text)/ Convert.ToDouble(metroTextBox3.Text)*10000, 2));
        }

        public void NameBox(int n)
        {
            metroLabel6.Text = "Пицца №" + n;
        }

        public void Winner()
        {
            metroLabel14.Visible = true ;
        }

        public void WinnerOf()
        {
            metroLabel14.Visible = false;
        }
        public float GetNavar()
        {
            return Convert.ToSingle(metroTextBox6.Text);
        }

        public float GetPlace()
        {
            return Convert.ToSingle(metroTextBox3.Text);
        }
    }
}
