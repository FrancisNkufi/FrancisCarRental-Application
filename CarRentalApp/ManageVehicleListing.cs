using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class ManageVehicleListing : Form
    {
        private readonly CarRentalEntities _db;
        public ManageVehicleListing()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {
            try
            {
                var cars = _db.TypesOfCArs
                    .Select(q => new
                    {
                        q.Make,
                        Model = q.Model,
                        VIN = q.VIN,
                        Year = q.Year,
                        LicencePlate = q.LicensePlateNumber,
                        q.Id
                    })
                    .ToList();

                dataGVCarListing.DataSource = cars;
                dataGVCarListing.Columns[4].HeaderText = "License Plate Number";
                dataGVCarListing.Columns[5].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading vehicle data.\n\nDetails: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            try
            {
                var addCarForm = new AddEditVehicle(this);
                addCarForm.MdiParent = this.MdiParent;
                addCarForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open Add Car form.\n\nDetails: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGVCarListing.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a car to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // get the ID of the selected car
                var selectedCarID = (int)dataGVCarListing.SelectedRows[0].Cells[5].Value;

                //query the database for the car details
                var selectedCarDetails = _db.TypesOfCArs.FirstOrDefault(q => q.Id == selectedCarID);

                if (selectedCarDetails == null)
                {
                    MessageBox.Show("Car details not found. It may have been deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //launch the AddEditVehicle form in edit mode
                var editCarForm = new AddEditVehicle(selectedCarDetails, this);
                editCarForm.MdiParent = this.MdiParent;
                editCarForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while trying to edit the car.\n\nDetails: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGVCarListing.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a car to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmResult = MessageBox.Show("Are you sure you want to delete this car?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    var selectedCarID = (int)dataGVCarListing.SelectedRows[0].Cells[5].Value;
                    var selectedCarDetails = _db.TypesOfCArs.FirstOrDefault(q => q.Id == selectedCarID);

                    if (selectedCarDetails == null)
                    {
                        MessageBox.Show("Car not found. It may have already been deleted.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    _db.TypesOfCArs.Remove(selectedCarDetails);
                    _db.SaveChanges();

                    MessageBox.Show("Car deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //refresh the data grid view
                    ManageVehicleListing_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while trying to delete the car.\n\nDetails: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnRefreshListGrid_Click(object sender, EventArgs e)
        {
            try
            {
                ManageVehicleListing_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while refreshing the car list.\n\nDetails: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
