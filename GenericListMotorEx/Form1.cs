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

    public struct Motor
    {
        public string motorID;
        public string description;
        public int rPM;
        public int voltage;
        public string status;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Motor> motors = new List<Motor>();

        const int LIMIT = 5;

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {



                    if (motors.Count < LIMIT)
                    {
                        Motor motor = new Motor();
                        motor.motorID = txtMotorId.Text.Trim();
                        motor.description = txtDesc.Text.Trim();
                        motor.rPM = Convert.ToInt32(txtRPM.Text);
                        motor.voltage = Convert.ToInt32(txtVoltage.Text);

                        if (rdoMNT.Checked)
                        {
                            motor.status = "On";
                        }
                        else if (rdoNA.Checked)
                        {
                            motor.status = "NA";
                        }
                        else if (rdoOff.Checked)
                        {
                            motor.status = "Off";
                        }
                        else
                        {
                            motor.status = "MNT";
                        }


                        motors.Add(motor);

                        ClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("You can only enter 5 motors.");
                    }
                }
                else
                {
                    MessageBox.Show("You have invalid data. Please fix all errors");
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            }
        

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMotorToPrint.Text, out int motorToPrint) || motorToPrint < 1 || motorToPrint > LIMIT)
            {
                MessageBox.Show($"Please enter a number between 1 and {LIMIT}");
                return;
            }
            if (motorToPrint > motors.Count)
            {
                MessageBox.Show($"There are only {motors.Count} motors in the list. Please enter a lower number.");
                return;
            }
            else
            {
                int motorIndex = motorToPrint - 1;

                MessageBox.Show(motors[motorIndex].motorID + Environment.NewLine +
                    motors[motorIndex].description + Environment.NewLine +
                    motors[motorIndex].rPM.ToString() + Environment.NewLine +
                    motors[motorIndex].voltage.ToString() + Environment.NewLine +
                    motors[motorIndex].status + Environment.NewLine);

                txtMotorToPrint.Clear();
            }

        }
        private void txtMotorId_Validating(object sender, CancelEventArgs e)
        {
            if (txtMotorId.Text.Length != 5)
            {
                e.Cancel = true;

                errorProvider1.SetError(txtMotorId, "Motor ID must be 5 characters in length");
            }
            else
            {
                errorProvider1.SetError(txtMotorId, string.Empty);
            }

        }

        private void txtDesc_Validating(object sender, CancelEventArgs e)
        {
            if (txtDesc.Text == string.Empty)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDesc, "Description is required.");

            }
            else
            {
                errorProvider1.SetError(txtDesc, string.Empty);
            }
        }

        private void txtRPM_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtRPM.Text, out int rPM) && rPM < 10 || rPM > 10000)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtRPM, "RPM must be an integer between 10 and 10000.");


            }
            else
            {
                errorProvider1.SetError(txtRPM, string.Empty);
            }
        }

        private void txtVoltage_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtVoltage.Text, out int voltage) && voltage < 1 || voltage > 500)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtVoltage, "Voltage must bean integer between 1 and 500.");
            }
            else
            {
                errorProvider1.SetError(txtVoltage, string.Empty);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void ClearTextBoxes()
        {
            foreach (TextBox txt in Panel1.Controls)
            {
                txt.Clear();
            }
        }


    }



}
