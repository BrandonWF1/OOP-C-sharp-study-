using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2Nesterov402
{
    public partial class Form1 : Form
    {
        matrix A = null;
        matrix B = null;
        matrix C = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(mSize.Value);
            A = new matrix(n);
            B = new matrix(n);
            C = new matrix(n);
            A.set();
            B.set(A, 1);
            C.set(A, 2);
            A.print(mA);
            B.print(mB);
            C.print(mC);
        }


     
        

      

       
    }
}
