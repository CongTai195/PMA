using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIDesign.BLL
{
    class BLL_Kho
    {
        //public delegate bool Compare(object o1, object o2);
        private static BLL_Kho _Instance;

        public static BLL_Kho Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_Kho();
                return _Instance;
            }
            private set => _Instance = value;
        }
        public BLL_Kho()
        {

        }
        public List<Kho> Search_Bll(int hdid, string search)
        {
            SE_07 db = new SE_07();
            List<Kho> k = new List<Kho>();
            try
            {
                if (hdid == 0)
                {
                    k = db.Khoes.Where(p => p.SanPham.spName.Contains(search)).ToList();
                }
                else
                {
                    k = db.Khoes.Where(p => p.hdID == hdid).Where(p => p.SanPham.spName.Contains(search)).ToList();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return k;
        }
        public void Add_Bll(Kho k)
        {
            SE_07 db = new SE_07();
            try
            {
                db.Khoes.Add(k);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Update_Bll(int KhoID, int spID, int hdID, string dvt, int soluong, DateTime nsx, DateTime hsd, DateTime date)
        {
            SE_07 db = new SE_07();
            try
            {
                Kho s = db.Khoes.Where(p => p.kID == KhoID).FirstOrDefault();
                s.spID = spID;
                s.hdID = hdID;
                s.DVT = dvt;
                s.Quantity = soluong;
                s.MFG = nsx;
                s.EXP = hsd;
                s.Date = date;
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
                    int khoid = Convert.ToInt32(i.Cells["kID"].Value.ToString());
                    db.Khoes.RemoveRange(db.Khoes.Where(p => p.kID == khoid));
                }
                db.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public List<Kho> Sort_Bll(List<int> now)
        {
            SE_07 db = new SE_07();
            List<Kho> k = new List<Kho>();
            try
            {
                foreach (int i in now)
                {
                    foreach (Kho j in db.Khoes)
                    {
                        if (i == j.kID)
                        {
                            k.Add(j);
                        }
                    }
                }
                //Sort(k, Kho.Compare_TenSanPham);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return k;
        }
        //public static void Sort(List<Kho> a, Compare cmp)
        //{
        //    for (int i = 0; i <= a.Count - 1; i++)
        //    {
        //        for (int j = i + 1; j < a.Count; j++)
        //        {
        //            if (cmp(a[i].SanPham.spName, a[j].SanPham.spName))
        //            {
        //                Kho t = a[i];
        //                a[i] = a[j];
        //                a[j] = t;
        //            }
        //        }
        //    }
        //}
    }
}
