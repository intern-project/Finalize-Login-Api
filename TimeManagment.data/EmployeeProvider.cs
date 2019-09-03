using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace TimeManagment.data
{
    
    class EmployeeProvider : IEmployeeProvider
    {

        public readonly string connectionString;
        public EmployeeProvider(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public IEnumerable<Employee> get()
        {
            IEnumerable<Employee> employee = null;

            using (var connection = new SqlConnection(connectionString))
            {
                employee = connection.Query<Employee>("select id, first_name as firstName , last_name as lastName, address as address from Employee");
            }

            return employee;
        }
    }
}
