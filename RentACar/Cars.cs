using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class Cars : Form
    {
        public Cars()
        {
            InitializeComponent();
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentACarDataSet.Fuels' table. You can move, or remove it, as needed.
            this.fuelsTableAdapter.Fill(this.rentACarDataSet.Fuels);
            // TODO: This line of code loads data into the 'rentACarDataSet2.Transmisions' table. You can move, or remove it, as needed.
            this.transmisionsTableAdapter.Fill(this.rentACarDataSet.Transmisions);
            // TODO: This line of code loads data into the 'rentACarDataSet2.Fuels' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'rentACarDataSet2.Series' table. You can move, or remove it, as needed.
            this.seriesTableAdapter.Fill(this.rentACarDataSet.Series);
            // TODO: This line of code loads data into the 'rentACarDataSet1.Models' table. You can move, or remove it, as needed.
            this.modelsTableAdapter.Fill(this.rentACarDataSet.Models);
            // TODO: This line of code loads data into the 'rentACarDataSet1.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.rentACarDataSet.Cars);
            // TODO: This line of code loads data into the 'rentACarDataSet.Cars' table. You can move, or remove it, as needed.
          

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            this.carsTableAdapter.AddCar(Convert.ToInt32(comboBoxModel.SelectedValue),Convert.ToInt32(comboBoxSeries.SelectedValue),Convert.ToInt32(textBoxYear.Text),Convert.ToInt32(comboBoxTransmission.SelectedValue),Convert.ToInt32(comboBoxFueld.SelectedValue));
            this.carsTableAdapter.Fill(rentACarDataSet.Cars);

          
          

        }

        private void comboBoxfueld_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
}
