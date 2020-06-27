using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIDesign.BLL
{
    class BLL_Login
    {
        private static BLL_Login _Instance;

        public static BLL_Login Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_Login();
                return _Instance;
            }
            private set => _Instance = value;
        }
        public BLL_Login()
        {

        }
        public void LogIn(string user, string password)
        {
            SE_07 db = new SE_07();
            int count = 0;
            foreach (TaiKhoan i in db.TaiKhoans)
            {
                if (user == i.UserName)
                {
                    if (password == i.Pass)
                    {
                        if (i.Type == "admin")
                        {
                            Form2 f = new Form2();
                            f.ShowDialog();
                            
                        }
                        if (i.Type == "nhanvien")
                        {
                            Form3 f = new Form3();
                            f.ShowDialog();
                            
                        }
                    }
                    else
                    {
                        {
                            MessageBox.Show("Mật khẩu bạn đã nhập không chính xác");
                        }
                    }
                }
                else
                {
                    count += 1;
                    if (count == db.TaiKhoans.Count())
                    {
                        MessageBox.Show("Tài khoản " + user + " không tồn tại !");
                    }
                }
            }
        }
    }
}
