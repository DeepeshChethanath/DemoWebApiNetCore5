using CoreWebApiRepoUoWDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApiRepoUoWDemo.Services
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {

    }
}
