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
using ClassLibrary1;


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

        ClsTools ct = new ClsTools();        


        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            comboBox1.Items.Add("汽車");
            comboBox1.Items.Add("船");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( comboBox1.Text == "汽車")
            {
                ClsCar cc = new ClsCar();
            }
            else if(comboBox1.Text =="船")
            {
                ClsBoat cb = new ClsBoat();
                checkBox1.Enabled = true;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "汽車")
            {
                ClsCar cc = new ClsCar();
                TotalMile.Text = cc.ClsTools1(int.Parse(Miletext.Text), int.Parse(Oiltext.Text)).ToString();

            }
            else if (comboBox1.Text == "船")
            {
                if(checkBox1.Checked == true)
                {
                    ClsSailBoat csb = new ClsSailBoat();
                    TotalMile.Text = csb.ClsTools1(int.Parse(Miletext.Text), int.Parse(Oiltext.Text)).ToString();
                }
                else
                {
                    ClsBoat cb = new ClsBoat();
                    TotalMile.Text = cb.ClsTools1(int.Parse(Miletext.Text), int.Parse(Oiltext.Text)).ToString();
                }                

            }

            checkBox1.Enabled = false;

               // TotalMile.Text = ct.ClsTools1(int.Parse(Miletext.Text), int.Parse(Oiltext.Text)).ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Fill(this.northWindDataSet1.Products);
            this.dataGridView1.DataSource = this.northWindDataSet1.Products;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            global::ClassLibrary3.ClsProduct x = new ClassLibrary3.ClsProduct();
            this.dataGridView1.DataSource = x.GetProducts();
        }
    }
}
