namespace ShowCustomers
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
            this.buttonGetCustomer = new System.Windows.Forms.Button();
            this.groupBoxEngagement = new System.Windows.Forms.GroupBox();
            this.labelBudgetAccountList = new System.Windows.Forms.Label();
            this.labelCurrentAccountList = new System.Windows.Forms.Label();
            this.listCurrent = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBudget = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpAccounts = new System.Windows.Forms.GroupBox();
            this.grpDebitCredit = new System.Windows.Forms.GroupBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.radioBudgetAccountModify = new System.Windows.Forms.RadioButton();
            this.radioCurrentAccountModify = new System.Windows.Forms.RadioButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelBudgetAccountTotal = new System.Windows.Forms.Label();
            this.labelCurrentAccountTotal = new System.Windows.Forms.Label();
            this.txtBudgetAccount = new System.Windows.Forms.TextBox();
            this.txtCurrentAccount = new System.Windows.Forms.TextBox();
            this.labelBudgetAccount = new System.Windows.Forms.Label();
            this.labelCurrentAccount = new System.Windows.Forms.Label();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.radioBudgetAccount = new System.Windows.Forms.RadioButton();
            this.radioCurrentAccount = new System.Windows.Forms.RadioButton();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.error_Address = new System.Windows.Forms.Label();
            this.error_CPR = new System.Windows.Forms.Label();
            this.error_Name = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCPR = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelCPR = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelNameOrCPR = new System.Windows.Forms.Label();
            this.buttonUpdateCustomer = new System.Windows.Forms.Button();
            this.labelAccountSatus = new System.Windows.Forms.Label();
            this.groupBoxEngagement.SuspendLayout();
            this.grpAccounts.SuspendLayout();
            this.grpDebitCredit.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGetCustomer
            // 
            this.buttonGetCustomer.Location = new System.Drawing.Point(61, 147);
            this.buttonGetCustomer.Name = "buttonGetCustomer";
            this.buttonGetCustomer.Size = new System.Drawing.Size(85, 26);
            this.buttonGetCustomer.TabIndex = 0;
            this.buttonGetCustomer.Text = "Hent";
            this.buttonGetCustomer.UseVisualStyleBackColor = true;
            this.buttonGetCustomer.Click += new System.EventHandler(this.buttonGetCustomer_Click);
            // 
            // groupBoxEngagement
            // 
            this.groupBoxEngagement.Controls.Add(this.labelBudgetAccountList);
            this.groupBoxEngagement.Controls.Add(this.labelCurrentAccountList);
            this.groupBoxEngagement.Controls.Add(this.listCurrent);
            this.groupBoxEngagement.Controls.Add(this.listBudget);
            this.groupBoxEngagement.Controls.Add(this.grpAccounts);
            this.groupBoxEngagement.Controls.Add(this.grpCustomer);
            this.groupBoxEngagement.Location = new System.Drawing.Point(30, 37);
            this.groupBoxEngagement.Name = "groupBoxEngagement";
            this.groupBoxEngagement.Size = new System.Drawing.Size(991, 590);
            this.groupBoxEngagement.TabIndex = 1;
            this.groupBoxEngagement.TabStop = false;
            this.groupBoxEngagement.Text = "Engagement";
            // 
            // labelBudgetAccountList
            // 
            this.labelBudgetAccountList.AutoSize = true;
            this.labelBudgetAccountList.Location = new System.Drawing.Point(804, 16);
            this.labelBudgetAccountList.Name = "labelBudgetAccountList";
            this.labelBudgetAccountList.Size = new System.Drawing.Size(71, 13);
            this.labelBudgetAccountList.TabIndex = 6;
            this.labelBudgetAccountList.Text = "Budget konto";
            // 
            // labelCurrentAccountList
            // 
            this.labelCurrentAccountList.AutoSize = true;
            this.labelCurrentAccountList.Location = new System.Drawing.Point(539, 16);
            this.labelCurrentAccountList.Name = "labelCurrentAccountList";
            this.labelCurrentAccountList.Size = new System.Drawing.Size(52, 13);
            this.labelCurrentAccountList.TabIndex = 5;
            this.labelCurrentAccountList.Text = "Lønkonto";
            // 
            // listCurrent
            // 
            this.listCurrent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listCurrent.Cursor = System.Windows.Forms.Cursors.Default;
            this.listCurrent.Location = new System.Drawing.Point(442, 46);
            this.listCurrent.Name = "listCurrent";
            this.listCurrent.Size = new System.Drawing.Size(261, 503);
            this.listCurrent.TabIndex = 4;
            this.listCurrent.UseCompatibleStateImageBehavior = false;
            this.listCurrent.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Beløb";
            this.columnHeader2.Width = 40;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Total";
            this.columnHeader3.Width = 40;
            // 
            // listBudget
            // 
            this.listBudget.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.Value,
            this.Total});
            this.listBudget.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBudget.Location = new System.Drawing.Point(709, 46);
            this.listBudget.Name = "listBudget";
            this.listBudget.Size = new System.Drawing.Size(268, 503);
            this.listBudget.TabIndex = 3;
            this.listBudget.UseCompatibleStateImageBehavior = false;
            this.listBudget.View = System.Windows.Forms.View.Details;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 30;
            // 
            // Value
            // 
            this.Value.Text = "Beløb";
            this.Value.Width = 30;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            this.Total.Width = 40;
            // 
            // grpAccounts
            // 
            this.grpAccounts.Controls.Add(this.labelAccountSatus);
            this.grpAccounts.Controls.Add(this.grpDebitCredit);
            this.grpAccounts.Controls.Add(this.labelBudgetAccountTotal);
            this.grpAccounts.Controls.Add(this.labelCurrentAccountTotal);
            this.grpAccounts.Controls.Add(this.txtBudgetAccount);
            this.grpAccounts.Controls.Add(this.txtCurrentAccount);
            this.grpAccounts.Controls.Add(this.labelBudgetAccount);
            this.grpAccounts.Controls.Add(this.labelCurrentAccount);
            this.grpAccounts.Location = new System.Drawing.Point(22, 305);
            this.grpAccounts.Name = "grpAccounts";
            this.grpAccounts.Size = new System.Drawing.Size(400, 244);
            this.grpAccounts.TabIndex = 2;
            this.grpAccounts.TabStop = false;
            this.grpAccounts.Text = "Konti";
            // 
            // grpDebitCredit
            // 
            this.grpDebitCredit.Controls.Add(this.buttonInsert);
            this.grpDebitCredit.Controls.Add(this.radioBudgetAccountModify);
            this.grpDebitCredit.Controls.Add(this.radioCurrentAccountModify);
            this.grpDebitCredit.Controls.Add(this.dateTimePicker);
            this.grpDebitCredit.Controls.Add(this.txtAmount);
            this.grpDebitCredit.Controls.Add(this.labelDate);
            this.grpDebitCredit.Controls.Add(this.labelAmount);
            this.grpDebitCredit.Location = new System.Drawing.Point(29, 99);
            this.grpDebitCredit.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.grpDebitCredit.Name = "grpDebitCredit";
            this.grpDebitCredit.Size = new System.Drawing.Size(284, 118);
            this.grpDebitCredit.TabIndex = 6;
            this.grpDebitCredit.TabStop = false;
            this.grpDebitCredit.Text = "Debit/Kredit";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(184, 76);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(93, 27);
            this.buttonInsert.TabIndex = 6;
            this.buttonInsert.Text = "Indsæt";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // radioBudgetAccountModify
            // 
            this.radioBudgetAccountModify.AutoSize = true;
            this.radioBudgetAccountModify.Location = new System.Drawing.Point(184, 53);
            this.radioBudgetAccountModify.Name = "radioBudgetAccountModify";
            this.radioBudgetAccountModify.Size = new System.Drawing.Size(86, 17);
            this.radioBudgetAccountModify.TabIndex = 5;
            this.radioBudgetAccountModify.TabStop = true;
            this.radioBudgetAccountModify.Text = "Budgetkonto";
            this.radioBudgetAccountModify.UseVisualStyleBackColor = true;
            // 
            // radioCurrentAccountModify
            // 
            this.radioCurrentAccountModify.AutoSize = true;
            this.radioCurrentAccountModify.Location = new System.Drawing.Point(185, 26);
            this.radioCurrentAccountModify.Name = "radioCurrentAccountModify";
            this.radioCurrentAccountModify.Size = new System.Drawing.Size(70, 17);
            this.radioCurrentAccountModify.TabIndex = 4;
            this.radioCurrentAccountModify.TabStop = true;
            this.radioCurrentAccountModify.Text = "Lønkonto";
            this.radioCurrentAccountModify.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(75, 49);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker.TabIndex = 3;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(75, 23);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 2;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(19, 49);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(33, 13);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Dato:";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(17, 26);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(37, 13);
            this.labelAmount.TabIndex = 0;
            this.labelAmount.Text = "Beløb:";
            // 
            // labelBudgetAccountTotal
            // 
            this.labelBudgetAccountTotal.AutoSize = true;
            this.labelBudgetAccountTotal.Location = new System.Drawing.Point(264, 68);
            this.labelBudgetAccountTotal.Name = "labelBudgetAccountTotal";
            this.labelBudgetAccountTotal.Size = new System.Drawing.Size(34, 13);
            this.labelBudgetAccountTotal.TabIndex = 5;
            this.labelBudgetAccountTotal.Text = "Total:";
            // 
            // labelCurrentAccountTotal
            // 
            this.labelCurrentAccountTotal.AutoSize = true;
            this.labelCurrentAccountTotal.Location = new System.Drawing.Point(264, 41);
            this.labelCurrentAccountTotal.Name = "labelCurrentAccountTotal";
            this.labelCurrentAccountTotal.Size = new System.Drawing.Size(34, 13);
            this.labelCurrentAccountTotal.TabIndex = 4;
            this.labelCurrentAccountTotal.Text = "Total:";
            // 
            // txtBudgetAccount
            // 
            this.txtBudgetAccount.Location = new System.Drawing.Point(116, 64);
            this.txtBudgetAccount.Name = "txtBudgetAccount";
            this.txtBudgetAccount.ReadOnly = true;
            this.txtBudgetAccount.Size = new System.Drawing.Size(123, 20);
            this.txtBudgetAccount.TabIndex = 3;
            // 
            // txtCurrentAccount
            // 
            this.txtCurrentAccount.Location = new System.Drawing.Point(116, 38);
            this.txtCurrentAccount.Name = "txtCurrentAccount";
            this.txtCurrentAccount.ReadOnly = true;
            this.txtCurrentAccount.Size = new System.Drawing.Size(123, 20);
            this.txtCurrentAccount.TabIndex = 2;
            // 
            // labelBudgetAccount
            // 
            this.labelBudgetAccount.AutoSize = true;
            this.labelBudgetAccount.Location = new System.Drawing.Point(26, 68);
            this.labelBudgetAccount.Name = "labelBudgetAccount";
            this.labelBudgetAccount.Size = new System.Drawing.Size(71, 13);
            this.labelBudgetAccount.TabIndex = 1;
            this.labelBudgetAccount.Text = "Budgetkonto:";
            // 
            // labelCurrentAccount
            // 
            this.labelCurrentAccount.AutoSize = true;
            this.labelCurrentAccount.Location = new System.Drawing.Point(26, 41);
            this.labelCurrentAccount.Name = "labelCurrentAccount";
            this.labelCurrentAccount.Size = new System.Drawing.Size(55, 13);
            this.labelCurrentAccount.TabIndex = 0;
            this.labelCurrentAccount.Text = "Lønkonto:";
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.buttonLogOut);
            this.grpCustomer.Controls.Add(this.radioBudgetAccount);
            this.grpCustomer.Controls.Add(this.radioCurrentAccount);
            this.grpCustomer.Controls.Add(this.buttonCreateAccount);
            this.grpCustomer.Controls.Add(this.error_Address);
            this.grpCustomer.Controls.Add(this.error_CPR);
            this.grpCustomer.Controls.Add(this.error_Name);
            this.grpCustomer.Controls.Add(this.txtAddress);
            this.grpCustomer.Controls.Add(this.txtCPR);
            this.grpCustomer.Controls.Add(this.txtName);
            this.grpCustomer.Controls.Add(this.labelAddress);
            this.grpCustomer.Controls.Add(this.labelCPR);
            this.grpCustomer.Controls.Add(this.labelName);
            this.grpCustomer.Controls.Add(this.labelNameOrCPR);
            this.grpCustomer.Controls.Add(this.buttonUpdateCustomer);
            this.grpCustomer.Controls.Add(this.buttonGetCustomer);
            this.grpCustomer.Location = new System.Drawing.Point(22, 46);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(400, 253);
            this.grpCustomer.TabIndex = 1;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Kunde";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(296, 205);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(84, 26);
            this.buttonLogOut.TabIndex = 15;
            this.buttonLogOut.Text = "Log ud";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // radioBudgetAccount
            // 
            this.radioBudgetAccount.AutoSize = true;
            this.radioBudgetAccount.Location = new System.Drawing.Point(169, 214);
            this.radioBudgetAccount.Name = "radioBudgetAccount";
            this.radioBudgetAccount.Size = new System.Drawing.Size(86, 17);
            this.radioBudgetAccount.TabIndex = 14;
            this.radioBudgetAccount.TabStop = true;
            this.radioBudgetAccount.Text = "Budgetkonto";
            this.radioBudgetAccount.UseVisualStyleBackColor = true;
            // 
            // radioCurrentAccount
            // 
            this.radioCurrentAccount.AutoSize = true;
            this.radioCurrentAccount.Location = new System.Drawing.Point(169, 191);
            this.radioCurrentAccount.Name = "radioCurrentAccount";
            this.radioCurrentAccount.Size = new System.Drawing.Size(70, 17);
            this.radioCurrentAccount.TabIndex = 13;
            this.radioCurrentAccount.TabStop = true;
            this.radioCurrentAccount.Text = "Lønkonto";
            this.radioCurrentAccount.UseVisualStyleBackColor = true;
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.Location = new System.Drawing.Point(61, 205);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(85, 26);
            this.buttonCreateAccount.TabIndex = 12;
            this.buttonCreateAccount.Text = "Opret konto";
            this.buttonCreateAccount.UseVisualStyleBackColor = true;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // error_Address
            // 
            this.error_Address.AutoSize = true;
            this.error_Address.ForeColor = System.Drawing.Color.Black;
            this.error_Address.Location = new System.Drawing.Point(253, 114);
            this.error_Address.MaximumSize = new System.Drawing.Size(140, 0);
            this.error_Address.Name = "error_Address";
            this.error_Address.Size = new System.Drawing.Size(80, 13);
            this.error_Address.TabIndex = 11;
            this.error_Address.Text = "Indtast Adresse";
            // 
            // error_CPR
            // 
            this.error_CPR.AutoSize = true;
            this.error_CPR.ForeColor = System.Drawing.Color.Black;
            this.error_CPR.Location = new System.Drawing.Point(253, 86);
            this.error_CPR.MaximumSize = new System.Drawing.Size(120, 0);
            this.error_CPR.Name = "error_CPR";
            this.error_CPR.Size = new System.Drawing.Size(104, 13);
            this.error_CPR.TabIndex = 10;
            this.error_CPR.Text = "Indtast CPR-nummer";
            // 
            // error_Name
            // 
            this.error_Name.AutoSize = true;
            this.error_Name.ForeColor = System.Drawing.Color.Black;
            this.error_Name.Location = new System.Drawing.Point(253, 25);
            this.error_Name.MaximumSize = new System.Drawing.Size(140, 0);
            this.error_Name.Name = "error_Name";
            this.error_Name.Size = new System.Drawing.Size(68, 13);
            this.error_Name.TabIndex = 9;
            this.error_Name.Text = "Indtast Navn";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(61, 111);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(178, 20);
            this.txtAddress.TabIndex = 8;
            this.txtAddress.TextChanged += new System.EventHandler(this.OnTextChange_TextChanged);
            // 
            // txtCPR
            // 
            this.txtCPR.Location = new System.Drawing.Point(61, 86);
            this.txtCPR.MaxLength = 10;
            this.txtCPR.Name = "txtCPR";
            this.txtCPR.Size = new System.Drawing.Size(178, 20);
            this.txtCPR.TabIndex = 7;
            this.txtCPR.TextChanged += new System.EventHandler(this.OnTextChange_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(61, 60);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 20);
            this.txtName.TabIndex = 6;
            this.txtName.TextChanged += new System.EventHandler(this.OnTextChange_TextChanged);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(7, 111);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(48, 13);
            this.labelAddress.TabIndex = 5;
            this.labelAddress.Text = "Adresse:";
            // 
            // labelCPR
            // 
            this.labelCPR.AutoSize = true;
            this.labelCPR.Location = new System.Drawing.Point(7, 86);
            this.labelCPR.Name = "labelCPR";
            this.labelCPR.Size = new System.Drawing.Size(46, 13);
            this.labelCPR.TabIndex = 4;
            this.labelCPR.Text = "CPR Nr.";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(7, 63);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(36, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Navn:";
            // 
            // labelNameOrCPR
            // 
            this.labelNameOrCPR.AutoSize = true;
            this.labelNameOrCPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameOrCPR.Location = new System.Drawing.Point(7, 21);
            this.labelNameOrCPR.MaximumSize = new System.Drawing.Size(250, 0);
            this.labelNameOrCPR.Name = "labelNameOrCPR";
            this.labelNameOrCPR.Size = new System.Drawing.Size(136, 13);
            this.labelNameOrCPR.TabIndex = 2;
            this.labelNameOrCPR.Text = "Indtast enten cpr eller navn";
            // 
            // buttonUpdateCustomer
            // 
            this.buttonUpdateCustomer.Location = new System.Drawing.Point(152, 147);
            this.buttonUpdateCustomer.Name = "buttonUpdateCustomer";
            this.buttonUpdateCustomer.Size = new System.Drawing.Size(87, 26);
            this.buttonUpdateCustomer.TabIndex = 1;
            this.buttonUpdateCustomer.Text = "Opret/Opdater";
            this.buttonUpdateCustomer.UseVisualStyleBackColor = true;
            this.buttonUpdateCustomer.Click += new System.EventHandler(this.buttonUpdateCustomer_Click);
            // 
            // labelAccountSatus
            // 
            this.labelAccountSatus.AutoSize = true;
            this.labelAccountSatus.Location = new System.Drawing.Point(113, 16);
            this.labelAccountSatus.Name = "labelAccountSatus";
            this.labelAccountSatus.Size = new System.Drawing.Size(69, 13);
            this.labelAccountSatus.TabIndex = 7;
            this.labelAccountSatus.Text = "Konto status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 630);
            this.Controls.Add(this.groupBoxEngagement);
            this.Name = "Form1";
            this.Text = "Lillebank A/S";
            this.groupBoxEngagement.ResumeLayout(false);
            this.groupBoxEngagement.PerformLayout();
            this.grpAccounts.ResumeLayout(false);
            this.grpAccounts.PerformLayout();
            this.grpDebitCredit.ResumeLayout(false);
            this.grpDebitCredit.PerformLayout();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGetCustomer;
        private System.Windows.Forms.GroupBox groupBoxEngagement;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCPR;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelCPR;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNameOrCPR;
        private System.Windows.Forms.Button buttonUpdateCustomer;
        private System.Windows.Forms.Label error_Address;
        private System.Windows.Forms.Label error_CPR;
        private System.Windows.Forms.Label error_Name;
        private System.Windows.Forms.GroupBox grpAccounts;
        private System.Windows.Forms.Label labelBudgetAccountTotal;
        private System.Windows.Forms.Label labelCurrentAccountTotal;
        private System.Windows.Forms.TextBox txtBudgetAccount;
        private System.Windows.Forms.TextBox txtCurrentAccount;
        private System.Windows.Forms.Label labelBudgetAccount;
        private System.Windows.Forms.Label labelCurrentAccount;
        private System.Windows.Forms.RadioButton radioBudgetAccount;
        private System.Windows.Forms.RadioButton radioCurrentAccount;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.GroupBox grpDebitCredit;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.RadioButton radioBudgetAccountModify;
        private System.Windows.Forms.RadioButton radioCurrentAccountModify;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.ListView listBudget;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.ListView listCurrent;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label labelBudgetAccountList;
        private System.Windows.Forms.Label labelCurrentAccountList;
        private System.Windows.Forms.Label labelAccountSatus;
    }
}

