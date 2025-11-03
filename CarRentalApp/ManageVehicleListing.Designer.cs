namespace CarRentalApp
{
    partial class ManageVehicleListing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGVCarListing = new System.Windows.Forms.DataGridView();
            this.ManageVListText = new System.Windows.Forms.Label();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnEditCar = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.btnRefreshListGrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCarListing)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVCarListing
            // 
            this.dataGVCarListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVCarListing.Location = new System.Drawing.Point(12, 59);
            this.dataGVCarListing.Name = "dataGVCarListing";
            this.dataGVCarListing.Size = new System.Drawing.Size(586, 160);
            this.dataGVCarListing.TabIndex = 0;
            // 
            // ManageVListText
            // 
            this.ManageVListText.AutoSize = true;
            this.ManageVListText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ManageVListText.Font = new System.Drawing.Font("Freestyle Script", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageVListText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ManageVListText.Location = new System.Drawing.Point(92, -1);
            this.ManageVListText.Name = "ManageVListText";
            this.ManageVListText.Size = new System.Drawing.Size(381, 47);
            this.ManageVListText.TabIndex = 1;
            this.ManageVListText.Text = "MANAGE VEHICLE LISTING";
            // 
            // btnAddCar
            // 
            this.btnAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.Location = new System.Drawing.Point(12, 225);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(120, 41);
            this.btnAddCar.TabIndex = 2;
            this.btnAddCar.Text = "Add New Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnEditCar
            // 
            this.btnEditCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCar.Location = new System.Drawing.Point(153, 225);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(105, 41);
            this.btnEditCar.TabIndex = 3;
            this.btnEditCar.Text = "Edit Car";
            this.btnEditCar.UseVisualStyleBackColor = true;
            this.btnEditCar.Click += new System.EventHandler(this.btnEditCar_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCar.Location = new System.Drawing.Point(292, 224);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(115, 41);
            this.btnDeleteCar.TabIndex = 4;
            this.btnDeleteCar.Text = "Delete Car";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // btnRefreshListGrid
            // 
            this.btnRefreshListGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshListGrid.Location = new System.Drawing.Point(464, 225);
            this.btnRefreshListGrid.Name = "btnRefreshListGrid";
            this.btnRefreshListGrid.Size = new System.Drawing.Size(134, 40);
            this.btnRefreshListGrid.TabIndex = 5;
            this.btnRefreshListGrid.Text = "Refresh List";
            this.btnRefreshListGrid.UseVisualStyleBackColor = true;
            this.btnRefreshListGrid.Visible = false;
            this.btnRefreshListGrid.Click += new System.EventHandler(this.btnRefreshListGrid_Click);
            // 
            // ManageVehicleListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 286);
            this.Controls.Add(this.btnRefreshListGrid);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.btnEditCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.ManageVListText);
            this.Controls.Add(this.dataGVCarListing);
            this.Name = "ManageVehicleListing";
            this.Text = "Francis Car Rental System V1.0";
            this.Load += new System.EventHandler(this.ManageVehicleListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCarListing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVCarListing;
        private System.Windows.Forms.Label ManageVListText;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.Button btnRefreshListGrid;
    }
}