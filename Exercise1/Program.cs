using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientAccount account = new ClientAccount(); 
            account.Add(new BankAccount(new BankClient("Denis"), "Сберегательный", "RUB", 100));
            account.Add(new BankAccount(new BankClient("Denis"), "Сберегательный", "USD", 100));
            account.Add(new BankAccount(new BankClient("Ivan"), "Сберегательный", "RUB", 100));
            account.Add(new BankAccount(new BankClient("Ivan"), "Сберегательный", "USD", 100));
            account.Add(new BankAccount(new BankClient("Olga"), "Сберегательный", "RUB", 100));
            account.Add(new BankAccount(new BankClient("Olga"), "Сберегательный", "USD", 100));

            foreach (var item in ClientAccount.accounts)
            {               
                Console.WriteLine($"{item}");
                Console.WriteLine(item.GetHashCode());
                Console.WriteLine();
            }

            for (int i = 0; i < ClientAccount.accounts.Length; i++)
            {
                var a = ClientAccount.accounts[i];
                for (int y = 0; y < ClientAccount.accounts.Length; y++)
                {
                    var b = ClientAccount.accounts[y];
                    Console.WriteLine($"Аккаунт a - {a.IdAccount} равен Аккаунту b{b.IdAccount}? - {a.Equals(b)}");
                }

            }
                
                        
            Console.ReadKey();
        }
    }
}
