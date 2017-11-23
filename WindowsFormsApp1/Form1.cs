using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banking;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            global::Banking.ClsBanking a = new ClsBanking();//global::所以有命名空間最底層
            MessageBox.Show(a.Deposit(1000).ToString());

            ClsSpecialBanking b = new ClsSpecialBanking();
            MessageBox.Show(b.Deposit(1000).ToString());
        }
    }
}
