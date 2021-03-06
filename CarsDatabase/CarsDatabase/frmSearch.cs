﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarsDatabase
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hireDataSet.tblCar' table. You can move, or remove it, as needed.
            this.tblCarTableAdapter.Fill(this.hireDataSet.tblCar);
            fillBoxes();
            this.Text = "Task A Search - Ciarán Maher - " + DateTime.Now;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtValue.Text != "")
            {
                try
                {
                    //Builds a string with the pre-set format to match the table layout. FillBy querybuilder option was considered but this was found to be more efficient.
                    string strMyQuery = String.Format("SELECT VehicleRegNo, Make, EngineSize, DateRegistered, '€' + CAST(RentalDay AS varchar) AS RentalDay, Available FROM tblCar WHERE {0} {1} @Third", cboField.SelectedItem, cboOperator.SelectedItem);

                    SqlConnection cnMyConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Hire.mdf;Integrated Security=True");
                    cnMyConnection.Open();
                    SqlCommand cmMySQLcommand = cnMyConnection.CreateCommand();


                    cmMySQLcommand.CommandType = CommandType.Text;
                    cmMySQLcommand.Parameters.AddWithValue("@Third", txtValue.Text);

                    cmMySQLcommand.CommandText = strMyQuery;
                    cmMySQLcommand.ExecuteNonQuery();

                    DataTable table = new DataTable();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmMySQLcommand);
                    dataAdapter.Fill(table);
                    dgvSearchGrid.DataSource = table;
                    //dgvSearchGrid.DataMember = "tblCar";

                    if (dgvSearchGrid.Rows.Count == 0)
                    {
                        MessageBox.Show("Unable to find a match for your query, please try again!");
                    }
                }
                //Catch an SQL specific crash and return appropriate feedback to the user.
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Program encountered an error in your query!\n" + "Original Error:\n" + sqlEx.Message);
                }
                //Catch a general crash and return appropriate feedback to the user.
                catch (Exception ex)
                {
                    MessageBox.Show("Program encountered an error.\n" + "Original Error:\n" + ex.Message);
                }
            }
                //Error Feedback if user doesn't specify a search value.
            else
            {
                MessageBox.Show("You need to enter value text!");
            }
        }
        //Closes the form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Populates combo-boxes.
        private void fillBoxes()
        {
            cboField.Items.Add("Make");
            cboField.Items.Add("EngineSize");
            cboField.Items.Add("RentalPerDay");
            cboField.Items.Add("Available");
            cboField.SelectedIndex = 0;

            cboOperator.Items.Add("=");
            cboOperator.Items.Add("<");
            cboOperator.Items.Add(">");
            cboOperator.Items.Add("<=");
            cboOperator.Items.Add(">=");
            cboOperator.SelectedIndex = 0;
        }
    }
}
