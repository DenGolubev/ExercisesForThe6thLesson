using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class BankClient
    {
        public Guid Id { get; }
        public string Name { get; }

        public BankClient(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
        
        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }
}
