using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsDatabase
{
    public partial class frmCars : Form
    {
        public frmCars()
        {
            InitializeComponent();
        }

        private void tblCarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblCarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hireDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hireDataSet.tblCar' table. You can move, or remove it, as needed.
            this.tblCarTableAdapter.Fill(this.hireDataSet.tblCar);
            updatePosition();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtVehicleReg.Text != "")
                {
                    this.Validate();
                    this.tblCarBindingSource.EndEdit();
                    this.tblCarTableAdapter.Update(this.hireDataSet.tblCar);
                    MessageBox.Show("Update successful!");
                }

                else
                {
                    MessageBox.Show("Program requires a valid registration number!\nPlease try again. ");
                }
            }


            catch (ConstraintException exCon)
            {
                MessageBox.Show("That Vehicle Registration Number already exists.\n" + "Original Error:\n" + exCon.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The program encountered an error.\n" + "Original Error:\n" + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow row = hireDataSet.tblCar.NewRow();
                row["VehicleRegNo"] = "Registration number";
                row["Available "] = 0;
                hireDataSet.tblCar.Rows.Add(row);

                tblCarBindingSource.MoveLast();
                updatePosition();
            }
            catch (ConstraintException)
            {
                MessageBox.Show("Error updating database.\nRegistration number already exists.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating database.\n" + "Original Error:\n" + ex.Message);
            }
        }
        private void updatePosition()
        {
            txtPosition.Text = tblCarBindingSource.Position + 1 + " of " + tblCarBindingSource.Count;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            hireDataSet.tblCar[tblCarBindingSource.Position].Delete();
            
            updatePosition();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch frmSearch = new frmSearch();
            frmSearch.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            hireDataSet.RejectChanges();
            tblCarBindingSource.ResetBindings(false);
            updatePosition(); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tblCarBindingSource.MoveNext();
            updatePosition();
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            tblCarBindingSource.MoveLast();
            updatePosition();
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            tblCarBindingSource.MoveFirst();
            updatePosition();
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tblCarBindingSource.MovePrevious();
            updatePosition();
        }
    }
}
