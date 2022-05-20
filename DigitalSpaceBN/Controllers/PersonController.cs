using DigitalSpaceBN.HttpRequest;
using DigitalSpaceBN.Interfaces;
using Domain.DB;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalSpaceBN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonServices _personService;
        private readonly IConfiguration Configuration;
        private readonly DigitalSpaceDbContext _context;

        public PersonController(IPersonServices personService, IConfiguration configuration, DigitalSpaceDbContext context)
        {
            _personService = personService;
            Configuration = configuration;
            _context = context;
        }

        [HttpGet("[Action]")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var query = _personService.QueryNoTracking().Include(x => x.Rol).ToList();

                var response = new
                {
                    success = true,
                    data = query,
                };
                return new OkObjectResult(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    success = false,
                    error = ex.Message,
                    errorCode = ex.HResult
                };
                return new BadRequestObjectResult(response);
            }
        }

        [HttpGet("[Action]/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var query = _context.Person.Where(x => x.PersonID == id).FirstOrDefault();

                if (query == null)
                    return BadRequest(new { success = false, error = 400, content = "No existe esa persona" });

                var response = new
                {
                    success = true,
                    data = query,
                };
                return new OkObjectResult(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    success = false,
                    error = ex.Message,
                    errorCode = ex.HResult
                };
                return new BadRequestObjectResult(response);
            }
        }

        [HttpPost("[Action]")]
        public async Task<IActionResult> Create([FromBody] PersonCreateUpdate request)
        {
            try
            {
                using (var transaccion = _context.Database.BeginTransaction())
                {
                    if (request == null)
                        return BadRequest(new { success = false, error = 400, content = "La informacion que envio esta vacia" });

                    Person persona = new Person
                    {
                        Name = request.Name,
                        Telephone = request.Telephone,
                        Document = request.Document,
                        RolID = request.RolID,
                        CreatedAt = Utils.Globals.GetFechaActual(),
                        CreatedBy = "Juan David API"
                    };

                    await _personService.AddAsync(persona);
                    transaccion.Commit();
                }

                var response = new
                {
                    success = true,
                    data = request
                };

                return new OkObjectResult(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    success = false,
                    error = ex.Message,
                    errorCode = ex.HResult
                };
                return new BadRequestObjectResult(response);
            }
        }

        [HttpPut("[Action]/{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] PersonCreateUpdate request)
        {
            try
            {

                using (var transaccion = _context.Database.BeginTransaction())
                {
                    var p = _personService.GetByIdAsync(id).Result;
                    if (p != null)
                    {
                        p.Name = request.Name;
                        p.Telephone = request.Telephone;
                        p.Document = request.Document;
                        p.RolID = request.RolID;
                        p.UpdatedAt = Utils.Globals.GetFechaActual();

                        await _personService.UpdateAsync(p);
                        transaccion.Commit();
                    }
                }

                var response = new
                {
                    success = true
                };
                return new OkObjectResult(response);
            }
            catch (Exception ex)
            {
                var response = new
                {
                    success = false,
                    error = ex.Message,
                };
                return new BadRequestObjectResult(response);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var p = _personService.GetByIdAsync(id).Result;
            if (p != null)
            {
                try
                {
                    using (var transaccion = _context.Database.BeginTransaction())
                    {
                        var rpta = _context.Remove(p);
                        _context.SaveChanges();
                        transaccion.Commit();
                    }

                    var response = new
                    {
                        success = true
                    };
                    return new OkObjectResult(response);
                }
                catch (Exception ex)
                {
                    var response = new
                    {
                        success = false,
                        error = ex.Message,
                        errorCode = ex.HResult
                    };
                    return new BadRequestObjectResult(response);
                }
            }
            else
            {
                var response = new
                {
                    success = false,
                    error = "No se encontro Persona",
                    errorCode = 400
                };
                return new BadRequestObjectResult(response);
            }
        }
    }
}
