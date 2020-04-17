using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaEscolar.Models
{
    public class Professor
    {
       public int Id { get; set;}
       public string Nome { get; set;}
        [Display(Name = "Data de nascimento"),
        DataType(DataType.Date)]
       public DateTime Nascimento { get; set;}
        public string CPF { get; set;}

       
             
  
    }
}