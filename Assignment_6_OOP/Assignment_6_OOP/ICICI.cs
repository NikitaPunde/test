﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6_OOP
{
    
 class ICICI : Account
    {
        public ICICI(double an, string cname, double bal) : base(an, cname, bal)
        { }
        public bool UnderBalance(double amount)
        {
            return false;
        }
        public bool ZeroBalance(double amount)
        {
            if (account_balance <= 0 || account_balance - amount <= 0)
            {
                Console.WriteLine("Transaction cannot be continued as balance is insufficient/zero in Account");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
