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
    public partial class SubFormKho : Form
    {
        private int _KhoID;
        public delegate void MyDel();
        private MyDel _D;

        public MyDel D { get => _D; set => _D = value; }
        public int KhoID { get => _KhoID; set => _KhoID = value; }
        public SubFormKho(int a)
        {
            InitializeComponent();
            KhoID = a;
            SetCBBHoatDong();
            SetCBBSanPham();
            SetView();

        }
        public void SetCBBHoatDong()
        {
            if (comboBox_hoatdong.Items != null) comboBox_hoatdong.Items.Clear();
            SE_07 db = new SE_07();
            foreach (HoatDong i in db.HoatDongs)
            {
                comboBox_hoatdong.Items.Add(new CBBItems
                {
                    Value = i.hdID,
                    Text = i.hdName
                });
            }
        }
        public void SetCBBSanPham()
        {
            if (comboBox_sanpham.Items != null) comboBox_sanpham.Items.Clear();
            SE_07 db = new SE_07();
            foreach (SanPham i in db.SanPhams)
            {
                comboBox_sanpham.Items.Add(new CBBItems
                {
                    Value = i.spID,
                    Text = i.spName
                });
            }
        }
        public void SetView()
        {
            SE_07 db = new SE_07();

            if (KhoID == -1)
            {


            }
            else
            {
                label_add.Visible = false;
                if (label_update.Visible == false) label_update.Visible = true;
                textBox_donvitinh.Text = (db.Khoes.Where(p => p.kID == KhoID).Select(p => p.DVT).FirstOrDefault());
                textBox_soluong.Text = db.Khoes.Where(p => p.kID == KhoID).Select(p => p.Quantity).FirstOrDefault().ToString();
                dateTimePicker1.Value = Convert.ToDateTime(db.Khoes.Where(p => p.kID == KhoID).Select(p => p.MFG).FirstOrDefault().ToString());
                dateTimePicker2.Value = Convert.ToDateTime(db.Khoes.Where(p => p.kID == KhoID).Select(p => p.EXP).FirstOrDefault().ToString());
                dateTimePicker3.Value = Convert.ToDateTime(db.Khoes.Where(p => p.kID == KhoID).Select(p => p.Date).FirstOrDefault().ToString());
                int spid = Convert.ToInt32(db.Khoes.Where(p => p.kID == KhoID).Select(p => p.SanPham.spID).FirstOrDefault());
                foreach (CBBItems i in comboBox_sanpham.Items)
                {
                    if (i.Value == spid)
                    {
                        comboBox_sanpham.SelectedIndex = comboBox_sanpham.Items.IndexOf(i);
                    }
                }
                int idk = Convert.ToInt32(db.Khoes.Where(p => p.kID == KhoID).Select(p => p.hdID).FirstOrDefault());
                foreach (CBBItems i in comboBox_hoatdong.Items)
                {
                    if (i.Value == idk)
                    {
                        comboBox_hoatdong.SelectedIndex = comboBox_hoatdong.Items.IndexOf(i);
                    }
                }
            }
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Button_ok_Click(object sender, EventArgs e)
        {
            SE_07 db = new SE_07();
            if (KhoID == -1)
            {
                try
                {
                   // string namesp = textBox_nameSP.Text;
                    string dvt = textBox_donvitinh.Text;
                    int soluong = Convert.ToInt32(textBox_soluong.Text);
                    DateTime nsx = dateTimePicker1.Value.Date;
                    DateTime hsd = dateTimePicker2.Value.Date;
                    DateTime ngaythuchien = dateTimePicker3.Value.Date;
                    Kho kho = new Kho
                    {
                        //kID = 1,
                        spID = ((CBBItems)comboBox_sanpham.SelectedItem).Value,
                        MFG = nsx,
                        EXP = hsd,
                        Date = ngaythuchien,
                        hdID = ((CBBItems)comboBox_hoatdong.SelectedItem).Value,
                        DVT = dvt,
                        Quantity = soluong
                    };
                    BLL_Kho.Instance.Add_Bll(kho);
                    D();
                    this.Dispose();
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }

            }
            else
            {
                try
                {
                    //string namesp = textBox_nameSP.Text;
                    string dvt = textBox_donvitinh.Text;
                    int soluong = Convert.ToInt32(textBox_soluong.Text);
                    DateTime nsx = dateTimePicker1.Value.Date;
                    DateTime hsd = dateTimePicker2.Value.Date;
                    DateTime date = dateTimePicker3.Value.Date;
                    int spID = ((CBBItems)comboBox_sanpham.SelectedItem).Value;
                    int hdID = ((CBBItems)comboBox_hoatdong.SelectedItem).Value;
                    BLL_Kho.Instance.Update_Bll(KhoID, spID, hdID, dvt, soluong, nsx, hsd, date);
                    D();
                    this.Dispose();
                }
                catch (Exception except)
                {
                    MessageBox.Show(except.Message);
                }

            }
        }
    }
}
