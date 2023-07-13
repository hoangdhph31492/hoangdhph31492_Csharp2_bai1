using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoangdhph31492_Csharp2_bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            SERVICE service = new SERVICE();
            List<Bike> list = new List<Bike>();
            int chon;
            string path = "bike.bin";
            do
            {
                Console.WriteLine("------------MENU---------");
                Console.WriteLine("1.nhap danh sach doi tuong");
                Console.WriteLine("2.xuat danh sach doi tuong");
                Console.WriteLine("3.Doc - Luu file");
                Console.WriteLine("4.Xoa doi tuong theo ID");
                Console.WriteLine("Moi chon chuc nang: ");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                        case 1:
                            service.NhapDS(list); break;
                        case 2:
                            service.XuatDS(list); break;
                        case 3:
                            service.Doc_luu_file(list,path); break;
                        case 4:
                            service.XoaID(list); break;
                    default:
                        Console.WriteLine("chua co chuc nang nay!!");
                        break;
                }

            } while (true);
        }
    }
}
