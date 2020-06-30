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
    public partial class SubFormSanPham : Form
    {
        private int _SPID;
        public delegate void MyDel();
        private MyDel _D;

        public MyDel D { get => _D; set => _D = value; }
        public int SPID { get => _SPID; set => _SPID = value; }

        public SubFormSanPham(int a)
        {
            InitializeComponent();
            SPID = a;
            SetCBB();
            SetView();
        }
        public void SetCBB()
        {
            SE_07 db = new SE_07();
            if (combobox1.Items != null) combobox1.Items.Clear();
            {
                foreach (LoaiSanPham i in db.LoaiSanPhams)
                {
                    combobox1.Items.Add(new CBBItems
                    {
                        Value = i.lID,
                        Text = i.TypeName
                    });
                }
            }
        }
            public void SetView()
        {
            SE_07 db = new SE_07();
            if (SPID == -1)
            {
                label_add.Visible = true;
                label_update.Visible = false;
            }
            else
            {
                label_update.Visible = true;
                label_add.Visible = false;
                textBox_namesp.Text = db.SanPhams.Where(p => p.spID == SPID).Select(p => p.spName).FirstOrDefault();
                textBox_dvtsp.Text = db.SanPhams.Where(p => p.spID == SPID).Select(p => p.Unit).FirstOrDefault();
                textBox_pricesp.Text = db.SanPhams.Where(p => p.spID == SPID).Select(p => p.Price).FirstOrDefault();
                int lid = Convert.ToInt32(db.SanPhams.Where(p => p.spID == SPID).Select(p => p.lID).FirstOrDefault());
                foreach (CBBItems i in combobox1.Items)
                {
                    if (i.Value == lid)
                    {
                        combobox1.SelectedIndex = combobox1.Items.IndexOf(i);
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
            if (SPID == -1)
            {
                try
                {
                    string spname = textBox_namesp.Text;
                    string unit = textBox_dvtsp.Text;
                    string price = textBox_pricesp.Text;
                    SanPham sp = new SanPham
                    {
                        //spID = 1,
                        spName = spname,
                        Unit = unit,
                        Price = price,
                        lID = ((CBBItems)combobox1.SelectedItem).Value
                    };
                    BLL_SanPham.Instance.Add_Bll(sp);
                    D();
                    this.Dispose();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    string spname = textBox_namesp.Text;
                    string unit = textBox_dvtsp.Text;
                    string price = textBox_pricesp.Text;
                    int lID = ((CBBItems)combobox1.SelectedItem).Value;
                    BLL_SanPham.Instance.Update_Bll(SPID, spname, lID, unit, price);
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
