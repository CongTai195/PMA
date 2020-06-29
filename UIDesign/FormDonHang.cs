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
    public partial class FormDonHang : Form
    {
        public FormDonHang()
        {
            InitializeComponent();
        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Button_subQLBH_search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_Bill.Instance.BLL_Search(dateTimePicker1.Value, dateTimePicker2.Value).Select(p => new { p.bID, p.Date, p.NhanVien.nvName, p.KhachHang.khName, p.KhachHang.khPhone}).ToList();
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //int thanhtien = 0;
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            SE_07 db = new SE_07();
            if (r.Count == 1)
            {
                int bid = Convert.ToInt32(r[0].Cells["bID"].Value.ToString());
                dataGridView2.DataSource = db.DetailBills.Where(p => p.bID == bid).Select(p => new { p.SanPham.spName, p.SanPham.Unit , p.Quantity, p.SanPham.Price }).ToList();
                textBox_thanhtien.Text = db.Bills.Where(p => p.bID == bid).Select(p => p.Total).FirstOrDefault();
            }
            //foreach (DataGridViewRow i in dataGridView2.Rows)
            //{
            //    thanhtien += Convert.ToInt32(i.Cells["Quantity"].Value)* Convert.ToInt32(i.Cells["Price"].Value);
            //}
            //textBox_thanhtien.Text = thanhtien.ToString();
        }

        private void Button_subQLBH_sort_Click(object sender, EventArgs e)
        {
            List<int> now = new List<int>();
            foreach (DataGridViewRow i in dataGridView1.Rows)
            {
                if (i.Cells["bID"].Value.ToString() != null)
                    now.Add(Convert.ToInt32(i.Cells["bID"].Value.ToString()));
            }
            List<Bill> b = BLL_Bill.Instance.Sort_Bll(now);
            dataGridView1.DataSource = b.Select(p => new { p.bID, p.Date, p.NhanVien.nvName, p.KhachHang.khName, p.KhachHang.khPhone }).OrderByDescending(p => p.Date).ToList();
        }
    }
}
