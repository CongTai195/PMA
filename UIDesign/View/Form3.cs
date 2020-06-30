using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIDesign
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            custom();
        }
        public void custom()
        {
            QLSP_subpanel.Visible = false;
            QLKH_subpanel.Visible = false;
            QLBH_subpanel.Visible = false;
            QLK_subpanel.Visible = false;
        }
        public void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                //hidesubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void Button_QLSP_Click(object sender, EventArgs e)
        {
            showsubmenu(QLSP_subpanel);
        }

        private void Button_QLBH_Click(object sender, EventArgs e)
        {
            showsubmenu(QLBH_subpanel);
        }

        private void Button_QLK_Click(object sender, EventArgs e)
        {
            showsubmenu(QLK_subpanel);
        }

        private void Button_QLKH_Click(object sender, EventArgs e)
        {
            showsubmenu(QLKH_subpanel);
        }
        public Form activeForm = null;
        public void openChildform(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel4.Controls.Add(childForm);
            panel4.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Button_logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Button_subQLBH_add_Click(object sender, EventArgs e)
        {
            openChildform(new FormHoaDon());
        }

        private void Button_subQLSP_QLSP_Click(object sender, EventArgs e)
        {
            FormSanPham f = new FormSanPham("nhanvien");
            openChildform(f);
        }

        private void Button_subQLK_QLXNK_Click(object sender, EventArgs e)
        {
            FormKho f = new FormKho("nhanvien");
            openChildform(f);
        }

        private void Button_subQLKH_show_Click(object sender, EventArgs e)
        {
            FormKhachHang f = new FormKhachHang();
            openChildform(f);
        }

        private void Button_subQLBH_QLDH_Click(object sender, EventArgs e)
        {
            FormDonHang f = new FormDonHang();
            openChildform(f);
        }
    }
}
