
using ADO_EmployeePayroll;

EmployeePayroll select = new EmployeePayroll();
ModelClass modelClass = new ModelClass();

Console.WriteLine("1 - Establish Connectivity");
Console.WriteLine("2 - Retrieve or Add Data to DataBase");
Console.WriteLine("3 - Retrieve or Add Data to DataBase");
Console.WriteLine("4 - Update Salary performed");
Console.WriteLine("5 - AddEmployeesWithThreading(list)");
Console.WriteLine(" - Enter a Number");



int option = Convert.ToInt32(Console.ReadLine());
switch (option)
{
    case 1:
        select.DatabseConnection();
        break;
    case 2:
        select.GetAllEmployees();
        break;
    case 3:
        modelClass.name = "Leenu";
        modelClass.basic_pay = 850000;
        modelClass.start = DateTime.Now;
        modelClass.gender = "M";
        select.AddEmployee(modelClass);

        break;
    case 4:
        select.UpdateValue();
        break;
    case 5:
        {
            List<ModelClass> list = new List<ModelClass>();
            list.Add(new ModelClass(id: 10, name: "leenu", basic_pay: 20000, start: new DateTime(2022, 06, 01), gender: "F", phone_no: 9877065432, address: "Nagpur", department: "Developer",  deductions: 200, taxablePay: 500, netPay: 19500));
            list.Add(new ModelClass(id: 10, name: "Soniya", basic_pay: 30000, start: new DateTime(2022, 05, 01), gender: "F", phone_no: 7123456098, address: "Pune", department: "Developer",  deductions: 200, taxablePay: 500, netPay: 19500));
            list.Add(new ModelClass(id: 10, name: "hirkani", basic_pay: 40000, start: new DateTime(2022, 04, 01), gender: "F", phone_no: 6543210987, address: "Mumbai", department: "Developer",  deductions: 200, taxablePay: 500, netPay: 19500));
            list.Add(new ModelClass(id: 10, name: "Gaurav", basic_pay: 50000, start: new DateTime(2022, 03, 01), gender: "M", phone_no: 7564321098, address: "Sarni", department: "Developer",  deductions: 200, taxablePay: 500, netPay: 19500));
            list.Add(new ModelClass(id: 10, name: "Kunal", basic_pay: 50000, start: new DateTime(2022, 02, 01), gender: "M", phone_no: 8970645321, address: "Bhopal", department: "Developer",  deductions: 200, taxablePay: 500, netPay: 19500));
            select.AddEmployeesWithThreading(list);
            break;
        }
    default:
        {
            Console.WriteLine("Enter a valid Number");
            break;
        }



}