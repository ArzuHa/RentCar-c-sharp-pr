using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class Form1 : Form
    {
        public object RegisterForm { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            Cars frm = new Cars();
                frm.ShowDialog();
        }

        private void btnClientRegister_Click(object sender, EventArgs e)
        {
           Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }
    }
}
