namespace CodingTest19._2._2024
{
    internal class Program
    {
        static void Main()
        {
            Employee employee = new Employee(20.50, "1", "Cashier");
            Console.WriteLine(employee.GetEmployeeNumber());
            employee.SetPay(10, 20);
            employee.SetPay(20, 20);
            Console.WriteLine(employee.GetTotalPay());

            Manager manager = new Manager(10.0, 30, "5", "Manager");
            manager.SetPay(10, 20);
            manager.SetPay(20, 20);
            Console.WriteLine(manager.GetTotalPay());

            Employee[] EmployeeArray = new Employee[8];
            string file = @"Employees.txt";
            using (StreamReader streamReader = new StreamReader(file))
            {
                string ReadData = streamReader.ReadToEnd();
                string[] temp = ReadData.Split("\n");
                List<string> TempList = new List<string>();
                foreach (string item in temp)
                {
                    if (int.TryParse(item, out int n) == false)
                    {
                        if (TempList.Count > 3)
                        {
                            Manager Manager = new Manager(Convert.ToDouble(TempList[2]), Convert.ToDouble(TempList[0]), TempList[1], TempList[3]);
                        }
                    }
                }
            }
        }
    }
}