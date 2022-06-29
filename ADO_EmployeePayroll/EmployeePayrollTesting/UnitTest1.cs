
using ADO_EmployeePayroll;

namespace EmployeePayrollTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMultipleEmployeeDetails_ShouldReturnTotalExecutionTime()
        {
            List<ModelClass> list = new List<ModelClass>();
            list.Add(new ModelClass(id: 10, name: "leenu", basic_pay: 20000, start: new DateTime(2022, 06, 01), gender: "F", phone_no: 9877065432, address: "Nagpur", department: "Developer", deductions: 200, taxablePay: 500, netPay: 19500));
            list.Add(new ModelClass(id: 10, name: "Soniya", basic_pay: 30000, start: new DateTime(2022, 05, 01), gender: "F", phone_no: 7123456098, address: "Pune", department: "Developer", deductions: 200, taxablePay: 500, netPay: 19500));
            list.Add(new ModelClass(id: 10, name: "hirkani", basic_pay: 40000, start: new DateTime(2022, 04, 01), gender: "F", phone_no: 6543210987, address: "Mumbai", department: "Developer", deductions: 200, taxablePay: 500, netPay: 19500));
            list.Add(new ModelClass(id: 10, name: "Gaurav", basic_pay: 50000, start: new DateTime(2022, 03, 01), gender: "M", phone_no: 7564321098, address: "Sarni", department: "Developer", deductions: 200, taxablePay: 500, netPay: 19500));
            list.Add(new ModelClass(id: 10, name: "Kunal", basic_pay: 50000, start: new DateTime(2022, 02, 01), gender: "M", phone_no: 8970645321, address: "Bhopal", department: "Developer", deductions: 200, taxablePay: 500, netPay: 19500));
            DateTime startTime = DateTime.Now;
            select.AddEmployeesWithThreading(list);
            DateTime endTime = DateTime.Now;
            Console.WriteLine("Time Taken: " + (endTime - startTime));

            Console.WriteLine("Time Taken without Threading: " + (endTime - startTime));

            DateTime startTimewithThreading = DateTime.Now;
            select.AddEmployeesWithThreading(list);
            DateTime endTimeWithThreading = DateTime.Now;
            Console.WriteLine("Time Taken with Threading: " + (endTimeWithThreading - startTimewithThreading));


        }
    }
}