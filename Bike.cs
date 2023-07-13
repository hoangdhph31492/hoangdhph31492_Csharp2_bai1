using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoangdhph31492_Csharp2_bai1
{
    [Serializable]
    internal class Bike
    {
        static int _id=0;
        private int id;
        private string ten;
        private string hSX;
        public Bike()
        {
            _id++;
            id = _id;
        }

        public Bike(int id, string ten, string hSX)
        {
            this.id = id;
            this.ten = ten;
            this.hSX = hSX;
        }

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string HSX { get => hSX; set => hSX = value; }
        public void InTHongTin()
        {
            Console.WriteLine($"{id} | {ten} | {hSX}");
        }
    }
}
