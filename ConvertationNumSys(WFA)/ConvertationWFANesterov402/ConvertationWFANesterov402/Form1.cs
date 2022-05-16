using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertationWFANesterov402
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void N1_ValueChanged(object sender, EventArgs e)
        {
            //очистить табличную панель- настроить панель: строки, столбцы-добавить кнопки button
            TPanel.Controls.Clear();
            Num1.Text = "";
            int n1 = Convert.ToInt32(N1.Value);
            TPanel.ColumnCount = Math.Min(n1, 10);
            TPanel.RowCount = n1 / 11 + 1;
            TPanel.Size = new System.Drawing.Size(TPanel.ColumnCount * 110, TPanel.RowCount * 70);
            List<Button> BList = new List<Button>();
            for (int i=0; i<n1; i++)
            {
                BList.Add(new Button());
                if (i < 10)
                    BList[i].Text = i.ToString();
                else
                    BList[i].Text =((char)(i-10+'A')).ToString();
                BList[i].Size = new System.Drawing.Size(100, 60);
                BList[i].BackColor = Color.Aqua;
                // закрепить событие = щелч. по кнопке
                BList[i].Click+=button_Click;
                TPanel.Controls.Add(BList[i]);

            }

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (Num1.Text != "" || ((Button)sender).Text != "0")
                Num1.Text += ((Button)sender).Text;
           

        }

        private void N2_ValueChanged(object sender, EventArgs e)
        {
            string s1 = Num1.Text;
            int n1 = Convert.ToInt32(N1.Value);
            int n2 = Convert.ToInt32(N2.Value);
            Num2.Text=Convertation.number_sys(s1, n1, n2);

        }
    }
}
