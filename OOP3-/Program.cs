using System;
using System.Collections.Generic;

namespace BT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account;
            int chon = 0;
            Bank bank = new Bank();
            do

            {
                Console.WriteLine("{0,15}", "VCB digibank");
                Console.WriteLine("------Menu------");
                Console.WriteLine("1. Them tai khoan");
                Console.WriteLine("2. Xoa tai khoan");
                Console.WriteLine("3. Nap tien");
                Console.WriteLine("4. Rut tien");
                Console.WriteLine("5. Chuyen tien");
                Console.WriteLine("6. Hien Thi Tai Khoan");
                Console.WriteLine("7. Thoat");
                Console.Write("Chon: ");

                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        bank.ThemAccount(account = new Account());
                        break;
                    case 2:
                        bank.XoaAccount();
                        break;
                    case 3:
                        bank.NapTien();
                        break;
                    case 4:
                        bank.RutTien();
                        break;
                    case 5:
                        bank.ChuyenTien();
                        break;
                    case 6:
                        bank.XemDanhSach();
                        break;
                }
            } while (chon != 7);
            Console.ReadLine();

        }

    }
}

