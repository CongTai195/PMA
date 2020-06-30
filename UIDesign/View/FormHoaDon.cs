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
        private DataTable _DB;
        public DataTable DB { get => _DB; private set => _DB = value; }
        public FormHoaDon()
        {
            InitializeComponent();
            SetCBB();
            CreateTable();
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
            int count = 0;
            SE_07 db = new SE_07();
            try
            {
                string nameKH = textBox_nameKH.Text;
                int ageKH = Convert.ToInt32(textBox_ageKH.Text);
                string phoneKH = textBox_phoneKH.Text;
                foreach (KhachHang i in db.KhachHangs)
                {
                    if (phoneKH == i.khPhone)
                    {
                        {
                            MessageBox.Show("Số điện thoại không hợp lệ!");
                        }
                    }
                    else
                    {
                        count += 1;
                        if (count == db.KhachHangs.Count())
                        {
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
                            if (comboBox_khachhang.Items != null) comboBox_khachhang.Items.Clear();
                            foreach (KhachHang j in db.KhachHangs)
                            {
                                comboBox_khachhang.Items.Add(new CBBItems
                                {
                                    Value = j.khID,
                                    Text = j.khName
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ComboBox_sanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            SE_07 db = new SE_07();
            int spID = ((CBBItems)comboBox_sanpham.SelectedItem).Value;
            textBox_dongia.Text = db.SanPhams.Where(p => p.spID == spID).Select(p => p.Price).FirstOrDefault();
            textBox_DVT.Text = db.SanPhams.Where(p => p.spID == spID).Select(p => p.Unit).FirstOrDefault();           
        }
        public void CreateTable()
        {
            DB = new DataTable();
            DB.Columns.AddRange(new DataColumn[]{
                new DataColumn("spID",typeof(int)),
                new DataColumn("spName",typeof(string)),
                new DataColumn("DVT",typeof(string)),
                new DataColumn("Quantity",typeof(int)),
                new DataColumn("Price",typeof(string)),
                }
                );
            dataGridView1.DataSource = DB;
        }

        private void Button_subQLBH_add_Click(object sender, EventArgs e)
        {
            try
            {
                int thanhtien = 0;
                int check = 0;
                int quantity;
                if (Convert.ToInt32(numericUpDown_soluong.Value) == 0)
                {
                    MessageBox.Show("Bạn chưa chọn số sản phẩm cần mua!");

                }
                else
                {
                    if (dataGridView1.Rows.Count == 0)
                    {
                        DB.Rows.Add(new object[] {
                                ((CBBItems)comboBox_sanpham.SelectedItem).Value,comboBox_sanpham.SelectedItem.ToString(), textBox_DVT.Text,
                                    Convert.ToInt32(numericUpDown_soluong.Value),textBox_dongia.Text
                            });
                    }
                    else if (dataGridView1.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow i in dataGridView1.Rows)
                        {
                            if (((CBBItems)comboBox_sanpham.SelectedItem).Value == Convert.ToInt32(i.Cells["spID"].Value))
                            {
                                quantity = Convert.ToInt32(i.Cells["Quantity"].Value);
                                quantity += Convert.ToInt32(numericUpDown_soluong.Value);
                                i.Cells["Quantity"].Value = quantity;
                            }
                            else
                            {
                                check += 1;
                                if (check == dataGridView1.Rows.Count)
                                {
                                    DB.Rows.Add(new object[] {
                                ((CBBItems)comboBox_sanpham.SelectedItem).Value,comboBox_sanpham.SelectedItem.ToString(), textBox_DVT.Text,
                                    Convert.ToInt32(numericUpDown_soluong.Value),textBox_dongia.Text
                            });
                                    break;
                                }
                            }
                        }
                    }
                    textBox_DVT.Clear();
                    numericUpDown_soluong.Value = 0;
                    textBox_dongia.Clear();
                }
                foreach (DataGridViewRow i in dataGridView1.Rows)
                {
                    thanhtien += Convert.ToInt32(i.Cells["Quantity"].Value) * Convert.ToInt32(i.Cells["Price"].Value);
                }
                textBox_thanhtien.Text = thanhtien.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_subQLBH_ok_Click(object sender, EventArgs e)
        {
            try
            {
                SE_07 db = new SE_07();
                Bill bill = new Bill
                {
                    nvID = ((CBBItems)comboBox_nhanvien.SelectedItem).Value,
                    khID = ((CBBItems)comboBox_khachhang.SelectedItem).Value,
                    Date = dateTimePicker1.Value.Date,
                    Time = dateTimePicker1.Value.TimeOfDay,
                    Total = textBox_thanhtien.Text
                };
                BLL_Bill.Instance.BLL_Add(bill);
                MessageBox.Show("thêm thành công");
                foreach (DataGridViewRow i in dataGridView1.Rows)
                {
                    DetailBill dtbill = new DetailBill
                    {
                        bID = db.Bills.OrderByDescending(p => p.bID).Select(p => p.bID).FirstOrDefault(),
                        spID = Convert.ToInt32(i.Cells["spID"].Value),
                        DVT = i.Cells["DVT"].Value.ToString(),
                        Quantity = Convert.ToInt32(i.Cells["Quantity"].Value),
                        Price = i.Cells["Price"].Value.ToString(),
                    };
                    BLL_Bill.Instance.BLL_AddDeatialBill(dtbill);
                }
                foreach (DataRow i in DB.Select())
                {
                    DB.Rows.Remove(i);
                    DB.AcceptChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_subQLBH_del_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count != 0)
            {
                List<int> now = new List<int>();
                foreach (DataGridViewRow i in r)
                {
                    if (i.Cells["spID"].Value.ToString() != null)
                        now.Add(Convert.ToInt32(i.Cells["spID"].Value.ToString()));
                }
                foreach (int j in now)
                {
                    foreach (DataRow i in DB.Select())
                    {
                        if (Convert.ToInt32(i["spID"].ToString()) == j)
                        {
                            DB.Rows.Remove(i);
                        }
                    }
                    DB.AcceptChanges();
                }
                int thanhtien = 0;
                foreach (DataGridViewRow i in dataGridView1.Rows)
                {
                    thanhtien += Convert.ToInt32(i.Cells["Quantity"].Value) * Convert.ToInt32(i.Cells["Price"].Value);
                }
                textBox_thanhtien.Text = thanhtien.ToString();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm nào để xóa");
            }
        }
    }
}
