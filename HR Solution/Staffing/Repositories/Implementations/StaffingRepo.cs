using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Staffing.Entities;
using Staffing.Repositories.Interfaces;
using MySql.Data.MySqlClient;

namespace Staffing.Repositories.Implementations
{
    public class StaffingRepo : IStaffingRepo
    {
        string connectionString = "server=localhost;port=3306;database=hra;user=root;password=password";

        public List<Employee> GetAll()
        {
            List<Employee> employees = new List<Employee>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM EMPLOYEE", connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Employee employee = new Employee
                    {
                        Id = reader.GetInt32("Id"),
                        Name = reader.GetString("Name"),
                        Position = reader.GetString("Position")
                    };

                    employees.Add(employee);

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error occured : {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return employees;
        }

        public Employee GetById(int id)
        {
            Employee employee = new Employee();

            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM EMPLOYEE WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    employee = new Employee
                    {
                        Id = reader.GetInt32("Id"),
                        Name = reader.GetString("Name"),
                        Position = reader.GetString("Position")
                    };

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred : {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return employee;
        }

       

        public bool AddEmployee(Employee employee)
        {
            bool status = false;

            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "INSERT INTO Employee(Name,Position) values (@Name,@Position)";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@Name", employee.Name);
                command.Parameters.AddWithValue("@Position", employee.Position);
                command.ExecuteNonQuery();
                status = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return status;
        }

        public bool UpdateEmployee(Employee employee)
        {
            bool status = false;

            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

                string query = "Update Employee SET Name = @Name, Position = @Position WHERE Id = @Id";

                MySqlCommand command = new MySqlCommand(query,connection);

                command.Parameters.AddWithValue("@Id", employee.Id);
                command.Parameters.AddWithValue("@Name", employee.Name);
                command.Parameters.AddWithValue("@Position", employee.Position);

                command.ExecuteNonQuery();
                status = true;


            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return status;
        }

        public bool DeleteEmployee(int id)
        {
            bool status = false;

            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "DELETE FROM Employee WHERE Id = @Id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
                status = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return status;
        }
    }
}
