using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mvc_task1.Models
{
    public partial class Automobil
    {
        public int Id { get; set; }
        [Display(Name = "Marka automobila")]
        [Required(ErrorMessage = "Unesite marku automobila")]
        public string Marka { get; set; }
        [Display(Name = "Model automobila")]
        [Required(ErrorMessage = "Unesite model automobila")]
        public string Model { get; set; }
        [Display(Name = "Godina proizvodnje")]
        [Required(ErrorMessage = "Unesite godinu proizvodnje automobila")]
        public int Godiste { get; set; }
        [Display(Name = "Zapremina motora")]
        [Required(ErrorMessage = "Unesite zapreminu motora")]
        public int ZapreminaMotora { get; set; }
        [Required(ErrorMessage = "Unesite snagu motora")]
        public int Snaga { get; set; }
        [Required(ErrorMessage = "Unesite vrstu goriva")]
        public string Gorivo { get; set; }
        [Required(ErrorMessage = "Unesite tip karoserije")]
        public string Karoserija { get; set; }
        [Display(Name = "Slika automobila")]
        public string Foto { get; set; }
        [Required(ErrorMessage = "Unesite dodatan opis")]
        public string Opis { get; set; }
        [Required(ErrorMessage = "Unesite cenu automobila")]
        public double Cena { get; set; }
        [Required(ErrorMessage = "Unesite kontakt")]
        public string Kontakt { get; set; }
        public int? IsDeleted { get; set; }

        
    }
}
