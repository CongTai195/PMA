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
    public partial class FormSanPham : Form
    {
        private string _ROLE;

        public string ROLE { get => _ROLE; set => _ROLE = value; }

        public FormSanPham(string role)
        {
            InitializeComponent();
            ROLE = role;
            ShowDTGV();
            SetCBB();
            SetReadOnly();
            SetRole();
        }
        public void SetRole()
        {
            if (ROLE == "admin")
            {

            } else if (ROLE == "nhanvien")
            {
                button_subQLSP_add.Dispose();
                button_subQLSP_delete.Dispose();
                button_subQLSP_update.Dispose();
            }
        }
        public void SetReadOnly()
        {
            textBox_dvtsp.ReadOnly = true;
            textBox_namesp.ReadOnly = true;
            textBox_pricesp.ReadOnly = true;
            comboBox1.Enabled = false;
        }
        public void SetCBB()
        {
            SE_07 db = new SE_07();
            if (comboBox2.Items != null) comboBox2.Items.Clear();
            {
                comboBox2.Items.Add(new CBBItems
                {
                    Value = 0,
                    Text = "All"
                });
                foreach (LoaiSanPham i in db.LoaiSanPhams)
                {
                    comboBox2.Items.Add(new CBBItems
                    {
                        Value = i.lID,
                        Text = i.TypeName
                    });
                }
            }
            comboBox2.SelectedIndex = 0;
            if (comboBox1.Items != null) comboBox1.Items.Clear();
            {
                foreach (LoaiSanPham i in db.LoaiSanPhams)
                {
                    comboBox1.Items.Add(new CBBItems
                    {
                        Value = i.lID,
                        Text = i.TypeName
                    });
                }
            }
        }
        private void Button_subQLSP_search_Click(object sender, EventArgs e)
        {
            if (textBox_search.Text == "Tìm kiếm") textBox_search.Clear();
            int lid = ((CBBItems)comboBox2.SelectedItem).Value;
            dataGridView1.DataSource = BLL_SanPham.Instance.Search_Bll(lid, textBox_search.Text).Select(p => new { p.spID, p.spName, p.LoaiSanPham.TypeName, p.Unit, p.Price }).ToList();
        }
        public void ShowDTGV()
        {
            SE_07 db = new SE_07();
            dataGridView1.DataSource = db.SanPhams.Select(p => new { p.spID, p.spName, p.LoaiSanPham.TypeName, p.Unit, p.Price }).ToList();
        }

        private void Button_subQLSP_add_Click(object sender, EventArgs e)
        {
            SubFormSanPham f = new SubFormSanPham(-1);
            f.D += new SubFormSanPham.MyDel(ShowDTGV);
            f.ShowDialog();

        }

        private void Button_subQLSP_update_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count == 1)
            {
                int spid = Convert.ToInt32(r[0].Cells["spID"].Value.ToString());
                SubFormSanPham f = new SubFormSanPham(spid);
                f.D += new SubFormSanPham.MyDel(ShowDTGV);
                f.ShowDialog();
            }
            if (r.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm nào để chỉnh sửa");
            }
        }

        private void Button_subQLSP_delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count != 0)
            {
                DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa sản phẩm này chứ ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    BLL_SanPham.Instance.Del_Bll(r);
                    ShowDTGV();
                }
                if (dr == DialogResult.No) return;
            }
            else MessageBox.Show("Bạn chưa chọn sản phẩm nào để xóa !");
        }

        private void Button_subQLSP_sort_Click(object sender, EventArgs e)
        {
            List<int> now = new List<int>();
            foreach (DataGridViewRow i in dataGridView1.Rows)
            {
                if (i.Cells["spID"].Value.ToString() != null)
                    now.Add(Convert.ToInt32(i.Cells["spID"].Value.ToString()));
            }
            List<SanPham> sp = BLL_SanPham.Instance.Sort_Bll(now);
            dataGridView1.DataSource = sp.Select(p => new { p.spID, p.spName, p.LoaiSanPham.TypeName, p.Unit, p.Price }).ToList();
        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TextBox_search_Click(object sender, EventArgs e)
        {
            if (textBox_search.Text == "Tìm kiếm") textBox_search.Clear();
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SE_07 db = new SE_07();
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count == 1)
            {
                int spid = Convert.ToInt32(r[0].Cells["spID"].Value.ToString());
                textBox_namesp.Text = db.SanPhams.Where(p => p.spID == spid).Select(p => p.spName).FirstOrDefault();
                textBox_dvtsp.Text = db.SanPhams.Where(p => p.spID == spid).Select(p => p.Unit).FirstOrDefault();
                textBox_pricesp.Text = db.SanPhams.Where(p => p.spID == spid).Select(p => p.Price).FirstOrDefault();
                int lid = Convert.ToInt32(db.SanPhams.Where(p => p.spID == spid).Select(p => p.lID).FirstOrDefault());
                foreach (CBBItems i in comboBox1.Items)
                {
                    if (i.Value == lid)
                    {
                        comboBox1.SelectedIndex = comboBox1.Items.IndexOf(i);
                    }
                }
            }
        }

        private void Button_subQLNV_addtaikhoan_Click(object sender, EventArgs e)
        {

        }
    }
}
        