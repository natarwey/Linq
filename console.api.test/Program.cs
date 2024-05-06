List<BankAccount> bankAccounts = new List<BankAccount>()
{
    new BankAccount("Ivanov", 10010, new DateTime(2001,12,12), false),
    new BankAccount("Petrov", 15066, new DateTime(1997,06,11), false),
    new BankAccount("Sidorov", 51000, new DateTime(1999,12,04), true),
    new BankAccount("Ivanova", 11012, new DateTime(2000,06,02), false),
    new BankAccount("Garkun", 21005, new DateTime(2003,02,03), false),
    new BankAccount("Yarullin", 10, new DateTime(2003,03,03), true),
    new BankAccount("Yapparov", 31001, new DateTime(2000,05,10), false)
};


// T1: Записать в отдельный список все аккаунты с балансом больше чем 11к
Console.WriteLine("T1");
var t1 = bankAccounts.Where(x => x.Balance > 11000).ToList();
foreach (var t in t1)
    Console.WriteLine($"{t.Name} is Balance = {t.Balance}");


// T2: Отсортировать аккаунты по алфавиту, по балансу от больше к меньшему и наоборот

Console.WriteLine("\n T2");

var temp = bankAccounts.OrderBy(p => p.Name);
Console.WriteLine("По алфавиту:");
foreach (var t in temp)
    Console.WriteLine(t.Name);
Console.WriteLine("\n");
var temp1 = bankAccounts.OrderBy(p => p.Balance);
Console.WriteLine("От большего баланса к меньшему");
foreach (var t in temp1)
    Console.WriteLine($"{t.Name} is Balance = {t.Balance}");
Console.WriteLine("\n");
var temp2 = bankAccounts.OrderByDescending(p => p.Balance);
Console.WriteLine("От меньшего баланса к большему");
foreach (var t in temp2)
    Console.WriteLine($"{t.Name} is Balance = {t.Balance}");


//T3: Вывести все забаненные аккаунты с балансом меньше 10к

Console.WriteLine("\n T3");
var t3 = bankAccounts.Where(x => x.IsBan == true && x.Balance < 10000).ToList();
foreach (var t in t3)
    Console.WriteLine($"{t.Name} is ban {t.IsBan} and Balance = {t.Balance}");


// T4: Вывести все аккаунты пользователи которых родились до 2000 года

Console.WriteLine("\n T4");
var t4 = bankAccounts.Where(x => x.Birthday.Year < 2000).ToList();
foreach (var t in t4)
    Console.WriteLine($"{t.Name} is born = {t.Birthday}");


// T5: Сделать метод  ToCommunism() - который распределит все балансы пользователей поровну между всеми

Console.WriteLine("\n T5");
ToCommunism();
void ToCommunism()
{
    decimal t5 = bankAccounts.Average(x => x.Balance);
    foreach (var t in bankAccounts)
    {
        t.Balance = t5;
        Console.WriteLine($"{t.Name} is Balance = {t.Balance}");
    }
}


// linq
// T1: Записать в отдельный список все аккаунты с балансом больше чем 11к
// T2: Отсортировать аккаунты по алфавиту, по балансу от больше к меньшему и наоборот
// T3: Вывести все забаненные аккаунты с балансом меньше 10к
// T4: Вывести все аккаунты пользователи которых родились до 2000 года
// T5: Сделать метод  ToCommunism() - который распределит все балансы пользователей поровну между всеми

class BankAccount
{
    public BankAccount(string name, decimal balance, DateTime birthday, bool isBan)
    {
        Id = Guid.NewGuid().ToString();
        Name = name;
        Balance = balance;
        Birthday = birthday;
        IsBan = isBan;
    }

    public string Id { get; }
    public string Name { get; set; }
    public decimal Balance { get; set; }
    public DateTime Birthday { get; set; }
    public bool IsBan { get; set; }
}