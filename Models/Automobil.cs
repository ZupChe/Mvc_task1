using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mvc_task1.Models
{
    public partial class Automobil
    {
        public int Id { get; set; }

        [Display(Name = "CarMark")]
        [Required(ErrorMessage = "CarMarkRequired")]
        public string Marka { get; set; }

        [Display(Name = "CarModel")]
        [Required(ErrorMessage = "CarModelRequired")]
        public string Model { get; set; }

        [Display(Name = "CarYear")]
        [Required(ErrorMessage = "CarYearRequired")]
        public int Godiste { get; set; }

        [Display(Name = "EngineCapacity")]
        [Required(ErrorMessage = "EngineCapacityRequired")]
        public int ZapreminaMotora { get; set; }

        [Display(Name = "Horsepower")]
        [Required(ErrorMessage = "HorsepowerRequired")]
        public int Snaga { get; set; }

        [Display(Name = "CarFuel")]
        [Required(ErrorMessage = "FuelRequired")]
        public string Gorivo { get; set; }

        [Display(Name = "CarBody")]
        [Required(ErrorMessage = "CarBodyRequred")]
        public string Karoserija { get; set; }

        [Display(Name = "CarPhoto")]
        public string Foto { get; set; }

        [Display(Name = "CarDetails")]
        [Required(ErrorMessage = "CarDetailsRequired")]
        public string Opis { get; set; }

        [Display(Name = "CarPrice")]
        [Required(ErrorMessage = "CarPriceRequired")]
        public double Cena { get; set; }

        [Display(Name = "SalerContact")]
        [Required(ErrorMessage = "SalerContactRequired")]
        public string Kontakt { get; set; }

        public int? IsDeleted { get; set; }

        
    }
}
