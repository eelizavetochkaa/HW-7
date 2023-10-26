using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_7
{
    public enum AccountType2 
    { 
        tecuchy, 
        sberegatelny 
    }
    internal class account2
    {

        public int balance1;
        public int balance = 120000;
        public account2(int balance1)
        {
            this.balance1 = balance1;

        }


        
        public void Perevesty(account2 a, int summ)
        {
            balance -= summ;
            a.balance += summ;
            Console.WriteLine($"ВЫ успешно перевели {summ} рублей\n Баланс стал= {balance}");
        }

    }
}
