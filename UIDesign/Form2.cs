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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Custom();
        }
        public void Custom()
        {
            QLNV_subpanel.Visible = false;
            TTCN_subpanel.Visible = false;
            QLSP_subpanel.Visible = false;
            subQLSP_subpanel.Visible = false;
            QLK_subpanel.Visible = false;
            QLXNK_subpanel.Visible = false;
        }
        //public void hidesubmenu()
        //{
        //    if (QLNV_subpanel.Visible == true) QLNV_subpanel.Visible = false;
        //    //if (TTCN_subpanel.Visible == true) TTCN_subpanel.Visible = false;
        //}
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

        private void Button_QLNV_Click(object sender, EventArgs e)
        {
            showsubmenu(QLNV_subpanel);
            TTCN_subpanel.Visible = false;


        }

        private void Button_subQLNV_TTCN_Click(object sender, EventArgs e)
        {
            showsubmenu(TTCN_subpanel);

        }

        private void Button_QLSP_Click(object sender, EventArgs e)
        {
            showsubmenu(QLSP_subpanel);
            subQLSP_subpanel.Visible = false;
        }

        private void Button_subQLSP_QLSP_Click(object sender, EventArgs e)
        {
            showsubmenu(subQLSP_subpanel);
        }

        private void Button_logout_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn chắc  chắc muốn thoát chứ ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.No) return;
            if (d == DialogResult.Yes) this.Dispose();
            
        }

        private void Button_QLK_Click(object sender, EventArgs e)
        {
            showsubmenu(QLK_subpanel);
            QLXNK_subpanel.Visible = false;
            
        }

        private void Button_subQLK_QLXNK_Click(object sender, EventArgs e)
        {
            showsubmenu(QLXNK_subpanel);
        }

        private void Button_subQLSPsub_show_Click(object sender, EventArgs e)
        {
            FormSanPham f = new FormSanPham();
            openChildform(f);
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

        private void Button_subTTCN_show_Click(object sender, EventArgs e)
        {
            FormNhanVien f = new FormNhanVien();
            openChildform(f);
        }

        private void Button_subQLXNK_show_Click(object sender, EventArgs e)
        {
            FormKho f = new FormKho();
            openChildform(f);
        }
    }
}
