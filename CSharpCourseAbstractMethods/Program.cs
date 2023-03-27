using CSharpCourseAbstractMethods.Entities;

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

List<TaxPayer> taxPayers = new List<TaxPayer>();

for (int i = 0; i < n; i++) {
    Console.WriteLine($"Tax payer #{i+1} data:");
    Console.Write("Individual or company (i/c)? ");
    string type = Console.ReadLine();
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Anual income: ");
    double yearlyIncome = double.Parse(Console.ReadLine());

    switch (type) {
        case "i":
            Console.Write("Health expenditures: ");
            double health = double.Parse(Console.ReadLine());
            taxPayers.Add(new Person(name, yearlyIncome, health));
            break;
        case "c":
            Console.Write("Number of employees: ");
            int num = int.Parse(Console.ReadLine());
            taxPayers.Add(new Company(name, yearlyIncome, num));
            break;
        default:
            Console.WriteLine($"Letter {type} is not valid!");
            break;
    }
}

Console.WriteLine("TAXES PAID: ");

foreach (TaxPayer payer in taxPayers) {
    Console.WriteLine($"{payer.Name}: $ {payer.taxCalc()}");
}

double total = taxPayers.Sum(obj => obj.taxCalc());
Console.WriteLine($"TOTAL TAXES: $ {total}");