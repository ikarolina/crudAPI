using System.Collections.Generic;
using crudApi.Model;
using crudApi.Repository;
using Microsoft.AspNetCore.Mvc;


namespace crudApi.Controllers
{
    [Route("api/[Controller]")]

    public class PollController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepositorio;

        public PollController(IUsuarioRepository _usuarioRepo)
        {
            _usuarioRepositorio = _usuarioRepo;
        }

        [HttpGet]
        public IEnumerable<Usuario> getAll(Usuario cpf)
        {
            return _usuarioRepositorio.GetAll();
        }

        [HttpGet("{cpf}", Name = "GetUser")]
        public IActionResult GetById(int cpf)
        { ///mudar campo CPF para String
            var usuario = _usuarioRepositorio.Find(cpf);

            if (usuario == null)
                return NotFound();
             
            return new ObjectResult(usuario);

        }


        [HttpPost]
        public IActionResult Create([FromBody] Usuario usuario)
        {

            if (usuario == null)
                return BadRequest();
           
             _usuarioRepositorio.Add(usuario);
           return CreatedAtRoute("GetUser", new { cpf = usuario.cpf }, usuario);

        }

    }
}