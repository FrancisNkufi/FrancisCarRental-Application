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
    public partial class AddEditRentalRecords : Form
    {
        private bool isEditMode = false;
        private readonly CarRentalEntities carRentalEntities; 
        public AddEditRentalRecords()
        {
            InitializeComponent();
            carRentalEntities = new CarRentalEntities();
            label1.Text = "Add New Rental Records";
            isEditMode = false;
        }

        public AddEditRentalRecords(CarRentalRecord recordsToEdit)
        {
            InitializeComponent();
            label1.Text = "Edit Rental Records";
            PopulateFields(recordsToEdit);
            isEditMode = true;
            carRentalEntities = new CarRentalEntities();
        }

        private void PopulateFields(CarRentalRecord rentalRecords)
        {
            tbCustomerName.Text = rentalRecords.CustomerName;
            RentedDate.Value = (DateTime)rentalRecords.DateRented;
            ReturnedDate.Value = (DateTime) rentalRecords.DateReturned;
            tbCost.Text = rentalRecords.Cost?.ToString();
            labelRecordID.Text = rentalRecords.id.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {

                string customerName = tbCustomerName.Text;
                var carType = CartypeBox.Text;
                var rentedDate = RentedDate.Value;
                var returnDate = ReturnedDate.Value;
                double cost = Convert.ToDouble(tbCost.Text);
                var isValid = true;
                var errorMessage ="";

                if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(carType))
                {
                    isValid = false;
                    errorMessage += "Error: Please fill in all fields.";
                    
                }

                if (returnDate < rentedDate)
                {
                    isValid = false;
                   errorMessage += "Error: Return date cannot be earlier than rented date.";
                   
                }

                if (isValid)
                {
                    
                    if (isEditMode)
                    {
                        var recordID = int.Parse(labelRecordID.Text);
                        var rentalRecordDetails = carRentalEntities.CarRentalRecords.FirstOrDefault(q => q.id == recordID);
                        rentalRecordDetails.CustomerName = customerName;
                        rentalRecordDetails.DateRented = rentedDate;
                        rentalRecordDetails.DateReturned = returnDate;
                        rentalRecordDetails.Cost = (decimal)cost;
                        rentalRecordDetails.TypeOfCarsiD = (int)CartypeBox.SelectedValue;

                        carRentalEntities.SaveChanges();

                        MessageBox.Show($"Customer Name: {customerName}\n\r" +
                                $"Car Type: {carType}\n\r" +
                                $"Cost: {cost}\n\r" +
                                $"Rented Date: {rentedDate}\n\r" +
                                $"Return Date: {returnDate}\n\r" +
                                $"Thank you for Editing {label1.Text}", "Confirmation");
                    }
                    else
                    {
                        var rentalRecord = new CarRentalRecord();
                        rentalRecord.CustomerName = customerName;
                        rentalRecord.DateRented = rentedDate;
                        rentalRecord.DateReturned = returnDate;
                        rentalRecord.Cost = (decimal)cost;
                        rentalRecord.TypeOfCarsiD = (int)CartypeBox.SelectedValue;

                        carRentalEntities.CarRentalRecords.Add(rentalRecord);
                        carRentalEntities.SaveChanges();

                        MessageBox.Show($"Customer Name: {customerName}\n\r" +
                                  $"Car Type: {carType}\n\r" +
                                  $"Cost: {cost}\n\r" +
                                  $"Rented Date: {rentedDate}\n\r" +
                                  $"Return Date: {returnDate}\n\r" +
                                  $"Thank you for using {label1.Text}", "Confirmation");
                    }
                      Close();
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            catch(Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message, "Error");
                //throw;
            }
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var cars = carRentalEntities.TypesOfCArs
                .Select(q => new
                {
                    Name = q.Make + " " + q.Model + " " + q.Year,
                    Id = q.Id
                })
                .ToList();
            CartypeBox.DisplayMember = "Name";
            CartypeBox.ValueMember = "Id";
            CartypeBox.DataSource = cars;
        }

    }
}
