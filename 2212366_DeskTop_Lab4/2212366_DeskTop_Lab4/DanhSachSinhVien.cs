using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2212366_DeskTop_Lab4
{
    internal class DanhSachSinhVien
    {
        public ArrayList dssv;
        public DanhSachSinhVien()
        {
            dssv = new ArrayList();
        }

        public DanhSachSinhVien this[int index]
        {
            set
            {
                //this[index] = value;
                dssv[index] = value;

            }

            get
            {
                return dssv[index] as DanhSachSinhVien;
            }
        }
        public void Them(SinhVien sv)
        {
            dssv.Add(sv);
        }

        public void NhapTuFile()
        {
            string fileName = "";
            string[] tach;
            string chuoi;
            
            FileStream file = new FileStream(fileName, FileMode.Open);
            StreamReader sr = new StreamReader(file);

            //while (sr.ReadLine() != null) 
            //{
            //    tach = sr.ReadLine().Split(';');
            //}
            while ((chuoi = sr.ReadLine())!= null) 
            {
                tach = chuoi.Split(';');
                SinhVien sv = new SinhVien();
                sv.MaSo = tach[0];
                sv.HoTen = tach[1];
                sv.Email = tach[2];
                sv.DiaChi = tach[3];
                sv.NgaySinh = DateTime.Parse(tach[4]);
                sv.GioiTinh = false;
                if (tach[5] == "Nam")
                {
                    sv.GioiTinh = true;
                }
                sv.Lop = tach[6];
                sv.SoDT = tach[7]; 
                sv.Hinh = tach[8];
                Them(sv);                             
            }
        }
        
    }
}
