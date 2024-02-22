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
    



        private readonly DataContext _context;

        public UsuarioController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("get All user")]
            public async Task<ActionResult<List<Usuario>>> GetAllUsuarios()
            {
                var users = await _context.Usuarios.ToListAsync();
                return Ok(users);
            }

        [HttpGet("getForId")]
       
        public async Task<ActionResult<Usuario>> GetUser(int id)
        {
            var user = await _context.Usuarios.FindAsync(id);
            if (user is null)

                return NotFound("Not found user");
           
            return Ok(user);
        }


        [HttpPost]

        public async Task<ActionResult<List<Usuario>>> AddUser(Usuario updateUser)
        {
            var dbuser = await _context.Usuarios.FindAsync(updateUser.ID_usuario);
            if (dbuser is null)

                return NotFound("Not found user");
            dbuser.nombre=updateUser.nombre;
            dbuser.correo_electronico = updateUser.correo_electronico;
            dbuser.contraseña = updateUser.contraseña;
            dbuser.tipo_usuario = updateUser.tipo_usuario;


            await _context.SaveChangesAsync();

            return Ok(await _context.Usuarios.ToListAsync());
        }

       /* [HttpPut]

        public async Task<ActionResult<List<Usuario>>> UpdateUser(Usuario user)
        {
            _context.Usuarios.Add(user);
            await _context.SaveChangesAsync();

            return Ok(await _context.Usuarios.ToListAsync());
        }
       */

        
        [HttpDelete]
        
        public async Task<ActionResult<List<Usuario>>> DeleteUser(int id)
        {
            var dbuser = await _context.Usuarios.FindAsync(id);
            if (dbuser is null)

            return NotFound("Not found user");
            _context.Usuarios.Remove(dbuser);
            await _context.SaveChangesAsync();

            return Ok(await _context.Usuarios.ToListAsync());
        }

    }
}
