using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIDesign.BLL
{
    class BLL_SanPham
    {
        //public delegate bool Compare(object o1, object o2);
        private static BLL_SanPham _Instance;

        public static BLL_SanPham Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_SanPham();
                return _Instance;
            }
            private set => _Instance = value;
        }
        public BLL_SanPham()
        {

        }
        public List<SanPham> Search_Bll(int lid, string search)
        {
            SE_07 db = new SE_07();
            List<SanPham> sp = new List<SanPham>();
            try
            {
                if (lid == 0)
                {
                    sp = db.SanPhams.Where(p => p.spName.Contains(search)).ToList();
                }
                else
                {
                    sp = db.SanPhams.Where(p => p.lID == lid).Where(p => p.spName.Contains(search)).ToList();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return sp;
        }
        public void Add_Bll(SanPham sp)
        {
            try
            {
                SE_07 db = new SE_07();
                db.SanPhams.Add(sp);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void Update_Bll(int SPID, string spname, int lID, string unit, string price)
        {
            SE_07 db = new SE_07();
            try
            {
                SanPham s = db.SanPhams.Where(p => p.spID == SPID).FirstOrDefault();
                s.spName = spname;
                s.lID = lID;
                s.Unit = unit;
                s.Price = price;
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
                    int spid = Convert.ToInt32(i.Cells["spID"].Value.ToString());
                    db.SanPhams.RemoveRange(db.SanPhams.Where(p => p.spID == spid));
                }
                db.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public List<SanPham> Sort_Bll(List<int> now)
        {
            SE_07 db = new SE_07();
            List<SanPham> sp = new List<SanPham>();
            try
            {
                foreach (int i in now)
                {
                    foreach (SanPham j in db.SanPhams)
                    {
                        if (i == j.spID)
                        {
                            sp.Add(j);
                        }
                    }
                }
                //Sort(sp, SanPham.Compare_TenSanPham);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return sp;
        }
        //public static void Sort(List<SanPham> a, Compare cmp)
        //{
        //    for (int i = 0; i <= a.Count - 1; i++)
        //    {
        //        for (int j = i + 1; j < a.Count; j++)
        //        {
        //            if (cmp(a[i].spName, a[j].spName))
        //            {
        //                SanPham t = a[i];
        //                a[i] = a[j];
        //                a[j] = t;
        //            }
        //        }
        //    }
        //}
    }
}
