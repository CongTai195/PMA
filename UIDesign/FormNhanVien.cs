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
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
            ShowDTGV();
            SetReadOnly();
        }
        public void SetReadOnly()
        {
            textBox_cmndnv.ReadOnly = true;
            textBox_diachinv.ReadOnly = true;
            textBox_luongnv.ReadOnly = true;
            textBox_namenv.ReadOnly = true;
            textBox_sdtnv.ReadOnly = true;
            dateTimePicker1.Enabled = false;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_subTTCN_search_Click(object sender, EventArgs e)
        {
            if (textBox_search.Text == "Tìm kiếm") textBox_search.Clear();
            dataGridView1.DataSource = BLL_NhanVien.Instance.Search_Bll(textBox_search.Text).Select(p => new { p.nvID, p.nvName, p.nvIDNumber, p.nvPhone, p.nvDOB, p.Salary, p.nvAddress }).ToList();
        }
        public void ShowDTGV()
        {
            SE_07 db = new SE_07();
            dataGridView1.DataSource = db.NhanViens.Select(p => new { p.nvID, p.nvName, p.nvIDNumber, p.nvPhone, p.nvDOB, p.Salary, p.nvAddress }).ToList();
        }

        private void Button_subTTCN_add_Click(object sender, EventArgs e)
        {
            SubFormNhanVien f = new SubFormNhanVien(-1);
            f.D += new SubFormNhanVien.MyDel(ShowDTGV);
            f.ShowDialog();
        }

        private void Button_subTTCN_update_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count == 1)
            {
                int NVID = Convert.ToInt32(r[0].Cells["nvID"].Value.ToString());
                SubFormNhanVien f = new SubFormNhanVien(NVID);
                f.D += new SubFormNhanVien.MyDel(ShowDTGV);
                f.ShowDialog();
            }
            if (r.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 nhân viên để chỉnh sửa");
            }
        }

        private void Button_subTTCN_delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count != 0)
            {
                DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này chứ ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    BLL_NhanVien.Instance.Del_Bll(r);
                    ShowDTGV();
                }
                if (dr == DialogResult.No) return;
            }
            else MessageBox.Show("Bạn chưa chọn nhân viên nào để xóa !");
        }

        private void Button_subTTCN_sort_Click(object sender, EventArgs e)
        {
            SE_07 db = new SE_07();
            List<int> now = new List<int>();
            foreach (DataGridViewRow i in dataGridView1.Rows)
            {
                if (i.Cells["nvID"].Value.ToString() != null)
                    now.Add(Convert.ToInt32(i.Cells["nvID"].Value.ToString()));
            }
            List<NhanVien> nv = BLL_NhanVien.Instance.Sort_Bll(now);
            dataGridView1.DataSource = nv.Select(p => new { p.nvID, p.nvName, p.nvIDNumber, p.nvPhone, p.nvDOB, p.Salary, p.nvAddress }).ToList();
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            SE_07 db = new SE_07();
            if (r.Count == 1)
            {
                int NvID = Convert.ToInt32(r[0].Cells["nvID"].Value.ToString());
                textBox_namenv.Text = db.NhanViens.Where(p => p.nvID == NvID).Select(p => p.nvName).FirstOrDefault();
                textBox_cmndnv.Text = db.NhanViens.Where(p => p.nvID == NvID).Select(p => p.nvIDNumber).FirstOrDefault();
                textBox_diachinv.Text = db.NhanViens.Where(p => p.nvID == NvID).Select(p => p.nvAddress).FirstOrDefault();
                textBox_luongnv.Text = db.NhanViens.Where(p => p.nvID == NvID).Select(p => p.Salary).FirstOrDefault();
                textBox_sdtnv.Text = db.NhanViens.Where(p => p.nvID == NvID).Select(p => p.nvPhone).FirstOrDefault();
                dateTimePicker1.Value = Convert.ToDateTime(db.NhanViens.Where(p => p.nvID == NvID).Select(p => p.nvDOB).FirstOrDefault().ToString());
            }
        }

        private void TextBox_search_Click(object sender, EventArgs e)
        {
            if (textBox_search.Text == "Tìm kiếm") textBox_search.Clear();
        }
    }
}
