using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManagment.data
{
    public interface IEmployeeProvider
    {
        IEnumerable<Employee> get();
    }
}
