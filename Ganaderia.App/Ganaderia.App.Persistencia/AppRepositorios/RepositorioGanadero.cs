using System;
using Ganaderia.App.Dominio;
using System.Collections.Generic;

namespace Ganaderia.App.Persistencia

{
    public class RepositorioGanadero : IRepositorioGanadero
    {
        private readonly AppContext _appContext;
        
         public RepositorioGanadero(AppContext appContext)
        {
            _appContext = appContext;
        }
        
        Ganadero IRepositorioGanadero.AddGanadero(Ganadero ganadero)
        {
            var ganaderoAdicionado = _appContext.Ganaderos.Add(ganadero);
            _appContext.SaveChanges();
            return ganaderoAdicionado.Entity;            
        }

        IEnumerable<Ganadero> IRepositorioGanadero.GetAllGanaderos()
        {
            return _appContext.Ganaderos;
        }
    }
}    