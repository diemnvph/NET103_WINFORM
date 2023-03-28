using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NET103_WINFORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //đổi màu button
            button1.BackColor = Color.Red;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Nhập đủ các trường");
            }
           
            else
            {
                MessageBox.Show("Chào mừng");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int i = 0;
        void AddButton()
        {
            Random rd = new Random();
            Button btn = new Button() { Text= i.ToString(),Location = new Point(rd.Next(0,this.Size.Width),rd.Next(0,this.Height)) };
            this.Controls.Add(btn);
            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show(btn.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddButton();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (Int32.TryParse(txtvalue.Text,out num))
            {
                num = int.Parse(txtvalue.Text);
                lbvalue.Text = (num * num).ToString();
            }
            else
            {
                lbvalue.Text = " vui lòng nhập số";
            }
             
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
