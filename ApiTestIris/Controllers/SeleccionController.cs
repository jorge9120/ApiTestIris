using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ApiTestIris.Models;
using ApiTestIris.Services;
using System.Net;

namespace ApiTestIris.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SeleccionController : ControllerBase
    {
        private readonly ApiTestIrisDBContext _context;
        private ISeleccionService _seleccionService;
        public SeleccionController(ApiTestIrisDBContext context, ISeleccionService seleccionService)
        {
            _seleccionService = seleccionService;
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _seleccionService.GetAll();
            return Ok(users);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var users = _seleccionService.GetById(id);
            return Ok(users);
        }

        // POST api/<EmployeeRegController>
        [HttpPost]
        public IActionResult Post(Seleccion item)
        {
            _seleccionService.Create(item);
            return Ok(new { Message = "Selección creada" , Status = (int)HttpStatusCode.OK});
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _seleccionService.Delete(id);
            return Ok(new { Message = "Selección eliminada", Status = (int)HttpStatusCode.OK });
        }

        [HttpGet("state/{state}")]
        public IActionResult GetByState(string state)
        {
            var users = _seleccionService.GetByState(state);
            return Ok(users);
        }

        [HttpPut()]
        public IActionResult Put(Seleccion updateSel)
        {

            _seleccionService.Update(updateSel);
            return Ok(new { Message = "Seleccion actualizada", Status = (int)HttpStatusCode.OK });
        }
    }
}
