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
    public partial class FormKho : Form
    {
        public FormKho()
        {
            InitializeComponent();
            ShowDTGV();
            SetCBB();
        }

        public void SetCBB()
        {
            SE_07 db = new SE_07();
            if (comboBox_hoatdong.Items != null) comboBox_hoatdong.Items.Clear();
            {
                comboBox_hoatdong.Items.Add(new CBBItems
                {
                    Value = 0,
                    Text = "All"
                });
                foreach (HoatDong i in db.HoatDongs)
                {
                    comboBox_hoatdong.Items.Add(new CBBItems
                    {
                        Value = i.hdID,
                        Text = i.hdName
                    });
                }
            }
            comboBox_hoatdong.SelectedIndex = 0;
        }

        private void TextBox_search_Click(object sender, EventArgs e)
        {
            if (textBox_search.Text == "Tìm kiếm") textBox_search.Clear();
        }
        public void ShowDTGV()
        {
            SE_07 db = new SE_07();
            dataGridView1.DataSource = db.Khoes.Select(p => new { p.kID, p.HoatDong.hdName, p.SanPham.spName, p.DVT, p.Quantity, p.MFG, p.EXP, p.Date }).ToList();
        }

        private void TextBox_search_Click_1(object sender, EventArgs e)
        {
            if (textBox_search.Text == "Tìm kiếm") textBox_search.Clear();
        }

        private void Button_subQLK_search_Click(object sender, EventArgs e)
        {
            if (textBox_search.Text == "Tìm kiếm") textBox_search.Clear();
            SE_07 db = new SE_07();
            int kid = ((CBBItems)comboBox_hoatdong.SelectedItem).Value;
            dataGridView1.DataSource = (BLL_Kho.Instance.Search_Bll(kid,textBox_search.Text)).Select(p => new { p.kID, p.HoatDong.hdName, p.SanPham.spName, p.DVT, p.Quantity, p.MFG, p.EXP, p.Date }).ToList();
        }

        private void Button_subQLK_add_Click(object sender, EventArgs e)
        {
            SubFormKho f = new SubFormKho(-1);
            f.D += new SubFormKho.MyDel(ShowDTGV);
            f.ShowDialog();
        }

        private void Button_subQLK_update_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count == 1)
            {
                int KhoID = Convert.ToInt32(r[0].Cells["kID"].Value.ToString());
                SubFormKho f = new SubFormKho(KhoID);
                f.D += new SubFormKho.MyDel(ShowDTGV);
                f.ShowDialog();
            }

            if (r.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 hoạt động để cập nhật. ");
            }
        }

        private void Button_subQLK_delete_Click(object sender, EventArgs e)
        {
            SE_07 db = new SE_07();
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count != 0)
            {
                DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa hoạt động này chứ ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    BLL_Kho.Instance.Del_Bll(r);
                    ShowDTGV();
                }
                if (dr == DialogResult.No) return;
            }
            else MessageBox.Show("Bạn chưa chọn hoạt động nào để xóa !");
        }

        private void Button_subQLK_sort_Click(object sender, EventArgs e)
        {
            SE_07 db = new SE_07();
            List<int> now = new List<int>();
            foreach (DataGridViewRow i in dataGridView1.Rows)
            {
                if (i.Cells["kid"].Value.ToString() != null)
                    now.Add(Convert.ToInt32(i.Cells["kID"].Value.ToString()));
            }
            List<Kho> k = BLL_Kho.Instance.Sort_Bll(now);
            dataGridView1.DataSource = k.Select(p => new { p.kID, p.HoatDong.hdName, p.SanPham.spName, p.DVT, p.Quantity, p.MFG, p.EXP, p.Date }).ToList();

        }
    }
}
