    using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace hoangdhph31492_Csharp2_bai1
{
    internal class SERVICE
    {
        public void NhapDS(List<Bike> bikes)
        {
            string tt;
            do
            {
            Bike b = new Bike();
            Console.WriteLine("Ten cua xe dap: ");
            b.Ten = Console.ReadLine();
            Console.WriteLine("Hang san xuat: ");
            b.HSX = Console.ReadLine();
            bikes.Add(b);
                Console.WriteLine("co muon tiep tuc ko(co/ko)?");
                tt = Console.ReadLine();
            } while (tt.Equals("co"));
        }
        public void XuatDS(List<Bike> bikes)
        {
            if (bikes.Count == 0)
            {
                Console.WriteLine("Danh sach trong!!!");
                return;
            }
            foreach (var item in bikes)
            {
                item.InTHongTin();
            }
        }
        BinaryFormatter bf = new BinaryFormatter();
        FileStream fs;
        public List<Bike> Doc_luu_file(List<Bike> bikes,string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("cuong link chua co file!!");
                fs = new FileStream(path, FileMode.Create);
                return null;
            }
            else
            {
                fs = new FileStream(path,FileMode.Open);
                bf.Serialize(fs, bikes);
                Console.WriteLine("Ghi file thanh cong!!");
                List<Bike> bik = new List<Bike>();
                bik = (List<Bike>)bf.Deserialize(fs);
                return bik;
            }
        }
        public void XoaID(List<Bike> bikes)
        {
            Console.WriteLine("Nhap ID can xoa: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Bike bi = bikes.FirstOrDefault(x => x.Id == input);
            if (bi != null)
            {
                bikes.Remove(bi);
                Console.WriteLine("Xoa thanh cong!!");
            }
            else
            {
                Console.WriteLine("Khong ton tai id nay!!");
                return;
            }
        }
    }
}
