using System.Collections.Generic;
using crudApi.Model;
using crudApi.Repository;
using Microsoft.AspNetCore.Mvc;


namespace crudApi.Controllers
{
    [Route("api/[Controller]")]

    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepositorio;

        public UsuarioController(IUsuarioRepository _usuarioRepo)
        {
            _usuarioRepositorio = _usuarioRepo;
        }

        [HttpGet]
        public IEnumerable<Usuario> getAll()
        {
            return _usuarioRepositorio.GetAll();
        }

        [HttpGet("{cpf}", Name = "GetUser")]
        public IActionResult GetByCPF(int cpf)
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
        //    return ("Usuario inse");
           //return CreatedAtRoute("GetUsuario", new { "dedee"};
           return CreatedAtRoute("GetUsuario", new { cpf = usuario.cpf }, usuario);

        }

        [HttpPut("{cpf}")]
        public IActionResult Update (int cpf, [FromBody] Usuario Usuario)
        {
            
            if (Usuario == null || Usuario.cpf != cpf)
           
            return BadRequest();

            var _usuario = _usuarioRepositorio.Find(cpf);

            if (_usuario == null)
            return NotFound();

            _usuario.cpf = Usuario.cpf;
            _usuario.nome = Usuario.nome;

            _usuarioRepositorio.Update(_usuario);
            return new NoContentResult();
        }

        [HttpDelete("{cpf}")]

        public IActionResult Delete (int cpf)
        {
                    var _usuario = _usuarioRepositorio.Find(cpf);

            if (_usuario == null)
            return NotFound();
 
            _usuarioRepositorio.Remove(cpf);
            return new NoContentResult();


        }

    }
}