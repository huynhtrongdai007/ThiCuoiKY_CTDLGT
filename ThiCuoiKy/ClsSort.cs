using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiCuoiKy
{
    class ClsSort
    {
        private List<ClsSinhVien> listSV;
		
		public List<ClsSinhVien> ListSV {
			get { return listSV; }
			set {listSV = value;}
		}


        public ClsSort(List<ClsSinhVien> lSV)
        {
			this.listSV = lSV;
		}
		
		
		public List<ClsSinhVien> HeapSort(List<ClsSinhVien> listSV){
			int n = listSV.Count;
		

			
		    	for (int i = n / 2 - 1; i >= 0; i--)
				{
					CheckAndMakeHeap(listSV,n,i);
				
				}
				// One by one extract an element from heap
				for (int i=n-1; i>0; i--)
				{
					Swap( listSV, 0, i);
					for(int j=i/2-1;j>=0;j--)
					{
						CheckAndMakeHeap(listSV,i,j);
						
					}
					//heapify(arr, i, 0);
				}
                 execute();

				return listSV;
		}
		
		public List<ClsSinhVien> Selection(List<ClsSinhVien> A){
			int iN = A.Count;


			for(int i = 0;i < iN-1; i ++)
			{
				int minIndex = i;
				for(int j=i+1;j <iN; j ++)
				{
					if(A[j].DiemTB < A[i].DiemTB)
					{
						ClsSinhVien t = A[j];
						A[j] = A[i];
						A[i] = t;
						minIndex = j;
						//Console.ReadKey(true);
					}
		
				}
                execute();
				//Console.ReadKey(true);
			}
			return A;
		}
		
		private static void CheckAndMakeHeap(List<ClsSinhVien> A,int iN, int index)
		{
			
			if(index < iN && 2*index+1 < iN)
			{
				if(A[index].DiemTB<A[2*index+1].DiemTB)
				{
					Swap( A,index,2*index+1);
				
				}
			
			}
			if(index < iN && 2*index+2 < iN)
			{
				if(A[index].DiemTB<A[2*index+2].DiemTB)
				{
					Swap( A,index, 2*index+2);
				}
			}
		}
		
		private static void Swap( List<ClsSinhVien> lSV,int iA, int iB)
		{
			ClsSinhVien T = lSV[iA];
			lSV[iA] = lSV[iB];
			lSV[iB] = T;
		}

        void execute()
		{
            Console.Write("Da Thuc hien Sap Xep hay xem trong phan danh sach");
		}
    }
}
