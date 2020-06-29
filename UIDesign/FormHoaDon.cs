using System;
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
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
            SetCBB();
        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void SetCBB()
        {
            SE_07 db = new SE_07();
            if (comboBox_nhanvien.Items != null) comboBox_nhanvien.Items.Clear();
                foreach (NhanVien i in db.NhanViens)
                {
                    comboBox_nhanvien.Items.Add(new CBBItems
                    {
                        Value = i.nvID,
                        Text = i.nvName
                    });
                }
            if (comboBox_sanpham.Items != null) comboBox_sanpham.Items.Clear();
            foreach (SanPham i in db.SanPhams)
            {
                comboBox_sanpham.Items.Add(new CBBItems
                {
                    Value = i.spID,
                    Text = i.spName
                });
            }
            if (comboBox_khachhang.Items != null) comboBox_khachhang.Items.Clear();
            foreach (KhachHang i in db.KhachHangs)
            {
                comboBox_khachhang.Items.Add(new CBBItems
                {
                    Value = i.khID,
                    Text = i.khName
                });
            }
        }

        private void Button_subQLKH_add_Click(object sender, EventArgs e)
        {
            string nameKH = textBox_nameKH.Text;
            int ageKH = Convert.ToInt32(textBox_ageKH.Text);
            string phoneKH = textBox_phoneKH.Text;
            KhachHang kh = new KhachHang
            {
                khName = nameKH,
                Age = ageKH,
                khPhone = phoneKH
            };
            BLL_KhachHang.Instance.BLL_Add(kh);
            MessageBox.Show("Thêm thành công");
            textBox_ageKH.Clear();
            textBox_phoneKH.Clear();
            textBox_nameKH.Clear();
        }

        private void ComboBox_sanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            SE_07 db = new SE_07();
            int spID = ((CBBItems)comboBox_sanpham.SelectedItem).Value;
            textBox_dongia.Text = db.SanPhams.Where(p => p.spID == spID).Select(p => p.Price).FirstOrDefault();
            textBox_DVT.Text = db.SanPhams.Where(p => p.spID == spID).Select(p => p.Unit).FirstOrDefault();           
        }
    }
}
