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
        public FormSanPham()
        {
            InitializeComponent();
            ShowDTGV();
            SetCBB();
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
                comboBox1.Items.Add(new CBBItems
                {
                    Value = 0,
                    Text = "All"
                });
                foreach (LoaiSanPham i in db.LoaiSanPhams)
                {
                    comboBox1.Items.Add(new CBBItems
                    {
                        Value = i.lID,
                        Text = i.TypeName
                    });
                }
            }
            comboBox1.SelectedIndex = 0;
        }
        private void Button_subQLSP_search_Click(object sender, EventArgs e)
        {
            if (textBox_search.Text == "Tìm kiếm") textBox_search.Clear();
            SE_07 db = new SE_07();
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
        }

        private void Button_subQLSP_delete_Click(object sender, EventArgs e)
        {
            SE_07 db = new SE_07();
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count != 0)
            {
                DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa hoạt động này chứ ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    BLL_SanPham.Instance.Del_Bll(r);
                    ShowDTGV();
                }
                if (dr == DialogResult.No) return;
            }
            else MessageBox.Show("Bạn chưa chọn hoạt động nào để xóa !");
        }

        private void Button_subQLSP_sort_Click(object sender, EventArgs e)
        {
            SE_07 db = new SE_07();
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
    }
}
        