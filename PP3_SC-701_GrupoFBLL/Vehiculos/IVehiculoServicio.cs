using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PP3_SC_701_GrupoFDAL.Entidades;

namespace PP3_SC_701_GrupoFBLL.Vehiculos
{
    public interface IVehiculoServicio
    {
        IEnumerable<Vehiculo> GetVehiculos();
        Vehiculo GetVehiculo(int id);
        void AddVehiculo(Vehiculo vehiculo);
        void UpdateVehiculo(int id, Vehiculo vehiculo);
        void DeleteVehiculo(int id);
    }
}