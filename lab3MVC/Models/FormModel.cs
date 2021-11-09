using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab3MVC.Models
{
    public class FormModel
    {
        [Display(Name = "Imię")]
        public string Name { get; set; }
        [Display(Name = "Ilość powtórzeń")]
        [Range(1,5, ErrorMessage = "Proszę wpisać liczbę w przedziale od 1 do 5.")]
        public int NumberOfRepetitions { get; set; }
    }
}
