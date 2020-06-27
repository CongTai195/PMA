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
    public partial class SubFormKhachHang : Form
    {
        private int _KHID;
        public delegate void MyDel();
        private MyDel _D;
        public SubFormKhachHang(int a)
        {
            InitializeComponent();
            KHID = a;
            SetView();
        }

        public int KHID { get => _KHID; set => _KHID = value; }
        public MyDel D { get => _D; set => _D = value; }

        public void SetView()
        {
            SE_07 db = new SE_07();
            if (KHID == -1)
            {
                label_add.Visible = true;
                label_update.Visible = false;
            }
            else
            {
                label_update.Visible = true;
                label_add.Visible = false;
                textBox_namekh.Text = db.KhachHangs.Where(p => p.khID == KHID).Select(p => p.khName).FirstOrDefault();
                textBox_phonekh.Text = db.KhachHangs.Where(p => p.khID == KHID).Select(p => p.khPhone).FirstOrDefault();
                textBox_agekh.Text = Convert.ToInt32(db.KhachHangs.Where(p => p.khID == KHID).Select(p => p.Age).FirstOrDefault()).ToString();
            }
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Button_ok_Click(object sender, EventArgs e)
        {
            SE_07 db = new SE_07();
            if (KHID== -1)
            {
                try
                {
                    string nameKH = textBox_namekh.Text;
                    int ageKH = Convert.ToInt32(textBox_agekh.Text);
                    string phoneKH = textBox_phonekh.Text;
                    KhachHang kh = new KhachHang
                    {
                        khName = nameKH,
                        Age = ageKH,
                        khPhone = phoneKH
                    };
                    BLL_KhachHang.Instance.BLL_Add(kh);
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
                    string nameKH = textBox_namekh.Text;
                    int ageKH = Convert.ToInt32(textBox_agekh.Text);
                    string phoneKH = textBox_phonekh.Text;
                    BLL_KhachHang.Instance.BLL_Update(KHID, nameKH, ageKH, phoneKH);
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
