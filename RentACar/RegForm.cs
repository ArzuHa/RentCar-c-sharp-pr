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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentACarDataSet.Prices' table. You can move, or remove it, as needed.
            this.pricesTableAdapter.Fill(this.rentACarDataSet.Prices);
            // TODO: This line of code loads data into the 'rentACarDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.rentACarDataSet.Client);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.clientTableAdapter.AddClient(textBoxName.Text,textBoxSurname.Text,textBoxFathername.Text, Convert.ToInt32(comboBoxPrice.SelectedValue),textBoxReserveStart.Text,textBoxReserveEnd.Text);
            this.clientTableAdapter.Fill(this.rentACarDataSet.Client);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.clientTableAdapter.SearchText(rentACarDataSet.Client,textBoxSearch.Text);
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Tag = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
            textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString();
            textBoxSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString();
            textBoxFathername.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value?.ToString();
            textBoxReserveStart.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value?.ToString();
            textBoxReserveEnd.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value?.ToString();
            btnEdit.Enabled = btnDelete.Enabled = true;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            clientTableAdapter.EditClient(textBoxName.Text.ToString(),textBoxSurname.Text.ToString(),textBoxFathername.Text.ToString(),Convert.ToInt32(comboBoxPrice.SelectedValue),Convert.ToInt32(this.Tag));
            btnEdit.Enabled = btnDelete.Enabled = false;
            this.Tag = null;
            this.clientTableAdapter.Fill(this.rentACarDataSet.Client);
        }
    }
}
