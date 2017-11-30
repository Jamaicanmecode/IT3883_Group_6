﻿namespace Vandeven_Shuttle
{
    partial class vandevenShuttleSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vandevenShuttleSystem));
            this.reservationDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.passengersComboBox = new System.Windows.Forms.ComboBox();
            this.passengersLabel = new System.Windows.Forms.Label();
            this.destinationComboBox = new System.Windows.Forms.ComboBox();
            this.returningDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.returningLabel = new System.Windows.Forms.Label();
            this.departingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.methodOfReservationComboBox = new System.Windows.Forms.ComboBox();
            this.departingLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.methodOfReservationLabel = new System.Windows.Forms.Label();
            this.customerInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.creditCardNumberTextBox = new System.Windows.Forms.TextBox();
            this.emailMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.creditCardLabel = new System.Windows.Forms.Label();
            this.phoneNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.lastNameMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.homeAddressLabel = new System.Windows.Forms.Label();
            this.firstNameMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.homeAddressTextBox = new System.Windows.Forms.TextBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.newCustomerButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.emailSearchTextBox = new System.Windows.Forms.TextBox();
            this.newCustomerDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.existingCustomerDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.newCustomerTextBox = new System.Windows.Forms.TextBox();
            this.existingCustomerTextBox = new System.Windows.Forms.TextBox();
            this.newUserPanel = new System.Windows.Forms.Panel();
            this.costLabel = new System.Windows.Forms.Label();
            this.confirmPurchaseButton = new System.Windows.Forms.Button();
            this.finalPricelabel = new System.Windows.Forms.Label();
            this.reservationCompletePanel = new System.Windows.Forms.Panel();
            this.thankYouLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reservationDetailsGroupBox.SuspendLayout();
            this.customerInformationGroupBox.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.newUserPanel.SuspendLayout();
            this.reservationCompletePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // reservationDetailsGroupBox
            // 
            this.reservationDetailsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.reservationDetailsGroupBox.Controls.Add(this.passengersComboBox);
            this.reservationDetailsGroupBox.Controls.Add(this.passengersLabel);
            this.reservationDetailsGroupBox.Controls.Add(this.destinationComboBox);
            this.reservationDetailsGroupBox.Controls.Add(this.returningDateTimePicker);
            this.reservationDetailsGroupBox.Controls.Add(this.returningLabel);
            this.reservationDetailsGroupBox.Controls.Add(this.departingDateTimePicker);
            this.reservationDetailsGroupBox.Controls.Add(this.methodOfReservationComboBox);
            this.reservationDetailsGroupBox.Controls.Add(this.departingLabel);
            this.reservationDetailsGroupBox.Controls.Add(this.destinationLabel);
            this.reservationDetailsGroupBox.Controls.Add(this.methodOfReservationLabel);
            this.reservationDetailsGroupBox.Location = new System.Drawing.Point(319, 16);
            this.reservationDetailsGroupBox.Name = "reservationDetailsGroupBox";
            this.reservationDetailsGroupBox.Size = new System.Drawing.Size(330, 241);
            this.reservationDetailsGroupBox.TabIndex = 7;
            this.reservationDetailsGroupBox.TabStop = false;
            this.reservationDetailsGroupBox.Text = "Reservation Details";
            // 
            // passengersComboBox
            // 
            this.passengersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.passengersComboBox.FormattingEnabled = true;
            this.passengersComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.passengersComboBox.Location = new System.Drawing.Point(104, 199);
            this.passengersComboBox.Name = "passengersComboBox";
            this.passengersComboBox.Size = new System.Drawing.Size(56, 21);
            this.passengersComboBox.TabIndex = 13;
            this.passengersComboBox.SelectionChangeCommitted += new System.EventHandler(this.passengersComboBox_SelectionChangeCommitted);
            // 
            // passengersLabel
            // 
            this.passengersLabel.AutoSize = true;
            this.passengersLabel.Location = new System.Drawing.Point(33, 202);
            this.passengersLabel.Name = "passengersLabel";
            this.passengersLabel.Size = new System.Drawing.Size(65, 13);
            this.passengersLabel.TabIndex = 12;
            this.passengersLabel.Text = "Passengers:";
            // 
            // destinationComboBox
            // 
            this.destinationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinationComboBox.FormattingEnabled = true;
            this.destinationComboBox.Items.AddRange(new object[] {
            "Los Angeles",
            "Chicago",
            "New York",
            "Miami",
            "Dallas",
            "San Diego",
            "Seattle"});
            this.destinationComboBox.Location = new System.Drawing.Point(190, 76);
            this.destinationComboBox.Name = "destinationComboBox";
            this.destinationComboBox.Size = new System.Drawing.Size(121, 21);
            this.destinationComboBox.TabIndex = 11;
            this.destinationComboBox.SelectionChangeCommitted += new System.EventHandler(this.destinationComboBox_SelectionChangeCommitted);
            // 
            // returningDateTimePicker
            // 
            this.returningDateTimePicker.CustomFormat = "MM/dd/yy";
            this.returningDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.returningDateTimePicker.Location = new System.Drawing.Point(181, 153);
            this.returningDateTimePicker.Name = "returningDateTimePicker";
            this.returningDateTimePicker.Size = new System.Drawing.Size(76, 20);
            this.returningDateTimePicker.TabIndex = 10;
            // 
            // returningLabel
            // 
            this.returningLabel.AutoSize = true;
            this.returningLabel.Location = new System.Drawing.Point(178, 129);
            this.returningLabel.Name = "returningLabel";
            this.returningLabel.Size = new System.Drawing.Size(56, 13);
            this.returningLabel.TabIndex = 9;
            this.returningLabel.Text = "Returning:";
            // 
            // departingDateTimePicker
            // 
            this.departingDateTimePicker.CustomFormat = "MM/dd/yy";
            this.departingDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.departingDateTimePicker.Location = new System.Drawing.Point(35, 153);
            this.departingDateTimePicker.Name = "departingDateTimePicker";
            this.departingDateTimePicker.Size = new System.Drawing.Size(76, 20);
            this.departingDateTimePicker.TabIndex = 8;
            // 
            // methodOfReservationComboBox
            // 
            this.methodOfReservationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodOfReservationComboBox.FormattingEnabled = true;
            this.methodOfReservationComboBox.Items.AddRange(new object[] {
            "Email",
            "Walk In",
            "Phone"});
            this.methodOfReservationComboBox.Location = new System.Drawing.Point(190, 39);
            this.methodOfReservationComboBox.Name = "methodOfReservationComboBox";
            this.methodOfReservationComboBox.Size = new System.Drawing.Size(121, 21);
            this.methodOfReservationComboBox.TabIndex = 7;
            // 
            // departingLabel
            // 
            this.departingLabel.AutoSize = true;
            this.departingLabel.Location = new System.Drawing.Point(35, 129);
            this.departingLabel.Name = "departingLabel";
            this.departingLabel.Size = new System.Drawing.Size(56, 13);
            this.departingLabel.TabIndex = 6;
            this.departingLabel.Text = "Departing:";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(35, 79);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(63, 13);
            this.destinationLabel.TabIndex = 5;
            this.destinationLabel.Text = "Destination:";
            // 
            // methodOfReservationLabel
            // 
            this.methodOfReservationLabel.AutoSize = true;
            this.methodOfReservationLabel.Location = new System.Drawing.Point(35, 42);
            this.methodOfReservationLabel.Name = "methodOfReservationLabel";
            this.methodOfReservationLabel.Size = new System.Drawing.Size(118, 13);
            this.methodOfReservationLabel.TabIndex = 4;
            this.methodOfReservationLabel.Text = "Method of Reservation:";
            // 
            // customerInformationGroupBox
            // 
            this.customerInformationGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.customerInformationGroupBox.Controls.Add(this.creditCardNumberTextBox);
            this.customerInformationGroupBox.Controls.Add(this.emailMaskedTextBox);
            this.customerInformationGroupBox.Controls.Add(this.emailLabel);
            this.customerInformationGroupBox.Controls.Add(this.creditCardLabel);
            this.customerInformationGroupBox.Controls.Add(this.phoneNumberMaskedTextBox);
            this.customerInformationGroupBox.Controls.Add(this.phoneNumberLabel);
            this.customerInformationGroupBox.Controls.Add(this.lastNameMaskedTextBox);
            this.customerInformationGroupBox.Controls.Add(this.homeAddressLabel);
            this.customerInformationGroupBox.Controls.Add(this.firstNameMaskedTextBox);
            this.customerInformationGroupBox.Controls.Add(this.lastNameLabel);
            this.customerInformationGroupBox.Controls.Add(this.firstNameLabel);
            this.customerInformationGroupBox.Controls.Add(this.homeAddressTextBox);
            this.customerInformationGroupBox.Location = new System.Drawing.Point(36, 16);
            this.customerInformationGroupBox.Name = "customerInformationGroupBox";
            this.customerInformationGroupBox.Size = new System.Drawing.Size(250, 317);
            this.customerInformationGroupBox.TabIndex = 6;
            this.customerInformationGroupBox.TabStop = false;
            this.customerInformationGroupBox.Text = "Customer Information";
            // 
            // creditCardNumberTextBox
            // 
            this.creditCardNumberTextBox.Location = new System.Drawing.Point(117, 225);
            this.creditCardNumberTextBox.MaxLength = 16;
            this.creditCardNumberTextBox.Name = "creditCardNumberTextBox";
            this.creditCardNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.creditCardNumberTextBox.TabIndex = 16;
            this.creditCardNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.creditCardNumberTextBox_KeyPress);
            // 
            // emailMaskedTextBox
            // 
            this.emailMaskedTextBox.Location = new System.Drawing.Point(117, 273);
            this.emailMaskedTextBox.Name = "emailMaskedTextBox";
            this.emailMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailMaskedTextBox.TabIndex = 15;
            this.emailMaskedTextBox.Leave += new System.EventHandler(this.emailMaskedTextBox_Leave);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(8, 276);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(79, 13);
            this.emailLabel.TabIndex = 10;
            this.emailLabel.Text = "E-mail Address:";
            // 
            // creditCardLabel
            // 
            this.creditCardLabel.AutoSize = true;
            this.creditCardLabel.Location = new System.Drawing.Point(8, 228);
            this.creditCardLabel.Name = "creditCardLabel";
            this.creditCardLabel.Size = new System.Drawing.Size(102, 13);
            this.creditCardLabel.TabIndex = 9;
            this.creditCardLabel.Text = "Credit Card Number:";
            // 
            // phoneNumberMaskedTextBox
            // 
            this.phoneNumberMaskedTextBox.AsciiOnly = true;
            this.phoneNumberMaskedTextBox.Location = new System.Drawing.Point(117, 177);
            this.phoneNumberMaskedTextBox.Mask = "(999) 000-0000";
            this.phoneNumberMaskedTextBox.Name = "phoneNumberMaskedTextBox";
            this.phoneNumberMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberMaskedTextBox.TabIndex = 13;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(8, 180);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            this.phoneNumberLabel.TabIndex = 8;
            this.phoneNumberLabel.Text = "Phone Number:";
            // 
            // lastNameMaskedTextBox
            // 
            this.lastNameMaskedTextBox.AsciiOnly = true;
            this.lastNameMaskedTextBox.Location = new System.Drawing.Point(117, 81);
            this.lastNameMaskedTextBox.Name = "lastNameMaskedTextBox";
            this.lastNameMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameMaskedTextBox.TabIndex = 12;
            this.lastNameMaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastNameMaskedTextBox_KeyPress);
            // 
            // homeAddressLabel
            // 
            this.homeAddressLabel.AutoSize = true;
            this.homeAddressLabel.Location = new System.Drawing.Point(8, 132);
            this.homeAddressLabel.Name = "homeAddressLabel";
            this.homeAddressLabel.Size = new System.Drawing.Size(79, 13);
            this.homeAddressLabel.TabIndex = 7;
            this.homeAddressLabel.Text = "Home Address:";
            // 
            // firstNameMaskedTextBox
            // 
            this.firstNameMaskedTextBox.AsciiOnly = true;
            this.firstNameMaskedTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.firstNameMaskedTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.firstNameMaskedTextBox.Location = new System.Drawing.Point(117, 33);
            this.firstNameMaskedTextBox.Name = "firstNameMaskedTextBox";
            this.firstNameMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameMaskedTextBox.TabIndex = 11;
            this.firstNameMaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstNameMaskedTextBox_KeyPress);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(8, 84);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(8, 36);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 5;
            this.firstNameLabel.Text = "First Name:";
            // 
            // homeAddressTextBox
            // 
            this.homeAddressTextBox.Location = new System.Drawing.Point(117, 129);
            this.homeAddressTextBox.Name = "homeAddressTextBox";
            this.homeAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.homeAddressTextBox.TabIndex = 2;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Controls.Add(this.newCustomerButton);
            this.mainPanel.Controls.Add(this.enterButton);
            this.mainPanel.Controls.Add(this.emailSearchTextBox);
            this.mainPanel.Controls.Add(this.newCustomerDescriptionTextBox);
            this.mainPanel.Controls.Add(this.existingCustomerDescriptionTextBox);
            this.mainPanel.Controls.Add(this.newCustomerTextBox);
            this.mainPanel.Controls.Add(this.existingCustomerTextBox);
            this.mainPanel.Location = new System.Drawing.Point(25, 28);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(636, 379);
            this.mainPanel.TabIndex = 8;
            this.mainPanel.TabStop = true;
            // 
            // newCustomerButton
            // 
            this.newCustomerButton.Location = new System.Drawing.Point(459, 293);
            this.newCustomerButton.Name = "newCustomerButton";
            this.newCustomerButton.Size = new System.Drawing.Size(86, 23);
            this.newCustomerButton.TabIndex = 12;
            this.newCustomerButton.TabStop = false;
            this.newCustomerButton.Text = "New Customer";
            this.newCustomerButton.UseVisualStyleBackColor = true;
            this.newCustomerButton.Click += new System.EventHandler(this.newCustomerButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(222, 293);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 11;
            this.enterButton.TabStop = false;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            // 
            // emailSearchTextBox
            // 
            this.emailSearchTextBox.Location = new System.Drawing.Point(30, 295);
            this.emailSearchTextBox.Name = "emailSearchTextBox";
            this.emailSearchTextBox.Size = new System.Drawing.Size(171, 20);
            this.emailSearchTextBox.TabIndex = 10;
            // 
            // newCustomerDescriptionTextBox
            // 
            this.newCustomerDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newCustomerDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCustomerDescriptionTextBox.Location = new System.Drawing.Point(405, 178);
            this.newCustomerDescriptionTextBox.Multiline = true;
            this.newCustomerDescriptionTextBox.Name = "newCustomerDescriptionTextBox";
            this.newCustomerDescriptionTextBox.Size = new System.Drawing.Size(194, 65);
            this.newCustomerDescriptionTextBox.TabIndex = 9;
            this.newCustomerDescriptionTextBox.TabStop = false;
            this.newCustomerDescriptionTextBox.Text = "Setup new customer \r\nreservation account.";
            this.newCustomerDescriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newCustomerDescriptionTextBox.TextChanged += new System.EventHandler(this.newCustomerDescriptionTextBox_TextChanged);
            // 
            // existingCustomerDescriptionTextBox
            // 
            this.existingCustomerDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.existingCustomerDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existingCustomerDescriptionTextBox.Location = new System.Drawing.Point(16, 173);
            this.existingCustomerDescriptionTextBox.Multiline = true;
            this.existingCustomerDescriptionTextBox.Name = "existingCustomerDescriptionTextBox";
            this.existingCustomerDescriptionTextBox.Size = new System.Drawing.Size(309, 77);
            this.existingCustomerDescriptionTextBox.TabIndex = 8;
            this.existingCustomerDescriptionTextBox.TabStop = false;
            this.existingCustomerDescriptionTextBox.Text = "If the customer has an existing reservation account,\r\nenter the e-mail associated" +
    " with it.";
            this.existingCustomerDescriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newCustomerTextBox
            // 
            this.newCustomerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newCustomerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCustomerTextBox.Location = new System.Drawing.Point(391, 94);
            this.newCustomerTextBox.Name = "newCustomerTextBox";
            this.newCustomerTextBox.Size = new System.Drawing.Size(208, 33);
            this.newCustomerTextBox.TabIndex = 7;
            this.newCustomerTextBox.TabStop = false;
            this.newCustomerTextBox.Text = "New Customer";
            this.newCustomerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // existingCustomerTextBox
            // 
            this.existingCustomerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.existingCustomerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existingCustomerTextBox.Location = new System.Drawing.Point(30, 94);
            this.existingCustomerTextBox.Name = "existingCustomerTextBox";
            this.existingCustomerTextBox.Size = new System.Drawing.Size(267, 33);
            this.existingCustomerTextBox.TabIndex = 6;
            this.existingCustomerTextBox.TabStop = false;
            this.existingCustomerTextBox.Text = "Existing Customer";
            this.existingCustomerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newUserPanel
            // 
            this.newUserPanel.BackColor = System.Drawing.Color.Transparent;
            this.newUserPanel.Controls.Add(this.costLabel);
            this.newUserPanel.Controls.Add(this.confirmPurchaseButton);
            this.newUserPanel.Controls.Add(this.finalPricelabel);
            this.newUserPanel.Controls.Add(this.reservationDetailsGroupBox);
            this.newUserPanel.Controls.Add(this.customerInformationGroupBox);
            this.newUserPanel.Location = new System.Drawing.Point(3, 71);
            this.newUserPanel.Name = "newUserPanel";
            this.newUserPanel.Size = new System.Drawing.Size(678, 352);
            this.newUserPanel.TabIndex = 8;
            this.newUserPanel.Visible = false;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(458, 290);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(97, 31);
            this.costLabel.TabIndex = 10;
            this.costLabel.Text = "$00.00";
            // 
            // confirmPurchaseButton
            // 
            this.confirmPurchaseButton.Location = new System.Drawing.Point(582, 289);
            this.confirmPurchaseButton.Name = "confirmPurchaseButton";
            this.confirmPurchaseButton.Size = new System.Drawing.Size(76, 35);
            this.confirmPurchaseButton.TabIndex = 9;
            this.confirmPurchaseButton.Text = "Confirm Purchase";
            this.confirmPurchaseButton.UseVisualStyleBackColor = true;
            this.confirmPurchaseButton.Click += new System.EventHandler(this.confirmPurchaseButton_Click);
            // 
            // finalPricelabel
            // 
            this.finalPricelabel.AutoSize = true;
            this.finalPricelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalPricelabel.Location = new System.Drawing.Point(313, 290);
            this.finalPricelabel.Name = "finalPricelabel";
            this.finalPricelabel.Size = new System.Drawing.Size(157, 31);
            this.finalPricelabel.TabIndex = 8;
            this.finalPricelabel.Text = "Final Price: ";
            // 
            // reservationCompletePanel
            // 
            this.reservationCompletePanel.Controls.Add(this.label1);
            this.reservationCompletePanel.Controls.Add(this.thankYouLabel);
            this.reservationCompletePanel.Location = new System.Drawing.Point(41, 87);
            this.reservationCompletePanel.Name = "reservationCompletePanel";
            this.reservationCompletePanel.Size = new System.Drawing.Size(610, 332);
            this.reservationCompletePanel.TabIndex = 11;
            this.reservationCompletePanel.Visible = false;
            // 
            // thankYouLabel
            // 
            this.thankYouLabel.AutoSize = true;
            this.thankYouLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thankYouLabel.Location = new System.Drawing.Point(80, 47);
            this.thankYouLabel.Name = "thankYouLabel";
            this.thankYouLabel.Size = new System.Drawing.Size(450, 33);
            this.thankYouLabel.TabIndex = 0;
            this.thankYouLabel.Text = "Thank you for your reservation.";
            this.thankYouLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(49, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please check your email to see a copy of \r\nyour receipt and reservation dettails." +
    "";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // vandevenShuttleSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(693, 435);
            this.Controls.Add(this.newUserPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.reservationCompletePanel);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(709, 474);
            this.Name = "vandevenShuttleSystem";
            this.Text = "Vandeven Shuttle System";
            this.Load += new System.EventHandler(this.vandevenShuttleSystem_Load);
            this.reservationDetailsGroupBox.ResumeLayout(false);
            this.reservationDetailsGroupBox.PerformLayout();
            this.customerInformationGroupBox.ResumeLayout(false);
            this.customerInformationGroupBox.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.newUserPanel.ResumeLayout(false);
            this.newUserPanel.PerformLayout();
            this.reservationCompletePanel.ResumeLayout(false);
            this.reservationCompletePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox reservationDetailsGroupBox;
        private System.Windows.Forms.ComboBox passengersComboBox;
        private System.Windows.Forms.Label passengersLabel;
        private System.Windows.Forms.ComboBox destinationComboBox;
        private System.Windows.Forms.DateTimePicker returningDateTimePicker;
        private System.Windows.Forms.Label returningLabel;
        private System.Windows.Forms.DateTimePicker departingDateTimePicker;
        private System.Windows.Forms.ComboBox methodOfReservationComboBox;
        private System.Windows.Forms.Label departingLabel;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label methodOfReservationLabel;
        private System.Windows.Forms.GroupBox customerInformationGroupBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label creditCardLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label homeAddressLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox homeAddressTextBox;
        private System.Windows.Forms.Panel newUserPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TextBox existingCustomerTextBox;
        private System.Windows.Forms.TextBox newCustomerDescriptionTextBox;
        private System.Windows.Forms.TextBox existingCustomerDescriptionTextBox;
        private System.Windows.Forms.TextBox newCustomerTextBox;
        private System.Windows.Forms.TextBox emailSearchTextBox;
        private System.Windows.Forms.Button newCustomerButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button confirmPurchaseButton;
        private System.Windows.Forms.Label finalPricelabel;
        private System.Windows.Forms.MaskedTextBox emailMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox phoneNumberMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox lastNameMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox firstNameMaskedTextBox;
        private System.Windows.Forms.TextBox creditCardNumberTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Panel reservationCompletePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label thankYouLabel;
    }
}

