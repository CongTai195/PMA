﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIDesign.BLL;

namespace UIDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Label1_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn chắc  chắc muốn thoát chứ ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.No) return;
            if (d == DialogResult.Yes) this.Dispose();
        }
        private void TextBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username") textBox1.Clear();
        }
        private void TextBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password") textBox2.Clear();
        }
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
        private void Button_login_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            BLL_Login.Instance.LogIn(user, pass);
            textBox1.Text = "Username";
            textBox2.Text = "Password";
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 )
            {
                string user = textBox1.Text;
                string pass = textBox2.Text;
                BLL_Login.Instance.LogIn(user, pass);
                textBox1.Text = "Username";
                textBox2.Text = "Password";
            }
        }
    }
}
