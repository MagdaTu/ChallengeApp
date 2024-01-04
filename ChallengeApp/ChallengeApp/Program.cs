using ChallengeApp;
Employee employee1 = new Employee("Magda", "Kowalska", 39);
Employee employee2 = new Employee("Olaf", "Nowak", 19);
Employee employee3 = new Employee("Mateusz", "Kowalski", 42);

employee1.AddScore(0);
employee1.AddScore(2);
employee1.AddScore(9);
employee1.AddScore(6);
employee1.AddScore(9);

employee2.AddScore(10);
employee2.AddScore(3);
employee2.AddScore(8);
employee2.AddScore(8);
employee2.AddScore(7);

employee3.AddScore(4);
employee3.AddScore(2);
employee3.AddScore(1);
employee3.AddScore(6);
employee3.AddScore(10);


List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};
int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
        employeeWithMaxResult = employee;
    maxResult = employee.Result;
}
Console.WriteLine("Pracownik z największą liczbą punktów to " + employeeWithMaxResult.Name + "" + " "
    + employeeWithMaxResult.Surname + "" + " "
    + employeeWithMaxResult.Age + "" +"lat"+" "
    + "wynik:" + maxResult);









