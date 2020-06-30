using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIDesign.BLL
{
    class BLL_NhanVien
    {
        //public delegate bool Compare(object o1, object o2);
        private static BLL_NhanVien _Instance;

        public static BLL_NhanVien Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_NhanVien();
                return _Instance;
            }
            private set => _Instance = value;
        }
        public BLL_NhanVien()
        {

        }
        public List<NhanVien> Search_Bll(string search)
        {
            SE_07 db = new SE_07();
            List<NhanVien> nv = new List<NhanVien>();
            try
            {
                {
                    nv = db.NhanViens.Where(p => p.nvName.Contains(search)||p.nvIDNumber.Contains(search)).ToList();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return nv;
        }
        public void Add_Bll(NhanVien nv)
        {
            try
            {
                SE_07 db = new SE_07();
                db.NhanViens.Add(nv);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void AddTaiKhoan_Bll(TaiKhoan tk)
        {
            try
            {
                SE_07 db = new SE_07();
                db.TaiKhoans.Add(tk);
                db.SaveChanges();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Update_Bll(int NvID, string namenv, DateTime dob, string cmnd, string sdt, string diachi, string luong)
        {
            SE_07 db = new SE_07();
            try
            {
                NhanVien s = db.NhanViens.Where(p => p.nvID == NvID).FirstOrDefault();
                s.nvName = namenv;
                s.nvDOB = dob;
                s.nvIDNumber = cmnd;
                s.nvPhone = sdt;
                s.nvAddress = diachi;
                s.Salary = luong;
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
                    int nvid = Convert.ToInt32(i.Cells["nvID"].Value.ToString());
                    db.NhanViens.RemoveRange(db.NhanViens.Where(p => p.nvID == nvid));
                }
                db.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public List<NhanVien> Sort_Bll(List<int> now)
        {
            SE_07 db = new SE_07();
            List<NhanVien> nv = new List<NhanVien>();
            try
            {
                foreach (int i in now)
                {
                    foreach (NhanVien j in db.NhanViens)
                    {
                        if (i == j.nvID)
                        {
                            nv.Add(j);
                        }
                    }
                }
                //Sort(nv, NhanVien.Compare_TenNhanVien);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return nv;
        }
        //public static void Sort(List<NhanVien> a, Compare cmp)
        //{
        //    for (int i = 0; i <= a.Count - 1; i++)
        //    {
        //        for (int j = i + 1; j < a.Count; j++)
        //        {
        //            if (cmp(a[i].nvName, a[j].nvName))
        //            {
        //                NhanVien t = a[i];
        //                a[i] = a[j];
        //                a[j] = t;
        //            }
        //        }
        //    }
        //}
    }
}
