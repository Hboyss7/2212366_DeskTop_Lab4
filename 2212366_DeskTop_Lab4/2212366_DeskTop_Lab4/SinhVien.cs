using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2212366_DeskTop_Lab4
{
    internal class SinhVien
    {
        public string MaSo { get; set; }

        public string HoTen { get; set; }
       
        public string Email { get; set; }

        public string DiaChi { get; set; }

        public DateTime NgaySinh { get; set; }

        public bool GioiTinh { get; set; }

        public string Lop {  get; set; }

        public string SoDT { get; set; }

        public string Hinh {  get; set; }

        public SinhVien()
        {
                
        }

        public SinhVien(string ms, string ten, string email, string dc,
                        DateTime ns, bool gt, string lop, string sodt, string hinh)
        {
                this.MaSo = ms; 
                this.HoTen = ten;
                this.Email = email;
                this.DiaChi = dc;
                this.NgaySinh = ns;
                this.GioiTinh = gt;
                this.Lop = lop; 
                this.SoDT = sodt;
                this.Hinh = hinh;   
        }

        public override string ToString()
        {
            string s1 = "";
            s1= "MSSV : " + MaSo + "\n" +
                "Họ và tên : " + HoTen + "\n" +
                "Email : " + Email + "\n" +
                "Địa Chỉ : " + DiaChi + "\n" +
                "Ngày Sinh : " + NgaySinh.ToString() + "\n";
            string gt = "Giới Tính : ";
            if (GioiTinh)
            {
                gt += "Nam" + "\n";
            }
            else
            {
                gt += "Nữ" + "\n";
            }
  
            string s2 = "Lop : " + Lop + "\n" +
                        "Số ĐT : " + SoDT + "\n" +
                        "Hình : " + Hinh + "\n";

            return s1 + gt + s2;
        }



    }
}
