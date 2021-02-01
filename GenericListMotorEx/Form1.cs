using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericListMotorEx
{
    public struct MotorObject
    {
        public string motorID;
        public string description;
        public double rPM;
        public double voltage;
        public string status;

    }

    public partial class Form1 : Form
    {
        string msg = string.Empty;

        

        List<MotorObject> Motors = new List<MotorObject>();

        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            try
            {
                MotorObject motor;

             
                motor.motorID = txtMotorId.Text.Trim().ToString();
                motor.description = txtDesc.Text.Trim().ToString(); ;
                motor.rPM = Convert.ToDouble(txtRPM.Text);
                motor.voltage = Convert.ToDouble(txtVoltage.Text);
                motor.status = grpStatus.Text.Trim().ToString();;

                Motors.Add(motor);

                foreach (Control ctrl in this.Controls)
                {
                    ctrl.Text = "";
                }
               
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    MessageBox.Show("You have invalid data. Please fix all errors.");

                }
                else
                {
                    if (Motors.Count >= 6)
                    {
                        MessageBox.Show("You can only enter 5 motors.");
                    }
                    else
                    {
                       MessageBox.Show("Motor has been added.");
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            int motorNum = Motors.Count;

            string msg = string.Empty;



            if (Motors.Count <= 1 || Motors.Count >= 5)
            {
                MessageBox.Show("Please enter a number between 1 and 5");
            }
            //if (Motors.Count != print)
            //{
            //    MessageBox.Show($"There are only {motorNum} motors in the list. Please enter a lower number.");
            //}



            

            foreach (MotorObject current in Motors)
            {

                msg += $"MotorID: {current.motorID}";
            }

            MessageBox.Show(msg);

            //PrintMotorList();

            //MessageBox.Show($"{}");


        }

        private void PrintMotorList(int? ordinal = null)
        {
           // //string msg = string.Empty;


           // if (ordinal == null)
           // {
           //     foreach (MotorObject motor in Motors)
           //     {
           //         msg += $"MotorID: {motor.motorID}";
           //     }

           // }
           // else
           // {
           //     if (ordinal > Motors.Count - 1)
           //     {
           //         MessageBox.Show("Please enter a number between 1 and 5");
           //         return;
           //     }

           //     MotorObject motor = Motors[ordinal.Value];

           //     //msg += $"MotorID: {motor.motorID}" +
           //     //       $"Discriptions: {motor.description}" +
           //     //       $"RPM: {motor.rPM}" +
           //     //       $"Voltage: {motor.voltage}" +
           //     //       $"Status: {motor.status}";
           // }





           //MessageBox.Show(msg);

        }
        #region Validating
        private void txtMotorId_Validating(object sender, CancelEventArgs e)
        {
            string motorID = txtMotorId.Text.Trim();

            if (motorID.Length != 5)
            {
                errorProvider1.SetError(txtMotorId, "Motor ID must be 5 characters in length");
            }
            else
            {
                errorProvider1.SetError(txtMotorId, string.Empty);
                e.Cancel = true;
            }
        }

        private void txtDesc_Validating(object sender, CancelEventArgs e)
        {
            string description = txtDesc.Text.Trim();

            if (description.Length < 1)
            {
                errorProvider1.SetError(txtDesc, "Description is required.");
                //MessageBox.Show("Description is required.");
            }
            else
            {
                errorProvider1.SetError(txtDesc, string.Empty);
                e.Cancel = true;
            }

        }

        private void txtRPM_Validating(object sender, CancelEventArgs e)
        {
            if ((!int.TryParse(txtRPM.Text, out int rPM)) && (rPM < 10 || rPM > 10000))
            {
                errorProvider1.SetError(txtRPM, "RPM must be an integer between 10 and 10000.");
                //MessageBox.Show("RPM must be an integer between 10 and 10000.");

            }
            else
            {
                errorProvider1.SetError(txtRPM, string.Empty);
                e.Cancel = true;
            }
        }

        private void txtVoltage_Validating(object sender, CancelEventArgs e)
        {
            if ((!int.TryParse(txtVoltage.Text, out int voltage)) && (voltage < 1 || voltage > 500))
            {
                errorProvider1.SetError(txtVoltage, "Voltage must be an integer between 1 and 500.");
                //MessageBox.Show("Voltage must be an integer between 1 and 500.");

            }
            else
            {
                errorProvider1.SetError(txtVoltage, string.Empty);
                e.Cancel = true;
            }
        }
        #endregion


    }
}
