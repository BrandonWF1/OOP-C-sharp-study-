using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog1
{
    public partial class Form1 : Form
    {
        private void printConvert()
        {
            string s1 = textBox1.Text;
            int n1 = Convert.ToInt32(nUD1.Value);
            int n2 = Convert.ToInt32(nUD2.Value);
            textBox2.Text = baseConvert.number_sys(s1, n1, n2);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void nUD1_ValueChanged(object sender, EventArgs e)
        {
            tlPanel.Controls.Clear();
            textBox1.Text = "";
            int n1 = Convert.ToInt32(nUD1.Value);
            tlPanel.ColumnCount = Math.Min(n1, 10);
            tlPanel.RowCount = n1 / 10 + 1;
            tlPanel.Size = new System.Drawing.Size(tlPanel.ColumnCount*50, tlPanel.RowCount*50);
            List<Button> BList = new List<Button>();
            for (int i=0;i<n1;i++)
            {
                BList.Add(new Button());
                if (i < 10)
                    BList[i].Text = i.ToString();
                else
                    BList[i].Text = ((char)(i-10+'A')).ToString();
                BList[i].Size = new System.Drawing.Size(40, 40);
                BList[i].BackColor = Color.DodgerBlue;

                BList[i].Click += button_Click;
                tlPanel.Controls.Add(BList[i]);
            }
            printConvert();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="" || ((Button)sender).Text!="0")
                textBox1.Text += ((Button)sender).Text;
            printConvert();
        }

        private void nUD2_ValueChanged(object sender, EventArgs e)
        {
            printConvert();
        }
    }
}
