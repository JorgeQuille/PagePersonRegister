//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PagePersonRegister.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Person
    {
        public int id { get; set; }
        [StringLength(10)]
        [Display(Name = "DNI")]
        public string dni { get; set; }
        [Display(Name = "Nombres")]
        public string first_name { get; set; }
        [Display(Name = "Apellidos")]
        public string last_name { get; set; }
        [StringLength(10)]
        [Display(Name = "Genero")]
        public string gender { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Nacimiento")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime date_birth { get; set; }

        [Display(Name = "Edad")]
        public double edad
        {
            get
            {
                DateTime current_date = DateTime.Now;
                TimeSpan difference_Days = current_date - date_birth;
                double days = difference_Days.TotalDays;
                double years = Math.Floor(days / 365);

                return years;
            }
        }
    }
}
