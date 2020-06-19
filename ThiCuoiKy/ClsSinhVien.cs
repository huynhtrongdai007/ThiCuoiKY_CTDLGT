using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiCuoiKy
{
    class ClsSinhVien
    {
        private string mssv, ten;
		private double diemTB;
		
		public ClsSinhVien()
		{
		}
		
		public ClsSinhVien(string sMSSV, string sTen, int DiemTB){
			mssv = sMSSV;
			ten = sTen;
			diemTB = DiemTB;
		}

        public ClsSinhVien(ClsSinhVien sinhVien)
        {
			mssv = sinhVien.Mssv;
			ten = sinhVien.Ten;
			diemTB = sinhVien.DiemTB;
		}
		
		public void NhapThongTin(){
			Console.Write("MSSV: ");
			mssv = Console.ReadLine();
			Console.Write("Ten Sinh Vien: ");
			ten = Console.ReadLine();
			Console.Write("Diem TB:");
			diemTB = double.Parse(Console.ReadLine());
		}
		
		public string Ten {
			get { return ten; }
			set {this.ten = value;}
		}
		
		public string Mssv {
			get { return mssv; }
			set {this.ten = value;}
		}
		
		public double DiemTB {
			get { return diemTB; }
			set { this.diemTB = value;}
		}


    }
}
