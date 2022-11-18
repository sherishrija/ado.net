using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace ADO.NET
{
    class insert
    {
       public static void Main()
        { 
           SqlConnection sqlConnection;
            string connectionString = @"Data Source=ShrijaVM;Initial Catalog=Employee;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            Console.WriteLine("Please Enter Employee Id : ");
            int EmpId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease Enter Employee First Name : ");
            String EmpFName = Console.ReadLine();

            Console.WriteLine("\nPlease Enter Employee Last Name  : ");
            String EmpLname = Console.ReadLine();

            Console.WriteLine("\nPlease Enter Employee Salary : ");
            int EmpSalary = Convert.ToInt32(Console.ReadLine());


            string insertQuery = "insert into Employee_tb1(EmpID, Firstname, Lastname , Salary) Values('" + EmpId + "','" + EmpFName + "','" + EmpLname + "','" + EmpSalary + "')";
            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
            insertCommand.ExecuteNonQuery();
            Console.WriteLine("Data Inserted");
            sqlConnection.Close();
        }
    }
}

        