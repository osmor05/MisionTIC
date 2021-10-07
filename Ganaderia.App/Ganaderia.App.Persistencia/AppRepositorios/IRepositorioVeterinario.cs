using System;
using System.Security.AccessControl;
using Ganaderia.App.Dominio;
using System.Collections.Generic;

namespace Ganaderia.App.Persistencia
{
    public interface IRepositorioVeterinario
    {
        Veterinario AddVeterinario(Veterinario veterinario); 

       /*  IEnumerable<Veterinario> GetAllVeterinarios();

        Veterinario UpdateVeterinario(Veterinario veterinario); 

        Boolean DeleteVeterinario(int idVeterinario);

        Veterinario GetVeterinario(int idVeterinario);   */      
    }
}