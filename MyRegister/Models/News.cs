using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyRegister.Models
{
    public class News
    {
        
        public int id { get; set; }
        
        [DisplayName("Título")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string title { get; set; }

        [DisplayName("Veracidade")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public bool label2 { get; set; }

        [DisplayName("Fonte")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string author { get; set; }

    }
}
