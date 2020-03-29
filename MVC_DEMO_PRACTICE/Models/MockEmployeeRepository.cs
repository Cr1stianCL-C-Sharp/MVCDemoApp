using System.Collections.Generic;
using System.Linq;

namespace MVC_DEMO_PRACTICE.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){Id = 1 ,Name= "cristian rosas",Department ="informatica",Email ="crosas@micorreo.cl"},
                new Employee(){Id = 1 ,Name= "cristian parada",Department ="informatica",Email ="crosas@micorreo.cl"},
                new Employee(){Id = 1 ,Name= "cristian celis",Department ="informatica",Email ="crosas@micorreo.cl"}
            };
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }

    }
}
