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
    public partial class AddEditVehicle : Form
    {
        private bool isEditMode;
        private ManageVehicleListing _parentForm;
        private readonly CarRentalEntities _db;

        public AddEditVehicle(ManageVehicleListing parentForm = null)
        {
            InitializeComponent();
            labelTitleoFAddCarForm.Text = "Add New Vehicle";
            isEditMode = false;
            _db = new CarRentalEntities();
            _parentForm = parentForm;
        }

        public AddEditVehicle(TypesOfCAr carToEdit, ManageVehicleListing parentForm = null)
        {
            InitializeComponent();
            labelTitleoFAddCarForm.Text = "Edit Vehicle Details";
            PopulateFields(carToEdit);
            isEditMode = true;
            _db = new CarRentalEntities();
           _parentForm = parentForm;
        }

        private void PopulateFields(TypesOfCAr car)
        {
            labelIDAddCar.Text = car.Id.ToString();
            tbxMakeAddCar.Text = car.Make;
            tbxModelAddCar.Text = car.Model;
            tbxVINAddCar.Text = car.VIN;
            tbxYearAddCar.Text = car.Year.ToString();
            tbxLicencePlateAddCar.Text = car.LicensePlateNumber;
        }

        private void btnSaveChangesAddCar_Click(object sender, EventArgs e)
        {
            try
            {
                // ✅ Step 1: Validate required fields
                if (string.IsNullOrWhiteSpace(tbxMakeAddCar.Text) ||
                    string.IsNullOrWhiteSpace(tbxModelAddCar.Text) ||
                    string.IsNullOrWhiteSpace(tbxYearAddCar.Text))
                {
                    MessageBox.Show("Please enter Make, Model, and Year before saving.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ Step 2: Validate Year is numeric
                if (!int.TryParse(tbxYearAddCar.Text, out int year))
                {
                    MessageBox.Show("Please enter a valid year (numeric value).",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ Step 3: Save changes (Edit or Add)
                if (isEditMode)
                {
                    var carID = int.Parse(labelIDAddCar.Text);
                    var carToUpdate = _db.TypesOfCArs.FirstOrDefault(q => q.Id == carID);

                    if (carToUpdate == null)
                    {
                        MessageBox.Show("The selected car could not be found. It may have been deleted.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    carToUpdate.Make = tbxMakeAddCar.Text;
                    carToUpdate.Model = tbxModelAddCar.Text;
                    carToUpdate.VIN = tbxVINAddCar.Text;
                    carToUpdate.Year = year;
                    carToUpdate.LicensePlateNumber = tbxLicencePlateAddCar.Text;

                    _db.SaveChanges();
                    _parentForm.btnRefreshListGrid_Click(null, null);
                    MessageBox.Show("Car details updated successfully.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var newCar = new TypesOfCAr()
                    {
                        Make = tbxMakeAddCar.Text,
                        Model = tbxModelAddCar.Text,
                        VIN = tbxVINAddCar.Text,
                        Year = year,
                        LicensePlateNumber = tbxLicencePlateAddCar.Text
                    };

                    _db.TypesOfCArs.Add(newCar);
                    _db.SaveChanges();
                    _parentForm.btnRefreshListGrid_Click(null, null);
                    MessageBox.Show("New car added successfully.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the car.\n\nDetails: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelAddCar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
