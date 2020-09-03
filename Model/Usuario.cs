//sistema de adicionar usuario 
using System.ComponentModel.DataAnnotations;
using crudApi.Model;

namespace crudApi.Model
{
    public class Usuario
    {
        [Key]
        public int cpf { get; set; }
        public string nome { get; set; }
        public int telefone { get; set; }
        public string email { get; set; }

    }


}
