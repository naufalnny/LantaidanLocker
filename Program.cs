using System;

namespace United_Tractors
{
    class Program
    {
        static void findlantai(int num_lock) 
        {
        int lantai = 1;
        int kap_loker = 5;

        int nomerloker = 5;
        while(nomerloker < num_lock)
        {
            if (num_lock > nomerloker)
            {
                kap_loker = kap_loker+1;
                if (kap_loker == 8)
                {
                    kap_loker = 5;
                }
                lantai = lantai+1;
                nomerloker= nomerloker+kap_loker;
            }
        }
        Console.WriteLine(lantai);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan Nomer Loker :");
            int loker = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lantai  :");
            findlantai(loker);
        }
    }
}
