using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VirtEdu.Domain.Entities;
using VirtEdu.Domain.Interfaces;
using VirtEdu.Infrastructure.Context;


namespace ProyectoFinalMuddle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase

    {
        /*
        private readonly ApplicationContext _context;

        public UsuarioController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet("GetAllUsuarios")]
        public async Task<IActionResult> GetAllUsuarios()
        {
            try
            {
                // Consulta todos los usuarios incluyendo las asignaciones asociadas
                var usuarios = await _context.Usuarios.Include(u => u.Asignaciones).ToListAsync();

                // Si no se encontraron usuarios, devolver un mensaje de error
                if (usuarios == null || usuarios.Count == 0)
                {
                    return NotFound("No se encontraron usuarios.");
                }

                // Devolver la lista de usuarios con sus asignaciones asociadas
                return Ok(usuarios);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Se produjo un error al recuperar los usuarios: {ex.Message}");
            }
        */



        private readonly DataContext _context;

        public UsuarioController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
            public async Task<ActionResult<List<Usuario>>> GetAllUsuarios()
            {
                var usuario = await _context.Usuarios.ToListAsync();
                return Ok(usuario);
            }

        [HttpGet("{id}")]
       
        public async Task<ActionResult<List<Usuario>>> GetUser(int id)
        {
            var usuario = await _context.Usuarios.ToListAsync();
            return Ok(usuario);
        }



    }
}
