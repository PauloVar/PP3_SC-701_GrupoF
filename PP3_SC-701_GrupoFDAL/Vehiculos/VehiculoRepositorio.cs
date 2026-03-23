using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PP3_SC_701_GrupoFDAL.Entidades;

namespace PP3_SC_701_GrupoFDAL.Vehiculos
{
    public class VehiculoRepositorio : IVehiculoRepositorio
    {
        private static List<Vehiculo> vehiculos = new List<Vehiculo>()
        {
            new Vehiculo(1, "Toyota", "Corolla", 2020, "Blanco", 10500),
            new Vehiculo(2, "Honda", "Civic", 2021, "Negro", 12500),
            new Vehiculo(3, "Nissan", "Sentra", 2019, "Gris", 9800)
        };

        public IEnumerable<Vehiculo> GetVehiculos()
        {
            return vehiculos;
        }

        public Vehiculo GetVehiculo(int id)
        {
            var vehiculo = vehiculos.FirstOrDefault(v => v.Id == id);

            if (vehiculo == null)
            {
                throw new KeyNotFoundException("Vehículo no encontrado");
            }

            return vehiculo;
        }

        public void AddVehiculo(Vehiculo vehiculo)
        {
            if (vehiculo is null)
            {
                throw new ArgumentNullException(nameof(vehiculo));
            }

            if (vehiculos.Any(v => v.Id == vehiculo.Id))
            {
                throw new InvalidOperationException("Ya existe un vehículo con ese id");
            }

            vehiculos.Add(vehiculo);
        }

        public void UpdateVehiculo(int id, Vehiculo vehiculo)
        {
            if (vehiculo is null)
            {
                throw new ArgumentNullException(nameof(vehiculo));
            }

            var vehiculoActual = vehiculos.FirstOrDefault(v => v.Id == id);

            if (vehiculoActual == null)
            {
                throw new KeyNotFoundException("Vehículo no encontrado");
            }

            var index = vehiculos.IndexOf(vehiculoActual);
            vehiculos[index] = vehiculo;
        }

        public void DeleteVehiculo(int id)
        {
            var vehiculo = vehiculos.FirstOrDefault(v => v.Id == id);

            if (vehiculo == null)
            {
                throw new KeyNotFoundException("Vehículo no encontrado");
            }

            vehiculos.Remove(vehiculo);
        }
    }
}