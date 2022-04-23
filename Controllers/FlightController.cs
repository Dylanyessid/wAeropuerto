using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using frmAeropuerto.Models;
namespace frmAeropuerto.Controllers
{
    internal class FlightController
    {
        FlightEntity flightEntity;
        public FlightController()
        {
            flightEntity = new FlightEntity();
        }

        //Constructor para instanciar una entidad que crea un nuevo vuelo.
        public FlightController(string originCity, string destinyCity, DateTime date, TimeSpan departureTime, TimeSpan arrivalTime, string airline, string state)
        {
            flightEntity = new FlightEntity( originCity,  destinyCity,  date,  departureTime,  arrivalTime,  airline,  state);
        }
        public FlightController(int flightId, string originCity, string destinyCity, DateTime date, TimeSpan departureTime, TimeSpan arrivalTime, string airline, string state)
        {
            flightEntity = new FlightEntity(flightId, originCity, destinyCity, date, departureTime, arrivalTime, airline, state);
        }
        public FlightController(int flightId)
        {
            flightEntity = new FlightEntity(flightId);
        }
        

        //Método para validar datos al crear/actualizar
        private void validateData(FlightEntity flightEntity)
        {
            if (flightEntity.OriginCity == "")
            {
                throw new ArgumentException("El campo de la ciudad de origen NO puede estar vacío");

            }
            if (flightEntity.DestinyCity == "")
            {
                throw new ArgumentException("El campo de la ciudad de destino NO puede estar vacío");
            }
            if (flightEntity.Airline == "")
            {
                throw new ArgumentException("El campo de la aereolínea NO puede estar vacío");
            }
            if (flightEntity.State == "")
            {
                throw new ArgumentException("El campo del estado de vuelo NO puede estar vacío");
            }

        }
        //Ejecuta obtener los vuelos
        public List<FlightEntity> executeGetFlights()
        {

            return flightEntity.getFlights();
        }
        //Ejecutar el crear nuevo vuelo 
        public bool executeCreateNewFlight()
        {
            validateData(flightEntity);
           return flightEntity.createNewFlight();
            
          
        }
        //Ejecutar el crear actualizar vuelo 
        public bool executeUpdateFlight()
        {
            validateData(flightEntity);
            return flightEntity.updateFlight();
        }

        //Ejecutar el eliminar nuevo vuelo 
        public bool executeDeleteFligth()
        {
            return flightEntity.deleteFlight();
        }
    }
}
