using Microsoft.AspNetCore.Mvc;
using PP3_SC_701_GrupoFBLL.Vehiculos;
using PP3_SC_701_GrupoFDAL.Entidades;

namespace PP3_SC_701_GrupoFAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiculosController : ControllerBase
    {
        private readonly IVehiculoServicio _vehiculoServicio;

        public VehiculosController(IVehiculoServicio vehiculoServicio)
        {
            _vehiculoServicio = vehiculoServicio;
        }

        /// <summary>
        /// Obtiene todos los vehículos registrados
        /// </summary>
        /// <returns>Lista de vehículos</returns>
        [HttpGet]
        public IActionResult GetVehiculos()
        {
            var vehiculos = _vehiculoServicio.GetVehiculos();
            return Ok(vehiculos);
        }

        /// <summary>
        /// Obtiene un vehículo por su identificador
        /// </summary>
        /// <param name="id">Id del vehículo</param>
        /// <returns>Vehículo encontrado</returns>
        [HttpGet("{id}")]
        public IActionResult GetVehiculo(int id)
        {
            var vehiculo = _vehiculoServicio.GetVehiculo(id);

            if (vehiculo == null)
                return NotFound(new { mensaje = "Vehículo no encontrado" });

            return Ok(vehiculo);
        }

        /// <summary>
        /// Registra un nuevo vehículo
        /// </summary>
        /// <param name="vehiculo">Datos del vehículo</param>
        /// <returns>Mensaje de confirmación</returns>
        [HttpPost]
        public IActionResult AddVehiculo([FromBody] Vehiculo vehiculo)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _vehiculoServicio.AddVehiculo(vehiculo);

            return Ok(new { mensaje = "Vehículo agregado correctamente" });
        }
    }
}