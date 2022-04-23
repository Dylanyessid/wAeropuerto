using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace frmAeropuerto.Models
{
    internal class FlightEntity
    {
        //Definición de propiedades.
        public int FlightId { get; set; }
        public string OriginCity { get; set; }
        public string DestinyCity { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan DepartureTime { get; set; }
        public TimeSpan ArrivalTime { get; set; }
        public string Airline { get; set; }
        public string State { get; set; }

        //Constructores para sus diferentes usos
        public FlightEntity(string originCity, string destinyCity, DateTime date, TimeSpan departureTime, TimeSpan arrivalTime, string airline, string state)
        {
            OriginCity = originCity;
            DestinyCity = destinyCity;
            Date = date;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            Airline = airline;
            State = state;
        }

        public FlightEntity()
        {
        }

        public FlightEntity(int flightId, string originCity, string destinyCity, DateTime date, TimeSpan departureTime, TimeSpan arrivalTime, string airline, string state)
        {
            FlightId = flightId;
            OriginCity = originCity;
            DestinyCity = destinyCity;
            Date = date;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            Airline = airline;
            State = state;
        }

        public FlightEntity(int flightId)
        {
            FlightId = flightId;
        }

        //Método que crea un nuevo vuelo programado.
        public bool createNewFlight()
        {
            NpgsqlCommand cmd = new NpgsqlCommand($"INSERT INTO flights values (DEFAULT, @origin, @destiny,@date, " +
                $"@departureTime, @arrivalTime, @airline, @state )", Connection.connectDatabase());
            cmd.Parameters.AddWithValue("@origin", OriginCity);
            cmd.Parameters.AddWithValue("@destiny", DestinyCity);
            cmd.Parameters.AddWithValue("@date", Date);
            cmd.Parameters.AddWithValue("@departureTime", DepartureTime);
            cmd.Parameters.AddWithValue("@arrivalTime", ArrivalTime);
            cmd.Parameters.AddWithValue("@airline", Airline);
            cmd.Parameters.AddWithValue("@state", State);

            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else{
                return false;
            }

        }
        //Método que actualiza un vuelo existente.
        public bool updateFlight() {
            NpgsqlCommand cmd = new NpgsqlCommand($"UPDATE flights SET  origin_city=@origin, destiny_city=@destiny," +
                $"flight_date=@date, departure_time=@departureTime, arrival_time=@arrivalTime, " +
                $"airline=@airline, state=@state WHERE flight_id=@flightId", Connection.connectDatabase());
            cmd.Parameters.AddWithValue("@flightId", FlightId);
            cmd.Parameters.AddWithValue("@origin", OriginCity);
            cmd.Parameters.AddWithValue("@destiny", DestinyCity);
            cmd.Parameters.AddWithValue("@date", Date);
            cmd.Parameters.AddWithValue("@departureTime", DepartureTime);
            cmd.Parameters.AddWithValue("@arrivalTime", ArrivalTime);
            cmd.Parameters.AddWithValue("@airline", Airline);
            cmd.Parameters.AddWithValue("@state", State);

            try
            {

                if (cmd.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }
        //Método que obtiene la lista de los vuelos existentes en la base de datos
        public List<FlightEntity> getFlights()
        {
            NpgsqlCommand cmd = new NpgsqlCommand($"SELECT * from flights", Connection.connectDatabase());
            NpgsqlDataReader dr = cmd.ExecuteReader();
            FlightEntity currentFlight;
            List<FlightEntity> flightsList = new List<FlightEntity>();
            
            while (dr.Read())
            {
                currentFlight = new FlightEntity();
                currentFlight.FlightId = dr.GetInt16(0);
                currentFlight.OriginCity = dr.GetString(1);
                currentFlight.DestinyCity = dr.GetString(2);
                currentFlight.Date = Convert.ToDateTime(dr.GetValue(3)).Date;
                currentFlight.DepartureTime = (dr.GetTimeSpan(4));
                currentFlight.ArrivalTime = (dr.GetTimeSpan(5));
                currentFlight.Airline = dr.GetString(6);
                currentFlight.State = dr.GetString(7);
                flightsList.Add(currentFlight);
                
            }
            return flightsList;
        }

        //Método que elimina un vuelo existente.
        public bool deleteFlight()
        {
            NpgsqlCommand cmd = new NpgsqlCommand($"DELETE FROM flights WHERE flight_id=@flightId", Connection.connectDatabase());
            cmd.Parameters.AddWithValue("@flightId", FlightId);
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
