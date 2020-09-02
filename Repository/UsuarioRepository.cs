using System.Collections.Generic;
using System.Linq;
using crudApi.Model;

namespace  crudApi.Repository
{
    public class UsuariosRepository : IUsuarioRepository
    {
        private readonly UsuarioDbContext _contexto;


        public UsuariosRepository(UsuarioDbContext ctx)
        {   //injeção do contexto do EF
            _contexto = ctx;
        }

        public void Add(Usuario cpf)
        {
            throw new System.NotImplementedException();
        }

        public Usuario Find(int cpf)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Usuario> GetAll()
        {
               return _contexto.Usuario.ToList();
        }

        public void Remove(int cpf)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Usuario cpf)
        {
            throw new System.NotImplementedException();
        }
    }
}