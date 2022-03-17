using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp4_1302204116
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            String nama;
            Console.WriteLine("Input Nama : ");
            nama = Console.ReadLine();

            HaloGeneric.SapaUser<string>(nama);
        }
    }
    class HaloGeneric
    {
        public static void SapaUser<T>(T nama)
        {
            Console.WriteLine("Halo User " + nama);
            string data;
            Console.WriteLine("Masukan data : ");
            data = Console.ReadLine();

            DataGeneric<string> inidata = new DataGeneric<string>(data);
            inidata.PrintData();
        }
    }
    class DataGeneric<T>
    {
        T data;
        public DataGeneric(T data)
        { 
            this.data = data;   
        }
        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah : " + this.data);
        }   
    }
}
