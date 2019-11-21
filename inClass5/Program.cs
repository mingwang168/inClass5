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

            BankAccountStruct copyStructAccount = structAccount;
            BankAccountClass copyClassAccount = classAccount;
            structAccount.SHowDetails("Original struct Account");
            copyStructAccount.SHowDetails("Copy struct Account");
            classAccount.SHowDetails("Original class Account");
            copyClassAccount.SHowDetails("Copy class Account");
            Console.WriteLine();
            structAccount.AddMonthlyInsterest();
            classAccount.AddMonthlyInsterest();
            structAccount.SHowDetails("Original struct Account");
            copyStructAccount.SHowDetails("Copy struct Account");
            classAccount.SHowDetails("Original class Account");
            copyClassAccount.SHowDetails("Copy class Account");
            Console.ReadLine();
        }
    }
}
