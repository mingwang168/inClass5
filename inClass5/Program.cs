using System;

namespace inClass5
{
    struct BankAccountStruct
    {
        public string Name { get; set; }
        public float Balance { get; set; }
        public BankAccountStruct(string name,float balance)
        {
            Name = name;
            Balance = balance;
        }
        public void AddMonthlyInsterest()
        {
            Balance *= (1f+0.56f/12f);
        }
        public void SHowDetails(string title)
        {
            Console.WriteLine($"Title: {title}\n Name: {Name}: Balance: {Balance}");
        }
    }

    class BankAccountClass
    {
        public string Name { get; set; }
        public float Balance { get; set; }
        public BankAccountClass(string name, float balance)
        {
            Name = name;
            Balance = balance;
        }
        public void AddMonthlyInsterest()
        {
            Balance *= (1f + 0.56f / 12f);
        }
        public void SHowDetails(string title)
        {
            Console.WriteLine($"Title: {title}\n Name: {Name}: Balance: {Balance.ToString("C")}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            const string NAME = "Object Name";
            const float BALANCE = 593473.039f;
            BankAccountStruct structAccount = new BankAccountStruct(NAME, BALANCE);
            BankAccountClass classAccount = new BankAccountClass(NAME, BALANCE);
            structAccount.SHowDetails("Original struct Account");
            classAccount.SHowDetails("Original class Account");
            structAccount.AddMonthlyInsterest();
            classAccount.AddMonthlyInsterest();
            structAccount.SHowDetails("Original struct Account");
            classAccount.SHowDetails("Original class Account");
            Console.ReadLine();
        }
    }
}
