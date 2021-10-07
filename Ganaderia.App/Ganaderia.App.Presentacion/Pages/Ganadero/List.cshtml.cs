using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ganaderia.App.Dominio;

namespace Ganaderia.App.Presentacion.Pages
{
    public class ListModel : PageModel
    {
        public List<Ganadero> Ganaderos { get; set; } 
        public void OnGet()
        {

            var ganadero = new Ganadero
            {
                Nombres = "Oscar Alfredo",
                Apellidos = "Morales Ortiz",
                NumeroTelefono = "3108182024",
                Direccion = "Calle 4 6 85",
                Correo = "osmor05@gmail.com",
                Contrasena = "12345678",
                Latitude = 34567,
                Longitud = 89765,

            };
            
            var ganadero2 = new Ganadero
            {
                Nombres = "Fabio Andres",
                Apellidos = "Morales Ortiz",
                NumeroTelefono = "3046790411",
                Direccion = "Calle 4 6 85",
                Correo = "famo1605@gmail.com",
                Contrasena = "12345678",
                Latitude = 34567,
                Longitud = 89765,

            };

            var ganadero3 = new Ganadero
            {
                Nombres = "Raul Fernando",
                Apellidos = "Morales Ortiz",
                NumeroTelefono = "3105454590",
                Direccion = "Calle 4 6 85",
                Correo = "rafemo0323@gmail.com",
                Contrasena = "12345678",
                Latitude = 34567,
                Longitud = 89765,

            };

            Ganaderos = new List<Ganadero>();
            Ganaderos.Add(ganadero);
            Ganaderos.Add(ganadero2);
            Ganaderos.Add(ganadero3);
        }
    }
}
