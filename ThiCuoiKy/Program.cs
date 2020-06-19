using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiCuoiKy
{
    class Program
    {
        static void Main(string[] args)
        {
            //THi CUOI KY MON CAU TRUC DU LIEU VA GIAI THUAT
            //MSSV: 1606020010
            //TEN: Huỳnh Trọng Đại

			ClsMenu menu = new ClsMenu();
			List<ClsSinhVien> listSV = new List<ClsSinhVien>();
			int iLuaChon;
			menu.AddItem("Nhap Sinh Vien");
			menu.AddItem("Sap Xep Heap Sort");
			menu.AddItem("Sap Xep Selection Sort");
			menu.AddItem("Tim Kiem");
			menu.AddItem("Xem Danh Sach");
			menu.AddItem("Thoat");
			
			do{
				iLuaChon = menu.DisplayMenu();
				if(iLuaChon == 0){
					ClsSinhVien sinhVien = new ClsSinhVien();
					sinhVien.NhapThongTin();
					listSV.Add(sinhVien);
				}
				if(iLuaChon == 1){
					ClsSort sort = new ClsSort(listSV);
					listSV = sort.HeapSort(listSV);
					Console.ReadKey(true);
				}
				if(iLuaChon == 2){
					ClsSort sort = new ClsSort(listSV);
					sort.Selection(listSV);
					Console.ReadKey(true);
				}
				if(iLuaChon == 3){
				
				}
				if(iLuaChon == 4){

					Console.WriteLine("-----------------------");
					Console.WriteLine("{0,-10}|{1,-15}|{2,-15}","MSMH","Ten MH","Diem");
					Console.WriteLine("-----------------------");
					foreach(ClsSinhVien sv in listSV){
						Console.WriteLine("{0,-10} {1,-15} {2,-15}",sv.Mssv,sv.Ten,sv.DiemTB);
					}
					Console.ReadKey(true);
				}
				
			}
			while(iLuaChon != 5);
				Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
        }
    }
}
