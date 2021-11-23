using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class ClientAccount
    {
        public static BankAccount[] accounts = new BankAccount[0];
        public int Counter => ArrayCounter(accounts);
        public void Add(BankAccount account)
        {
            Array.Resize(ref accounts, Counter +1);
            accounts[Counter] = account;
        }
        public int ArrayCounter(BankAccount[] accounts)
        {
            int counter = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] != null)
                {
                    counter++;
                }
            }
            return counter;
        }
               
        public override bool Equals(object obj)
        {
           if(obj.GetHashCode() == this.GetHashCode())return true;
           else return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
