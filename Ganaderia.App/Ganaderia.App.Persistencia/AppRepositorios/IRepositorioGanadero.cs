using System.Security.AccessControl;
using Ganaderia.App.Dominio;
using System.Collections.Generic;

namespace Ganaderia.App.Persistencia
{
    public interface IRepositorioGanadero
    {
        Ganadero AddGanadero(Ganadero ganadero); 

        IEnumerable<Ganadero> GetAllGanaderos();
    }
}