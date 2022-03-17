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
