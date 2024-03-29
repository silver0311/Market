﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Shared.Entities
{
    public class State
    {
        public int Id { get; set; }

        [Display(Name = "Estado/Departamento")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; } = null!;

        public int CountryId { get; set; }// como esta ligado a country, como es la parte de relacion a amuchos, siempre agreguen esta propiedad, es importante para cuando el usuario esta editando el estado me va interesar que pais es, para cuando el usuario de en el boton regresar y saber a que pais se va regresar

        public Country? Country { get; set; }// uno a muchos

        public ICollection<City>? Cities { get; set; }// muchos a uno

        [Display(Name = "Ciudades")]
        public int CitiesNumber => Cities == null ? 0 : Cities.Count;// cantidad de ciudades


    }

}
