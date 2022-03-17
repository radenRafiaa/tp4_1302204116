using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp4_1302204116
{
    public class ClassMain
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
        }
    }
}
