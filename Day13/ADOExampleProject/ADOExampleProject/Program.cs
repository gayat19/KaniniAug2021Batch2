using System;
using System.Data;
using System.Data.SqlClient;

namespace ADOExampleProject
{
    class Program
    {
        SqlConnection conn;
        public Program()
        {
            conn = new SqlConnection(@"Data source=DESKTOP-1C1EU5R\SQLSERVER2019G3;user id=sa;password=P@ssw0rd;Initial catalog=dbCompany06Sep21");
            //conn.Open();
            //Console.WriteLine("Connection opened");
        }

        void GetEmployeeDataFromDatabase()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Employees";
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Employee ID "+dr[0]);
                Console.WriteLine("Employee Name " + dr[1]);
                Console.WriteLine("Employee Age " + dr[2]);
                Console.WriteLine("---------------------------------");
            }
            conn.Close();
        }
        void GetEmployeeDataFromDatabaseDisCon()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Employees";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);//Connect-Fetchdata-put in dataset-disconnect
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Console.WriteLine("Employee ID " + dr[0]);
                Console.WriteLine("Employee Name " + dr[1]);
                Console.WriteLine("Employee Age " + dr[2]);
                Console.WriteLine("---------------------------------");
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.InsertEmployee();
            program.GetEmployeeDataFromDatabaseDisCon();
            Console.ReadKey();
        }

        private void InsertEmployee()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Employees(name,age) values(@ename,@eage)";
            Console.WriteLine("Please enter the employee name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter the employee age");
            int age  = Convert.ToInt32(Console.ReadLine());
            cmd.Parameters.AddWithValue("@ename", name);
            cmd.Parameters.AddWithValue("@eage", age);
            conn.Open();
            int result = cmd.ExecuteNonQuery();//DML queries
            if(result>0)
                Console.WriteLine("Employee added");
            else
                Console.WriteLine("Employee not added");
            conn.Close();
        }
    }
}
