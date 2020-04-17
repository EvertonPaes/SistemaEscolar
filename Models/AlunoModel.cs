using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaEscolar
.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set;}
          [Display(Name = "Data de nascimento"),
        DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }
         [Display(Name = "Nome do Responsável")]
        public string NomeResponsavel { get; set; }
        
         [Display(Name = "CPF do Responsável")]
        public string CpfResponsavel { get; set; }


        
  
    }
}