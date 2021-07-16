using System;
using System.Collections;
using System.Collections.Specialized;

namespace BT2_13072021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StringDictionary dsBKS = new StringDictionary();
            dsBKS.Add("12365", "Ware Alpha");
            dsBKS.Add("45983", "Exciter");
            dsBKS.Add("45632", "Winner");
            foreach (DictionaryEntry d in dsBKS)
            {
                Console.WriteLine("BKS: {0} ==> Thong tin: {1}", d.Key, d.Value);
            }
            int chon;
            Console.WriteLine("Moi nhap lua chon: ");
            Console.WriteLine("Nhap 0 => Thoat");
            Console.WriteLine("Nhap 1 => Nhap xe moi");
            Console.WriteLine("Nhap 2 => Xoa xe theo bien so");
            Console.WriteLine("Nhap 3 => Tim kiem va in ra xe theo bien so");
            chon = int.Parse(Console.ReadLine());
            switch (chon)
            {
                case 0: break;
                case 1:
                    {
                        int bks;
                        string ttXe;
                        Console.WriteLine("Nhap bien so xe can them: ");
                        bks = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap thong tin xe can them: ");
                        ttXe = Console.ReadLine();
                        dsBKS.Add(bks.ToString(), ttXe);
                    }
                    break;
                case 2:
                    {
                        int bks;
                        Console.WriteLine("Nhap bien so xe can xoa: ");
                        bks = int.Parse(Console.ReadLine());
                        dsBKS.Remove(bks.ToString());
                    }
                    break;
                case 3:
                    {
                        int bks;
                        Console.WriteLine("Nhap thong tin bien so xe can tim: ");
                        bks = int.Parse(Console.ReadLine());
                        Console.WriteLine("Xe can tim: " + dsBKS[bks.ToString()]);
                    }
                    break;
            }
            //foreach (DictionaryEntry d in dsBKS)
            //{
            //    Console.WriteLine("BKS: {0} ==> Thong tin: {1}", d.Key, d.Value);
            //}
        }
    }
}
