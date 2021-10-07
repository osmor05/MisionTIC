using System;
using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;


namespace Ganaderia.App.Consola
{
    class Program
    {
        private static IRepositorioGanadero _repoGanadero = new RepositorioGanadero(new Persistencia.AppContext());

        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddGanadero();
            //GetAllGanaderos();
            //UpdateGanadero();
            // DeleteGanadero(3);
            //GetGanadero(2);
            AddVeterinario();
        }

        private static void AddGanadero()
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

            _repoGanadero.AddGanadero(ganadero);
        }

        private static void GetAllGanaderos()
        {
            var ganaderos = _repoGanadero.GetAllGanaderos();

            foreach (Ganadero item in ganaderos)
            {
                Console.WriteLine(item.Nombres);
            }
        }

        private static void UpdateGanadero()
        {
            var ganadero = new Ganadero
            {
                Id = 1,
                Nombres = "Heiner Alejandro",
                Apellidos = "Zarate Cruz",
                NumeroTelefono = "3108182024",
                Direccion = "Calle 4 6 85",
                Correo = "osmor05@gmail.com",
                Contrasena = "12345678",
                Latitude = 34567,
                Longitud = 89765,

            };

            _repoGanadero.UpdateGanadero(ganadero);
        }

        private static void DeleteGanadero(int idGanadero)
        {
           // _repoGanadero.DeleteGanadero(idGanadero);
           string message = _repoGanadero.DeleteGanadero(idGanadero) ? "El ganadero se eliminó correctamemte" : "El ganadero no ha sido encontrado";
           Console.WriteLine(message);
        }

        private static void GetGanadero(int idGanadero)
        {
            var ganadero = _repoGanadero.GetGanadero(idGanadero);
            Console.WriteLine("El nombre del ganadero es: " + ganadero.Nombres);
        }
        
        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                Nombres = "Alfredo",
                Apellidos = "Morales Baquero",
                NumeroTelefono = "3108674209",
                Direccion = "Calle 8 7 45",
                Correo = "amb@gmail.com",
                Contrasena = "12345678",
                Especialidad = "Médico General",
                NumeroTarjeta = "123456"

            };

            _repoVeterinario.AddVeterinario(veterinario);
        }
    }
}
