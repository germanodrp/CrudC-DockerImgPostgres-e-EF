using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudComEntityEimgPostgres.Models
{
    public class PassagensUsuarios
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "CodigoVeiculo")]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Sobrenome")]
        [Column("Sobrenome")]
        public string Sobrenome { get; set; }

        [Required]
        [Display(Name = "Cpf")]
        [Column("Cpf")]
        public string Cpf { get; set; }

        [Required]
        [Display(Name = "LocalDeDestino")]
        [Column("LocalDeDestino")]
        public string LocalDeDestino { get; set; }

        [Required]
        [Display(Name = "DataDaPassagem")]
        [Column("DataDaPassagem")]
        public DateTime DataDaPassagem { get; set; }


    }
}
