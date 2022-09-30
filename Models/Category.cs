using System.ComponentModel.DataAnnotations;

namespace testeef.Models
{

    public class Category
    {


        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo DEVE CONTER ENTRE 3 E 60 CARACTERES")]

        public String Title { get; set; }   
    }
}