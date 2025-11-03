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
    public partial class ManageRentalRecords : Form
    {
        private readonly CarRentalEntities _db;        
        public ManageRentalRecords()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void btnAddRentalRecordViewArchive_Click(object sender, EventArgs e)
        {
            var addRentalRecords = new AddEditRentalRecords();
            addRentalRecords.MdiParent = this.MdiParent;
            addRentalRecords.Show();
        }

        private void btnEditRentalRecordViewArchive_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGVViewArchive.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a record to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // get the ID of the selected car
                var selectedRecordID = (int)dataGVViewArchive.SelectedRows[0].Cells["id"].Value;

                //query the database for the car details
                var selectedRecord = _db.CarRentalRecords.FirstOrDefault(q => q.id == selectedRecordID);

                if (selectedRecord == null)
                {
                    MessageBox.Show("Record not found. It may have been deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //launch the AddEditVehicle form in edit mode
                var editRecords = new AddEditRentalRecords(selectedRecord);
               editRecords.MdiParent = this.MdiParent;
                editRecords.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while trying to edit the Records.\n\nDetails: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteRecordRentalRecordViewArchive_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGVViewArchive.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a Record to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmResult = MessageBox.Show("Are you sure you want to delete this Record?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    var selectedRecordID = (int)dataGVViewArchive.SelectedRows[0].Cells["id"].Value;
                    var selectedRecordDetails = _db.CarRentalRecords.FirstOrDefault(q => q.id == selectedRecordID);

                    if (selectedRecordDetails == null)
                    {
                        MessageBox.Show("Record not found. It may have already been deleted.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    _db.CarRentalRecords.Remove(selectedRecordDetails);
                    _db.SaveChanges();

                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //refresh the data grid view
                    ManageRentalRecords_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while trying to delete the car.\n\nDetails: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreshListGridViewArchive_Click(object sender, EventArgs e)
        {
            ManageRentalRecords_Load(sender, e);

        }

        private void ManageRentalRecords_Load(object sender, EventArgs e)
        {
            try
            {
                var records = _db.CarRentalRecords.Select(q => new
                    {
                       Customer = q.CustomerName,
                       DateOut = q.DateRented,
                          DateIn = q.DateReturned,
                          Id = q.id,
                          Cost = q.Cost,
                          Car = q.TypesOfCAr.Make + " " + q.TypesOfCAr.Model + " " + q.TypesOfCAr.Year

                }).ToList();

                dataGVViewArchive.DataSource = records;
                dataGVViewArchive.Columns["DateOut"].HeaderText = "Date In";
                dataGVViewArchive.Columns["DateIn"].HeaderText = "Date Out";
                dataGVViewArchive.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading vehicle data.\n\nDetails: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
