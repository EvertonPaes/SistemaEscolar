using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaEscolar
.Models
{
    public class Matricula
    {
        public int Id { get; set; }
          [Display(Name = "Data da Matricula"),
        DataType(DataType.Date)]
        public DateTime DataMatricula { get; set; }
         [Display(Name = "Nome do Responsável")]
        public Aluno Aluno { get; set; }
        public Turma Turma{ get; set; }
             
  
    }
}