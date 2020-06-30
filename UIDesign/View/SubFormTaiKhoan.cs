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
    public partial class SubFormTaiKhoan : Form
    {
        public SubFormTaiKhoan()
        {
            InitializeComponent();
            SetCBB();
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn chắc  chắc muốn hủy chứ ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.No) return;
            if (d == DialogResult.Yes) this.Dispose();
        }
        public void SetCBB()
        {
            if (combobox_namenv.Items != null) combobox_namenv.Items.Clear();
            SE_07 db = new SE_07();
            foreach (NhanVien i in db.NhanViens)
            {
                combobox_namenv.Items.Add(new CBBItems
                {
                    Value = i.nvID,
                    Text = i.nvName
                });
            }
        }

        private void Button_ok_Click(object sender, EventArgs e)
        {
            SE_07 db = new SE_07();
            int count = 0;
            try
            {
                string role = textBox_userrole.Text;
                string user = textBox_username.Text;
                string pass = textBox_pass.Text;
                foreach (TaiKhoan i in db.TaiKhoans)
                {
                    if (user == i.UserName)
                    {
                        {
                            MessageBox.Show("Tên đăng nhập đã tồn tại!");
                        }
                    }
                    else {
                        count += 1;
                        if (count == db.TaiKhoans.Count())
                        {
                            TaiKhoan tk = new TaiKhoan
                            {
                                nvID = ((CBBItems)combobox_namenv.SelectedItem).Value,
                                UserName = user,
                                Pass = pass,
                                Type = role
                            };
                            BLL_NhanVien.Instance.AddTaiKhoan_Bll(tk);
                            MessageBox.Show("Tạo tài khoản thành công");
                            this.Dispose();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
