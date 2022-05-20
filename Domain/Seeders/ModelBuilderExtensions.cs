using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Seeders
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var random = new Random();
            var id = 1;
            var _CratedBy = "Juan Leon";


            #region Rols
            modelBuilder.Entity<Rol>().HasData(
               new Rol
               {
                   RolID = 1,
                   Name = "Administrador",
                   CreatedAt = DateTime.Now,
                   CreatedBy = _CratedBy
               },
               new Rol
               {
                   RolID = 2,
                   Name = "Cliente",
                   CreatedAt = DateTime.Now,
                   CreatedBy = _CratedBy
               },
               new Rol
               {
                   RolID = 3,
                   Name = "Vendedor",
                   CreatedAt = DateTime.Now,
                   CreatedBy = _CratedBy
               }
           );
            #endregion

            #region Persons
            var fakerPersons = new Bogus.Faker<Person>()
                    .RuleFor(x => x.PersonID, f => id++)
                    .RuleFor(x => x.Name, f => $"{f.Person.FirstName} {f.Person.LastName}")
                    .RuleFor(x => x.Telephone, f => f.Phone.PhoneNumber())
                    .RuleFor(x => x.Document, f => f.Random.Number(100000000, 999999999).ToString())
                    .RuleFor(x => x.RolID, f => f.Random.Number(1, 3))
                    .RuleFor(x => x.CreatedAt, DateTime.Now)
                    .RuleFor(x => x.CreatedBy, _CratedBy);

            foreach (var p in fakerPersons.Generate(15))
                modelBuilder.Entity<Person>().HasData(p);
            #endregion
        }
    }
}
