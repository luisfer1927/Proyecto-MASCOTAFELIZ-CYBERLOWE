using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPropietario
    {
        Propietario AddPropietario(Propietario propietario);
        void DeletePropietario(int idPropietario);
        IEnumerable<Propietario> GetAll();
        Propietario GetPropietario(int idPropietario);
        Propietario UpdatePropietario(Propietario propietario);
        Propietario UpdatePropietario(Propietario propietario, int idPropietario);
    }


}