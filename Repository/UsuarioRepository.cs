using System.Collections.Generic;
using System.Linq;
using crudApi.Model;

namespace  crudApi.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly UsuarioDbContext _contexto;


        public UsuarioRepository(UsuarioDbContext ctx)
        {   //injeção do contexto do EF
            _contexto = ctx;
        }

        public void Add(Usuario cpf)
        {
           _contexto.Usuario.Add(cpf);
            _contexto.SaveChanges();
        }

        public Usuario Find(int cpf)
        {
             return _contexto.Usuario.FirstOrDefault(u => u.cpf == cpf);
        }

        public IEnumerable<Usuario> GetAll()
        {
               return _contexto.Usuario.ToList();
        }

        public void Remove(int cpf)
        {
            var entity = _contexto.Usuario.First(u=> u.cpf == cpf);
           _contexto.Usuario.Remove(entity);
           _contexto.SaveChanges();;
        }

        public void Update(Usuario cpf)
        {
            _contexto.Usuario.Update(cpf);
            _contexto.SaveChanges();
        }
    }
}