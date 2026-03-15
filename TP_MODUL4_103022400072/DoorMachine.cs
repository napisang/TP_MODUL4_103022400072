using System;

namespace TP_MODUL4_103022400072
{
    internal class DoorMachine
    {
        private string state;

        public DoorMachine()
        {
            state = "Terkunci";
            Console.WriteLine("Pintu terkunci");
        }

        public void BukaPintu()
        {
            if (state == "Terkunci")
            {
                state = "Terbuka";
                Console.WriteLine("Pintu tidak terkunci");
            }
        }

        public void KunciPintu()
        {
            if (state == "Terbuka")
            {
                state = "Terkunci";
                Console.WriteLine("Pintu terkunci");
            }
        }
    }
}