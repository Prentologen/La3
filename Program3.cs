using System;

class Employee
{
    private string lastName;
    private string firstName;
    private string position;
    private int experience;

    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    public void SetPositionAndExperience(string position, int experience)
    {
        this.position = position;
        this.experience = experience;
    }

    public double CalculateSalary()
    {
        double baseSalary = 1234; 

        switch (position.ToLower())
        {
            case "Адміністратор":
                baseSalary += 1100;
                break;
            case "Директор":
                baseSalary += 1600;
                break;
            case "Продавець":
                baseSalary += 1300;
                break;
            default:
                Console.WriteLine("Unknown Position");
                break;
        }

        if (experience >= 5)
        {
            baseSalary += 500;
        }

        return baseSalary;
    }

    public double CalculateTax()
    {
        double salary = CalculateSalary();
        double taxRate = 0.18; 
        double tax = salary * taxRate;
        return tax;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Прiзвище: {lastName}");

        Console.WriteLine($"Iм'я: {firstName}");

        Console.WriteLine($"Посада: {position}");

        Console.WriteLine($"Оклад: {CalculateSalary()} грн");

        Console.WriteLine($"Податковий збiр: {CalculateTax()} грн");

    }
}

class Program
{
    static void Main()
    {
        Employee employee = new Employee("Бабак", "Данил");

        employee.SetPositionAndExperience("Директор", 4);

        employee.DisplayInfo();
    }
}