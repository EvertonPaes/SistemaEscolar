using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaEscolar
.Models
{
    public class Turma
    {
       public int Id { get; set; }
       public string Sala { get; set;}
       public Professor Professor { get; set;}
  
    }
}