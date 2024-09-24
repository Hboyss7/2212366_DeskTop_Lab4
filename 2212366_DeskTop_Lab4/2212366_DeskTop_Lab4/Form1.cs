using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212366_DeskTop_Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }   
        private void Form1_Load(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien("55","4545","445","45", new DateTime(2004,05,15),true, "54","56","45");
           
            label10.Text = sv.ToString();   
        }

        public SinhVien GetControl()
        {
            SinhVien sv = new SinhVien();
            sv.MaSo = mtxtMSSV.Text;
            sv.HoTen = txtHoTen.Text;
            sv.Email = txtEmail.Text;
            sv.DiaChi = txtDiaChi.Text;
            sv.NgaySinh = dtpNgaySinh.Value;
            sv.GioiTinh = false; 
            if (rdNam.Checked)
            {
               sv.GioiTinh = true;
            }
            sv.Lop = cboLop.Text;
            sv.SoDT = mtxtSDT.Text;
            sv.Hinh = txtHinh.Text;

            return sv;

        }
    }
}
