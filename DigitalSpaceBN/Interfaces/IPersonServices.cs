using Domain.Models;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalSpaceBN.Interfaces
{
    public interface IPersonServices : IRepository<Person>
    {
    }
}
