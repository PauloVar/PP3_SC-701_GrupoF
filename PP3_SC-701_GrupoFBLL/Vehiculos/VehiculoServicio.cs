using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PP3_SC_701_GrupoFDAL.Entidades;
using PP3_SC_701_GrupoFDAL.Vehiculos;

namespace PP3_SC_701_GrupoFBLL.Vehiculos
{
    public class VehiculoServicio : IVehiculoServicio
    {
        private readonly IVehiculoRepositorio repo;

        public VehiculoServicio(IVehiculoRepositorio repo)
        {
            this.repo = repo;
        }

        public IEnumerable<Vehiculo> GetVehiculos()
        {
            return repo.GetVehiculos();
        }

        public Vehiculo GetVehiculo(int id)
        {
            return repo.GetVehiculo(id);
        }

        public void AddVehiculo(Vehiculo vehiculo)
        {
            repo.AddVehiculo(vehiculo);
        }

        public void UpdateVehiculo(int id, Vehiculo vehiculo)
        {
            repo.UpdateVehiculo(id, vehiculo);
        }

        public void DeleteVehiculo(int id)
        {
            repo.DeleteVehiculo(id);
        }
    }
}