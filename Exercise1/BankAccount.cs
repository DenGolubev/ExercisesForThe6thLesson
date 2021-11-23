using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class BankAccount: BankClient
    {
        public Guid IdAccount { get;}
        public string NameAccount { get;}
        public string CurrencyAccount { get; }
        public double AmmountAccount { get; }
        BankClient client { get; }

        public BankAccount(BankClient client, string name, string currency, uint ammount)
            :base(client.Name)
        {
            this.client = client;
            IdAccount = client.Id;
            NameAccount = name;
            CurrencyAccount = currency;
            AmmountAccount = (double)ammount;
        }

        

        

        public override string ToString()
        {
            return $"{client.Name}\n{IdAccount}\n{NameAccount}\n{CurrencyAccount}\n{AmmountAccount}";
        }
    }
}
