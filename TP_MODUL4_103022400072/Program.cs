using System;
using TP_MODUL4_103022400072;

namespace TP_MODUL4_103022400072
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kdoe pos//
            KodePos kp = new KodePos();

            Console.WriteLine("=== Table Driven: Kode Pos ===");
            Console.WriteLine("Batununggal : " + kp.getKodePos("Batununggal"));
            Console.WriteLine("Kujangsari  : " + kp.getKodePos("Kujangsari"));
            Console.WriteLine("Mengger     : " + kp.getKodePos("Mengger"));
            Console.WriteLine("Wates       : " + kp.getKodePos("Wates"));
            Console.WriteLine("Cijaura     : " + kp.getKodePos("Cijaura"));

            Console.WriteLine();

            //doormachine
            Console.WriteLine("=== State Based Construction: DoorMachine ===");
            DoorMachine door = new DoorMachine();
            door.BukaPintu();
            door.KunciPintu();
            door.BukaPintu();
        }
    }
}