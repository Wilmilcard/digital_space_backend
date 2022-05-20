using DigitalSpaceBN.Interfaces;
using Domain.Models;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalSpaceBN.Services
{
    public class PersonServices : BaseRepository<Person>, IPersonServices
    {
        public PersonServices(IRepository<Person> repository) : base(repository)
        {

        }
    }
}
