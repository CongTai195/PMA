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
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
            ShowDTGV();
        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void ShowDTGV()
        {
            SE_07 db = new SE_07();
            dataGridView1.DataSource = db.KhachHangs.Select(p => new { p.khID, p.khName, p.Age, p.khPhone}).ToList();
        }

        private void TextBox_search_Click(object sender, EventArgs e)
        {
            if (textBox_search.Text == "Tìm kiếm") textBox_search.Clear();
        }

        private void Button_subQLKH_search_Click(object sender, EventArgs e)
        {
            if (textBox_search.Text == "Tìm kiếm") textBox_search.Clear();
            dataGridView1.DataSource = BLL_KhachHang.Instance.BLL_Search(textBox_search.Text).Select(p => new { p.khID, p.khName, p.Age, p.khPhone }).ToList();
        }

        private void Button_subQLKH_add_Click(object sender, EventArgs e)
        {
            SubFormKhachHang f = new SubFormKhachHang(-1);
            f.D += new SubFormKhachHang.MyDel(ShowDTGV);
            f.ShowDialog();
        }

        private void Button_subQLKH_update_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count == 1)
            {
                int KHID = Convert.ToInt32(r[0].Cells["khID"].Value.ToString());
                SubFormKhachHang f = new SubFormKhachHang(KHID);
                f.D += new SubFormKhachHang.MyDel(ShowDTGV);
                f.ShowDialog();
            }

            if (r.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 hoạt động để cập nhật. ");
            }
        }

        private void Button_subQLKH_delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count != 0)
            {
                DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa hoạt động này chứ ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    BLL_KhachHang.Instance.Del_Bll(r);
                    ShowDTGV();
                }
                if (dr == DialogResult.No) return;
            }
            else MessageBox.Show("Bạn chưa chọn hoạt động nào để xóa !");
        }

        private void Button_subQLKH_sort_Click(object sender, EventArgs e)
        {
            SE_07 db = new SE_07();
            List<int> now = new List<int>();
            foreach (DataGridViewRow i in dataGridView1.Rows)
            {
                if (i.Cells["khID"].Value.ToString() != null)
                    now.Add(Convert.ToInt32(i.Cells["khID"].Value.ToString()));
            }
            List<KhachHang> kh = BLL_KhachHang.Instance.Sort_Bll(now);
            dataGridView1.DataSource = kh.Select(p => new { p.khID, p.khName, p.Age, p.khPhone }).ToList();
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            SE_07 db = new SE_07();
            if (r.Count == 1)
            {
                int khid = Convert.ToInt32(r[0].Cells["khID"].Value.ToString());
                textBox_agekh.Text = Convert.ToInt32(db.KhachHangs.Where(p => p.khID == khid).Select(p => p.Age).FirstOrDefault()).ToString();
                textBox_namenv.Text = db.KhachHangs.Where(p => p.khID == khid).Select(p => p.khName).FirstOrDefault();
                textBox_sdtkh.Text = db.KhachHangs.Where(p => p.khID == khid).Select(p => p.khPhone).FirstOrDefault();
            }
        }
    }
}
