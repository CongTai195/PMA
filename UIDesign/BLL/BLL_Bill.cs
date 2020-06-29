using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIDesign.BLL
{
    class BLL_Bill
    {
        private static BLL_Bill _Instance;

        public static BLL_Bill Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_Bill();
                return _Instance;
            }
            private set => _Instance = value;
        }
        public BLL_Bill()
        {

        }
        public List<Bill> BLL_Search(DateTime batdau, DateTime ketthuc)
        {
            SE_07 db = new SE_07();
            List<Bill> b = new List<Bill>();
            try
            {
                {
                    b = db.Bills.Where(p => p.Date <= ketthuc && p.Date >= batdau).ToList();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return b;
        }
        public List<Bill> Sort_Bll(List<int> now)
        {
            SE_07 db = new SE_07();
            List<Bill> b = new List<Bill>();
            try
            {
                foreach (int i in now)
                {
                    foreach (Bill j in db.Bills)
                    {
                        if (i == j.bID)
                        {
                            b.Add(j);
                        }
                    }
                }
                //Sort(k, KhachHang.Compare_TenKhachHang);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return b;
        }
    }
}
