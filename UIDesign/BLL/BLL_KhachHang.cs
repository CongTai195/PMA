using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIDesign.BLL
{
    class BLL_KhachHang
    {
        public delegate bool Compare(object o1, object o2);
        private static BLL_KhachHang _Instance;

        public static BLL_KhachHang Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_KhachHang();
                return _Instance;
            }
            private set => _Instance = value;
        }
        public BLL_KhachHang()
        {

        }
        public void BLL_Add (KhachHang kh)
        {
            SE_07 db = new SE_07();
            try
            {
                db.KhachHangs.Add(kh);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public List<KhachHang> BLL_Search(string search)
        {
            SE_07 db = new SE_07();
            List<KhachHang> kh = new List<KhachHang>();
            try
            {
                {
                    kh = db.KhachHangs.Where(p => p.khName.Contains(search) || p.khPhone.Contains(search)).ToList();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return kh;
        }
        public void BLL_Update(int KHID, string namekh, int age, string phonekh)
        {
            SE_07 db = new SE_07();
            try
            {
                KhachHang kh = db.KhachHangs.Where(p => p.khID == KHID).FirstOrDefault();
                kh.khName = namekh;
                kh.Age = age;
                kh.khPhone = phonekh;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void Del_Bll(DataGridViewSelectedRowCollection r)
        {
            SE_07 db = new SE_07();
            try
            {
                foreach (DataGridViewRow i in r)
                {
                    int khid = Convert.ToInt32(i.Cells["khID"].Value.ToString());
                    db.KhachHangs.RemoveRange(db.KhachHangs.Where(p => p.khID == khid));
                }
                db.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public List<KhachHang> Sort_Bll(List<int> now)
        {
            SE_07 db = new SE_07();
            List<KhachHang> k = new List<KhachHang>();
            try
            {
                foreach (int i in now)
                {
                    foreach (KhachHang j in db.KhachHangs)
                    {
                        if (i == j.khID)
                        {
                            k.Add(j);
                        }
                    }
                }
                Sort(k, KhachHang.Compare_TenKhachHang);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return k;
        }
        public static void Sort(List<KhachHang> a, Compare cmp)
        {
            for (int i = 0; i <= a.Count - 1; i++)
            {
                for (int j = i + 1; j < a.Count; j++)
                {
                    if (cmp(a[i].khName, a[j].khName))
                    {
                        KhachHang t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
                }
            }
        }
    }
}
