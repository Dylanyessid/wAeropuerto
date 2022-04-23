using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frmAeropuerto.Controllers;

namespace frmAeropuerto.Views
{
    public partial class frmFlightsList : Form
    {
        //Definición de variables, objeto controlador y lista de vuelos
        FlightController flightController;
        List<Models.FlightEntity> flights;
        private int flightId;
        private bool isEditMode;


        public frmFlightsList()
        {
            InitializeComponent();
            isEditMode = false;
            btnDelete.Enabled = false;
        }

        #region visualMethods
        /*Métodos que interactúan directamente con la interfaz de usuario, muestra información o limpia
        las entradas de datos*/
        private void fillListBox()
        {
            lstOutFlights.Items.Clear();
            flightController = new FlightController();
            flights = flightController.executeGetFlights();

            foreach (var flight in flights)
            {
                lstOutFlights.Items.Add($"VUELO: {flight.OriginCity} => {flight.DestinyCity} || FECHA: {flight.Date.ToShortDateString()} || SALIDA: {flight.DepartureTime}. LLEGADA: {flight.ArrivalTime}.");
            }
        }
        private void clearInputs()
        {
            
            txtAirline.Text = "";
            txtDestiny.Text = "";
            txtOrigin.Text = "";
            txtState.Text = "";
            dtpArrivalTime.Value = DateTime.Now;
            dtpDepartureTime.Value = DateTime.Now;
            dtpDate.Value = DateTime.Now;
        }
        #endregion

        #region Events
        private void frmFlightsList_Load(object sender, EventArgs e)
        {
            dtpDepartureTime.CustomFormat = "HH:MM";
            dtpArrivalTime.CustomFormat = "HH:MM";
            fillListBox();
        }

        //Al hacer click sobre algún elemento de la lista, obtiene los valores para su posterior edición/eliminación
        private void lstOutFlights_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                flightId = flights.ElementAt(lstOutFlights.SelectedIndex).FlightId;
                txtAirline.Text = flights.ElementAt(lstOutFlights.SelectedIndex).Airline.ToString();
                txtDestiny.Text = flights.ElementAt(lstOutFlights.SelectedIndex).DestinyCity.ToString();
                txtOrigin.Text = flights.ElementAt(lstOutFlights.SelectedIndex).OriginCity.ToString();
                txtState.Text = flights.ElementAt(lstOutFlights.SelectedIndex).State.ToString();
                dtpDate.Value = flights.ElementAt(lstOutFlights.SelectedIndex).Date;
                btnDelete.Enabled = true;
                isEditMode = true;
            }
            catch (System.ArgumentOutOfRangeException)
            {

             //Dejo vacía para ignorar esta excepción
            }
            
        }
        #endregion

        #region ButtonEvents
        /*Método que guarda un nuevo vuelo programado o que edita uno ya existente.
         Para identificar si está guardando uno nuevo o editando, se utiliza el booleano "isEditMode"*/
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                flightController = new FlightController(
                   flightId,
                   txtOrigin.Text,
                   txtDestiny.Text,
                   dtpDate.Value,
                   TimeSpan.Parse(dtpDepartureTime.Text),
                   TimeSpan.Parse(dtpArrivalTime.Text),
                   txtAirline.Text,
                   txtState.Text
                   );
                
                try
                {
                    if (flightController.executeUpdateFlight())
                    {
                        MessageBox.Show("Vuelo actualizado con éxito.");
                        isEditMode = false;
                        fillListBox();
                        clearInputs();
                    }
                    
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show("Dato inválido: " + ex.Message);
                    return;
                }
                catch (Npgsql.NpgsqlException ex)
                {
                    MessageBox.Show("Ha ocurrido un problema. Contacte a soporte técnico. ERROR:" + ex.Message);
                    return;
                }
            }
            else
            {
                flightController = new FlightController(
                    txtOrigin.Text,
                    txtDestiny.Text,
                    dtpDate.Value,
                    TimeSpan.Parse(dtpDepartureTime.Text),
                    TimeSpan.Parse(dtpArrivalTime.Text),
                    txtAirline.Text,
                    txtState.Text
                    );
                try
                {
                    if (flightController.executeCreateNewFlight())
                    {
                        MessageBox.Show("Vuelo programado con éxito.");
                        fillListBox();
                        clearInputs();
                    }
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show("Dato inválido: " + ex.Message);
                }
                catch (Npgsql.NpgsqlException ex)
                {
                    MessageBox.Show("Ha ocurrido un problema. Contacte a soporte técnico. ERROR:" + ex.Message);
                    return;
                }
            }
            
 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            flightController = new FlightController(flightId);
            try
            {
                if (flightController.executeDeleteFligth())
                {
                    MessageBox.Show("Vuelo eliminado correctamente");
                    clearInputs();
                    
                    fillListBox();
                    
                    btnDelete.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema. Contacte a soporte técnico. ERROR:" + ex.Message);
                throw;
            }
        }
        #endregion
    }
}
