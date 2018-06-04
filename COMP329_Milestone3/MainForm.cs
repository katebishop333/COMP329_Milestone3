﻿using System.Data.OracleClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP329_Milestone3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT AID,AName,street,city,region,description,phone,email FROM ACCOMMODATION a INNER JOIN Company c on a.COMPANYID = c.COMPANYID WHERE a.AID IN (SELECT r.AccommodationID FROM Room r)";
            LoadUserControls(cmd);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string city = tb_CityName.Text.Trim();
            if (string.IsNullOrEmpty(city))
            {
                MessageBox.Show("Invalid City Name!", "Invalid", MessageBoxButtons.OK);
                return;
            }
            pn_Container.Controls.Clear();
            string cmd = "";
            if (city.ToLower() == "all")
                cmd = "SELECT AID,AName,street,city,region,description,phone,email FROM ACCOMMODATION a INNER JOIN Company c on a.COMPANYID = c.COMPANYID WHERE a.AID IN (SELECT r.AccommodationID FROM Room r)";
            else
            {
                city = char.ToUpper(city[0]) + city.Substring(1);
                cmd = "SELECT AID,AName,street,city,region,description,phone,email FROM ACCOMMODATION a INNER JOIN Company c on a.COMPANYID = c.COMPANYID WHERE a.CITY = '" + city + "' AND a.AID IN (SELECT r.AccommodationID FROM Room r)";
            }
            LoadUserControls(cmd);
        }

        private void LoadUserControls(string cmd)
        {
            OracleConnection myConnection = Db.Connection();
            myConnection.Open();
            OracleCommand myCommand = myConnection.CreateCommand();
            myCommand.CommandText = cmd;
            OracleDataReader reader = myCommand.ExecuteReader();
            
            int top = 10;

            while (reader.Read())
            {
                Accommodation data = new Accommodation();

                data.AID =  (decimal) reader["AID"];
                data.AName = reader["AName"].ToString();
                data.Address = reader.GetString(2) + ", " + reader.GetString(3) + ", " + reader.GetString(4);
                data.Description = reader.GetString(5);
                data.PhoneNo = reader.GetString(6);
                data.Email = reader.GetString(7);

                var myUserControl = new Uc_Accommodations();
                myUserControl.Top = top;
                myUserControl.Left = 35;
                myUserControl.data = data;

                myUserControl.DataBind();

                top = top + myUserControl.Height + 10;
                pn_Container.Controls.Add(myUserControl);
            }
            reader.Close();
            myConnection.Close();
        }

        private void llb_SignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            CompanySignIn form = new CompanySignIn();
            form.ShowDialog();
            Close();
        }

        private void llb_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            CompanyRegister form = new CompanyRegister();
            form.ShowDialog();
            Close();
        }
    }
}
