using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.IO;

namespace Pizza_Calcul
{
    public partial class Form1 : MetroForm
    {
        

        private List<UC> uc = new List<UC>();
        public Form1()
        {
            InitializeComponent();
            uc.Add(uc1);
        }

        private int N = 1;

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            N++;

            this.uc.Add(new UC() { Name = "uc" + Convert.ToString(N), Location = new System.Drawing.Point(uc.Last().Location.X, uc.Last().Location.Y + uc1.Size.Height) });
            this.uc.Last().NameBox(N);
            metroPanel2.Location = new System.Drawing.Point(metroPanel2.Location.X, metroPanel2.Location.Y + uc1.Size.Height);
            metroPanel1.Controls.Add(uc.Last());
            metroButton2.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (N > 1)
            {
                N--;
                uc.Last().Dispose();
                this.uc.Remove(uc.Last());
                if (N == 1) metroButton2.Enabled = false;
                metroPanel2.Location = new System.Drawing.Point(metroPanel2.Location.X, metroPanel2.Location.Y - uc1.Size.Height);
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            float Sum = this.uc.ElementAt(0).GetNavar();
            int ID = 0;
            for (int n = 0; n < this.uc.Count; n++)
                this.uc.ElementAt(n).metroButton1_Click(sender, e);

            for (int i = 0; i<this.uc.Count;i++)
            {
                this.uc.ElementAt(i).WinnerOf();
                if (Sum > this.uc.ElementAt(i).GetNavar())
                {
                    Sum = this.uc.ElementAt(i).GetNavar();
                    ID = i;
                }
                
            }
            if (Sum == 0)
            {
                ID = 0;
                float Pl = 0;
                
                for (int i = 0; i < this.uc.Count; i++)
                {
                    if (Pl < this.uc.ElementAt(i).GetPlace())
                    {
                        Pl = this.uc.ElementAt(i).GetPlace();
                        ID = i;
                    }

                }
            }
            this.uc.ElementAt(ID).Winner();
        }
    }
}
