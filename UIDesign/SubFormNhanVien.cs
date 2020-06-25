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
    public partial class SubFormNhanVien : Form
    {
        private int _nvID;
        public delegate void MyDel();
        private MyDel _D;

        public MyDel D { get => _D; set => _D = value; }
        public int NvID { get => _nvID; set => _nvID = value; }

        public SubFormNhanVien(int a)
        {
            InitializeComponent();
            NvID = a;
            SetView();
        }
        public void SetView()
        {
            SE_07 db = new SE_07();
            if (NvID == -1)
            {
                label_add.Visible = true;
                label_update.Visible = false;
            }
            else
            {
                label_update.Visible = true;
                label_add.Visible = false;
                textBox_namenv.Text = db.NhanViens.Where(p => p.nvID == NvID).Select(p => p.nvName).FirstOrDefault();
                textBox_cmndnv.Text = db.NhanViens.Where(p => p.nvID == NvID).Select(p => p.nvIDNumber).FirstOrDefault();
                textBox_diachinv.Text = db.NhanViens.Where(p => p.nvID == NvID).Select(p => p.nvAddress).FirstOrDefault();
                textBox_luongnv.Text = db.NhanViens.Where(p => p.nvID == NvID).Select(p => p.Salary).FirstOrDefault();
                textBox_phonenv.Text = db.NhanViens.Where(p => p.nvID == NvID).Select(p => p.nvPhone).FirstOrDefault();
                dateTimePicker1.Value = Convert.ToDateTime(db.NhanViens.Where(p => p.nvID == NvID).Select(p => p.nvDOB).FirstOrDefault().ToString());
            }
        }
        private void Button_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Button_ok_Click(object sender, EventArgs e)
        {
            SE_07 db = new SE_07();
            if (NvID == -1)
            {
                try
                {
                    int nvid = 1;
                    string namenv = textBox_namenv.Text;
                    DateTime dob = dateTimePicker1.Value.Date;
                    string diachi = textBox_diachinv.Text;
                    string sdt = textBox_phonenv.Text;
                    string cmnd = textBox_cmndnv.Text;
                    string luong = textBox_luongnv.Text;
                    NhanVien nv = new NhanVien
                    {
                        nvID = nvid,
                        nvName = namenv,
                        nvDOB = dob,
                        nvAddress = diachi,
                        nvPhone = sdt,
                        nvIDNumber = cmnd,
                        Salary = luong,
                        DayOn = 0,
                        DayOff = 0
                    };
                    BLL_NhanVien.Instance.Add_Bll(nv);
                    D();
                    this.Dispose();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                try
                {
                    string namenv = textBox_namenv.Text;
                    DateTime dob = dateTimePicker1.Value.Date;
                    string diachi = textBox_diachinv.Text;
                    string sdt = textBox_phonenv.Text;
                    string cmnd = textBox_cmndnv.Text;
                    string luong = textBox_luongnv.Text;
                    BLL_NhanVien.Instance.Update_Bll(NvID,namenv,dob,cmnd,sdt,diachi,luong);
                    D();
                    this.Dispose();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
