namespace GenericListMotorEx
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtMotorToPrint = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.txtVoltage = new System.Windows.Forms.TextBox();
            this.txtRPM = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtMotorId = new System.Windows.Forms.TextBox();
            this.rdoNA = new System.Windows.Forms.RadioButton();
            this.rdoMNT = new System.Windows.Forms.RadioButton();
            this.rdoOff = new System.Windows.Forms.RadioButton();
            this.rdoOn = new System.Windows.Forms.RadioButton();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grpStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMotorToPrint
            // 
            this.txtMotorToPrint.Location = new System.Drawing.Point(352, 14);
            this.txtMotorToPrint.MaxLength = 5;
            this.txtMotorToPrint.Name = "txtMotorToPrint";
            this.txtMotorToPrint.Size = new System.Drawing.Size(44, 20);
            this.txtMotorToPrint.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Motor to print:";
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.txtVoltage);
            this.Panel1.Controls.Add(this.txtRPM);
            this.Panel1.Controls.Add(this.txtDesc);
            this.Panel1.Controls.Add(this.txtMotorId);
            this.Panel1.Location = new System.Drawing.Point(111, 11);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(132, 119);
            this.Panel1.TabIndex = 1;
            // 
            // txtVoltage
            // 
            this.txtVoltage.Location = new System.Drawing.Point(12, 88);
            this.txtVoltage.Name = "txtVoltage";
            this.txtVoltage.Size = new System.Drawing.Size(87, 20);
            this.txtVoltage.TabIndex = 4;
            this.txtVoltage.Validating += new System.ComponentModel.CancelEventHandler(this.txtVoltage_Validating);
            // 
            // txtRPM
            // 
            this.txtRPM.Location = new System.Drawing.Point(12, 58);
            this.txtRPM.Name = "txtRPM";
            this.txtRPM.Size = new System.Drawing.Size(87, 20);
            this.txtRPM.TabIndex = 3;
            this.txtRPM.Validating += new System.ComponentModel.CancelEventHandler(this.txtRPM_Validating);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(12, 32);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(87, 20);
            this.txtDesc.TabIndex = 2;
            this.txtDesc.Validating += new System.ComponentModel.CancelEventHandler(this.txtDesc_Validating);
            // 
            // txtMotorId
            // 
            this.txtMotorId.Location = new System.Drawing.Point(12, 6);
            this.txtMotorId.MaxLength = 5;
            this.txtMotorId.Name = "txtMotorId";
            this.txtMotorId.Size = new System.Drawing.Size(87, 20);
            this.txtMotorId.TabIndex = 1;
            this.txtMotorId.Validating += new System.ComponentModel.CancelEventHandler(this.txtMotorId_Validating);
            // 
            // rdoNA
            // 
            this.rdoNA.AutoSize = true;
            this.rdoNA.Location = new System.Drawing.Point(89, 52);
            this.rdoNA.Name = "rdoNA";
            this.rdoNA.Size = new System.Drawing.Size(40, 17);
            this.rdoNA.TabIndex = 40;
            this.rdoNA.Text = "NA";
            this.rdoNA.UseVisualStyleBackColor = true;
            // 
            // rdoMNT
            // 
            this.rdoMNT.AutoSize = true;
            this.rdoMNT.Location = new System.Drawing.Point(24, 52);
            this.rdoMNT.Name = "rdoMNT";
            this.rdoMNT.Size = new System.Drawing.Size(49, 17);
            this.rdoMNT.TabIndex = 39;
            this.rdoMNT.Text = "MNT";
            this.rdoMNT.UseVisualStyleBackColor = true;
            // 
            // rdoOff
            // 
            this.rdoOff.AutoSize = true;
            this.rdoOff.Location = new System.Drawing.Point(90, 29);
            this.rdoOff.Name = "rdoOff";
            this.rdoOff.Size = new System.Drawing.Size(39, 17);
            this.rdoOff.TabIndex = 38;
            this.rdoOff.Text = "Off";
            this.rdoOff.UseVisualStyleBackColor = true;
            // 
            // rdoOn
            // 
            this.rdoOn.AutoSize = true;
            this.rdoOn.Checked = true;
            this.rdoOn.Location = new System.Drawing.Point(24, 29);
            this.rdoOn.Name = "rdoOn";
            this.rdoOn.Size = new System.Drawing.Size(39, 17);
            this.rdoOn.TabIndex = 37;
            this.rdoOn.TabStop = true;
            this.rdoOn.Text = "On";
            this.rdoOn.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(14, 99);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(46, 13);
            this.Label4.TabIndex = 35;
            this.Label4.Text = "Voltage:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(14, 69);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(34, 13);
            this.Label3.TabIndex = 34;
            this.Label3.Text = "RPM:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(14, 41);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(63, 13);
            this.Label2.TabIndex = 33;
            this.Label2.Text = "Description:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(14, 17);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(49, 13);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Motor Id:";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(277, 56);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(17, 257);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.rdoOn);
            this.grpStatus.Controls.Add(this.rdoOff);
            this.grpStatus.Controls.Add(this.rdoMNT);
            this.grpStatus.Controls.Add(this.rdoNA);
            this.grpStatus.Location = new System.Drawing.Point(17, 136);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(200, 100);
            this.grpStatus.TabIndex = 41;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(424, 302);
            this.Controls.Add(this.grpStatus);
            this.Controls.Add(this.txtMotorToPrint);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtMotorToPrint;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.TextBox txtVoltage;
        internal System.Windows.Forms.TextBox txtRPM;
        internal System.Windows.Forms.TextBox txtDesc;
        internal System.Windows.Forms.TextBox txtMotorId;
        internal System.Windows.Forms.RadioButton rdoNA;
        internal System.Windows.Forms.RadioButton rdoMNT;
        internal System.Windows.Forms.RadioButton rdoOff;
        internal System.Windows.Forms.RadioButton rdoOn;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnPrint;
        internal System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}

