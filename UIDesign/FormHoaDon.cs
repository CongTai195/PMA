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
        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Button_subQLKH_add_Click(object sender, EventArgs e)
        {
            string nameKH = textBox_nameKH.Text;
            int ageKH = Convert.ToInt32(textBox_ageKH.Text);
            string phoneKH = textBox_phoneKH.Text;
            KhachHang kh = new KhachHang
            {
                khName = nameKH,
                Age = ageKH,
                khPhone = phoneKH
            };
            BLL_KhachHang.Instance.BLL_Add(kh);
            textBox_ageKH.Clear();
            textBox_phoneKH.Clear();
            textBox_nameKH.Clear();
        }
    }
}
