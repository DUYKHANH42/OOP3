using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
   
    
    
        public class Account
        {
            private int stk;
            private string tentk;
            private double sodutk;
            public Account(int stk, string tentk, double sodutk)
            {
                this.stk = stk;
                this.tentk = tentk;
                this.sodutk = sodutk;
            }
            public Account()
            {
                this.stk = 0;
                this.tentk = null;
                this.sodutk = 0;
            }
            public void setstk(int stk)
            {
                this.stk = stk;
            }
            public void settentk(string tentk)
            {
                this.tentk = tentk;
            }
            public void setsodutk(double sodutk)
            {
                this.sodutk = sodutk;
            }


            public int getstk()
            {
                return stk;
            }
            public string gettentk()
            {
                return tentk;
            }
            public double getsodutk()
            {
                return sodutk;
            }
            public void napTien(double tien)
            {

                sodutk += tien;

            }
            public void rutTien(double tien)
            {

                sodutk -= tien;
            }
            public void chuyenTien(Account tkNhan, double tienChuyen)
            {
                tkNhan.napTien(tienChuyen);
            }
        }
    }


