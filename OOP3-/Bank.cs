using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    public class Bank
    {

        private List<Account> listAccounts = new List<Account>
        {
            new Account(1, "Nguyen Van A", 1000000),
            new Account(2, "Nguyen Van B", 2000000),
            new Account(3, "Nguyen Van C", 3000000),
        };//Danh sach cac tai khoan co san - test
        public Bank()
        {
            List<Account> listAcc = listAccounts;
        }

        public void ThemAccount(Account account)
        {
            // Kiểm tra xem tài khoản đã tồn tại trong danh sách chưa
            account = new Account();
            Console.WriteLine("Nhap so tai khoan: ");
            account.setstk(int.Parse(Console.ReadLine()));
            Console.WriteLine("Nhap ten tai khoan: ");
            account.settentk(Console.ReadLine());
            Console.WriteLine("Nhap so du: ");
            account.setsodutk(double.Parse(Console.ReadLine()));
            bool dem = false;
            for (int i = 0; i < listAccounts.Count; i++)
            {
                if (listAccounts[i].getstk() == account.getstk())
                {
                    Console.WriteLine("Tai khoan da ton tai");
                    dem = true;
                    return;
                }
            }
            if (dem == false)
            {
                listAccounts.Add(account);
                Console.WriteLine("tao tk thanh cong");
            }
        }
        public void XoaAccount()
        {
            Console.WriteLine("Nhap so tai  khoan can xoa: ");
            int stkXoa = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten tai khoan can xoa: ");
            string tenTKXoa = Console.ReadLine();
            // Kiểm tra xem tài khoản đã tồn tại trong danh sách chưa
            int dem = 0;
            for (int i = 0; i < listAccounts.Count; i++)
            {
                if (listAccounts[i].getstk() == stkXoa)
                {
                    listAccounts.Remove(listAccounts[i]);
                    dem++;
                }
            }
            if (dem > 0)
            {
                Console.WriteLine("xoa thanh cong");
            }
            else
            {
                Console.WriteLine("lam gi co ma xoa");
            }
        }
        public void NapTien()
        {
            Console.WriteLine("Dang Nhap Tai Khoan");
            Console.WriteLine("Nhap so tai khoan: ");
            int stkNap = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so tien muon nap:");
            double tienNap = double.Parse(Console.ReadLine());
            bool dem = false;
            for (int i = 0; i < listAccounts.Count; i++)
            {
                if (listAccounts[i].getstk() == stkNap)
                {
                    listAccounts[i].napTien(tienNap);
                    dem = true;
                }
            }
            if (dem)
            {
                Console.WriteLine("nap thanh cong so tien: " + tienNap + " vnd");

            }
        }
        public void RutTien()
        {
            Console.WriteLine("Dang Nhap Tai Khoan");
            Console.WriteLine("Nhap so tai khoan: ");
            int stkRut = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so tien muon rut:");
            double tienRut = double.Parse(Console.ReadLine());
            bool dem = false;
            for (int i = 0; i < listAccounts.Count; i++)
            {
                if (listAccounts[i].getstk() == stkRut)
                {
                    listAccounts[i].rutTien(tienRut);
                    dem = true;
                }
            }
            if (dem)
            {
                Console.WriteLine("rut thanh cong so tien: " + tienRut + " vnd");
            }
        }
        public void ChuyenTien()
        {
            Console.WriteLine("Dang Nhap Tai Khoan");
            Console.WriteLine("Nhap so tai khoan: ");
            int stkchuyen = int.Parse(Console.ReadLine());

            int testTKChuyen = 0;
            int testTKNhan = 0;

            for (int i = 0; i < listAccounts.Count; i++)
            {
                if (listAccounts[i].getstk() == stkchuyen)//duyet tim stk chuyen
                {
                    testTKChuyen++;//xac nhan tk chuyen co ton tai
                    Console.WriteLine("Nhap so tai khoan nhan: ");
                    int stkNhan = int.Parse(Console.ReadLine());
                    for (int j = 0; j < listAccounts.Count; j++)
                    {
                        if (listAccounts[j].getstk() == stkNhan)//duyet tim stk nhan
                        {
                            Console.WriteLine("Nhap so tien muon chuyen");
                            double tienChuyen = double.Parse(Console.ReadLine());
                            testTKNhan++;
                            listAccounts[i].chuyenTien(listAccounts[j], tienChuyen);
                            listAccounts[i].rutTien(tienChuyen);//tai su dung ham rut tien de chuyen tien :))
                            Console.WriteLine("chuyen tien thanh cong so tien: " + tienChuyen
                                + " tu tai khoan: " + listAccounts[i].gettentk()
                                + " den tai khoan: " + listAccounts[j].gettentk());
                            return;
                        }
                    }
                    if (testTKNhan == 0)
                    {
                        Console.WriteLine("Tai khoan nhan khong ton tai");
                        return;
                    }
                }
            }
            if (testTKChuyen == 0)
            {
                Console.WriteLine("Tai khoan dang nhap khong ton tai");
            }
        }
        public void XemDanhSach()
        {
            Console.WriteLine("Danh sach tai khoan:");
            Console.WriteLine("{0,-15} {1,-15} {2,-15}",
                "So tai khoan", "Ten tai khoan", "So du");
            foreach (Account account in listAccounts)
            {
                Console.WriteLine("{0,-15} {1,-15} {2,-15}",
                account.getstk(), account.gettentk(), account.getsodutk());
            }
        }
    }
}


