using System.Collections.Generic;
using crudApi.Model;

namespace crudApi.Repository
{
    //metodos que eu quero expor como serviço na minha web api
    public interface IUsuarioRepository
    {
        //  // inclui uma questão
         void Add (Usuario cpf);
        IEnumerable<Usuario> GetAll(); //obtem todas as questões
        Usuario Find (int cpf); //localiza uma questão pelo id 
        void Remove (int cpf); // remove as questões
        void Update (Usuario cpf); //atualiza uma questão
       
    }
  
}