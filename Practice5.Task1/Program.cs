namespace Practice5.Task1
{
  class Employee
  {
    public string Name { get; set; }
    public double Salary { get; set; }
    public Employee(string name, double salary)
    {
      this.Name = name;
      this.Salary = salary;
    }
    public virtual double CalculateBonus()
    {
      return Math.Round(0.1 * this.Salary, 2);
    }
  }
  class Manager : Employee
  {
    public int TeamSize { get; set; }
    public Manager(string name, double salary, int teamsize) : base(name, salary)
    {
      this.TeamSize = teamsize;
    }
    public override double CalculateBonus()
    {
      if (this.TeamSize > 5)
        return Math.Round(0.2 * this.Salary + 0.05 * this.Salary, 2);
      else
        return Math.Round(0.2 * this.Salary, 2);
    }
  }
  class Contractor : Employee
  {
    public double HourlyRate { get; set; }
    public Contractor(string name, double salary, int hourlyRate) : base(name, salary)
    {
      this.HourlyRate = hourlyRate;
    }
    public new double CalculateBonus(int hoursWorked)
    {
      return Math.Round(0.1 * this.Salary * hoursWorked / 8, 2);
    }
  }
  class Program
  {
    static void Main()
    {
      Employee employee = new Employee("Ivan", 35004.50);
      Manager manager = new Manager("Petr", 52365.45, 6);
      Contractor contractor = new Contractor("Dima", 50000, 6);

      Console.WriteLine($"Name: {employee.Name}   Bonus: {employee.CalculateBonus()}");
      Console.WriteLine($"Name: {manager.Name}   Bonus: {manager.CalculateBonus()}");
      Console.WriteLine($"Name: {contractor.Name}   Bonus: {contractor.CalculateBonus(6)}");

      Console.ReadLine();
    }
  }
}