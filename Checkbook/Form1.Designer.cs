namespace Checkbook
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
            this.buttonLedgerAdd = new System.Windows.Forms.Button();
            this.buttonLedgerSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelLedgerAmount = new System.Windows.Forms.Label();
            this.textBoxLedgerAmount = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelLedgerChooseCategory = new System.Windows.Forms.Label();
            this.comboBoxLedgerCategoryList = new System.Windows.Forms.ComboBox();
            this.labelLedgerChooseContact = new System.Windows.Forms.Label();
            this.comboBoxLedgerContactList = new System.Windows.Forms.ComboBox();
            this.buttonLedgerDelete = new System.Windows.Forms.Button();
            this.textBoxLedgerCheckNumber = new System.Windows.Forms.TextBox();
            this.textBoxLedgerInvoiceNumber = new System.Windows.Forms.TextBox();
            this.textBoxLedgerMemo = new System.Windows.Forms.TextBox();
            this.labelLedgerCheckNumber = new System.Windows.Forms.Label();
            this.labelLedgerInvoiceNumber = new System.Windows.Forms.Label();
            this.labelLedgerMemo = new System.Windows.Forms.Label();
            this.buttonLedgersRefresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLedger = new System.Windows.Forms.TabPage();
            this.labelLedgerBalanceAmount = new System.Windows.Forms.Label();
            this.labelLedgerBalance = new System.Windows.Forms.Label();
            this.tabPageContacts = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonContactsRefresh = new System.Windows.Forms.Button();
            this.buttonContactsDelete = new System.Windows.Forms.Button();
            this.textBoxContactsLastName = new System.Windows.Forms.TextBox();
            this.textBoxContactsAddressOne = new System.Windows.Forms.TextBox();
            this.textBoxContactsAddressTwo = new System.Windows.Forms.TextBox();
            this.textBoxContactsCity = new System.Windows.Forms.TextBox();
            this.textBoxContactsState = new System.Windows.Forms.TextBox();
            this.textBoxContactsZip = new System.Windows.Forms.TextBox();
            this.textBoxContactsPhone = new System.Windows.Forms.TextBox();
            this.textBoxContactsCompany = new System.Windows.Forms.TextBox();
            this.labelContactsLastName = new System.Windows.Forms.Label();
            this.labelContactsAddressOne = new System.Windows.Forms.Label();
            this.labelContactsAddressTwo = new System.Windows.Forms.Label();
            this.labelContactsCity = new System.Windows.Forms.Label();
            this.labelContactsZip = new System.Windows.Forms.Label();
            this.labelContactsCompany = new System.Windows.Forms.Label();
            this.labelContactsState = new System.Windows.Forms.Label();
            this.labelContactsPhone = new System.Windows.Forms.Label();
            this.buttonContactsAdd = new System.Windows.Forms.Button();
            this.textboxContactsFirstName = new System.Windows.Forms.TextBox();
            this.buttonContactsSave = new System.Windows.Forms.Button();
            this.labelContactsFirstName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datagridContacts = new System.Windows.Forms.DataGridView();
            this.tabPageCategories = new System.Windows.Forms.TabPage();
            this.datagridCategories = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonCategoriesDelete = new System.Windows.Forms.Button();
            this.buttonCategoriesRefresh = new System.Windows.Forms.Button();
            this.buttonCategoriesSave = new System.Windows.Forms.Button();
            this.buttonCategoriesAdd = new System.Windows.Forms.Button();
            this.labelCategoriesName = new System.Windows.Forms.Label();
            this.textBoxCategoriesName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageLedger.SuspendLayout();
            this.tabPageContacts.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridContacts)).BeginInit();
            this.tabPageCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridCategories)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLedgerAdd
            // 
            this.buttonLedgerAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonLedgerAdd.Location = new System.Drawing.Point(951, 14);
            this.buttonLedgerAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLedgerAdd.Name = "buttonLedgerAdd";
            this.buttonLedgerAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonLedgerAdd.TabIndex = 0;
            this.buttonLedgerAdd.Text = "Add";
            this.buttonLedgerAdd.UseVisualStyleBackColor = true;
            this.buttonLedgerAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLedgerSave
            // 
            this.buttonLedgerSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonLedgerSave.Location = new System.Drawing.Point(951, 98);
            this.buttonLedgerSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLedgerSave.Name = "buttonLedgerSave";
            this.buttonLedgerSave.Size = new System.Drawing.Size(100, 28);
            this.buttonLedgerSave.TabIndex = 1;
            this.buttonLedgerSave.Text = "Save";
            this.buttonLedgerSave.UseVisualStyleBackColor = true;
            this.buttonLedgerSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 229);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1061, 523);
            this.dataGridView1.TabIndex = 2;
            // 
            // labelLedgerAmount
            // 
            this.labelLedgerAmount.AutoSize = true;
            this.labelLedgerAmount.Location = new System.Drawing.Point(16, 25);
            this.labelLedgerAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLedgerAmount.Name = "labelLedgerAmount";
            this.labelLedgerAmount.Size = new System.Drawing.Size(56, 17);
            this.labelLedgerAmount.TabIndex = 3;
            this.labelLedgerAmount.Text = "Amount";
            // 
            // textBoxLedgerAmount
            // 
            this.textBoxLedgerAmount.Location = new System.Drawing.Point(19, 46);
            this.textBoxLedgerAmount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLedgerAmount.Name = "textBoxLedgerAmount";
            this.textBoxLedgerAmount.Size = new System.Drawing.Size(132, 22);
            this.textBoxLedgerAmount.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelLedgerChooseCategory);
            this.groupBox1.Controls.Add(this.comboBoxLedgerCategoryList);
            this.groupBox1.Controls.Add(this.labelLedgerChooseContact);
            this.groupBox1.Controls.Add(this.comboBoxLedgerContactList);
            this.groupBox1.Controls.Add(this.buttonLedgerDelete);
            this.groupBox1.Controls.Add(this.textBoxLedgerCheckNumber);
            this.groupBox1.Controls.Add(this.textBoxLedgerInvoiceNumber);
            this.groupBox1.Controls.Add(this.textBoxLedgerMemo);
            this.groupBox1.Controls.Add(this.labelLedgerCheckNumber);
            this.groupBox1.Controls.Add(this.labelLedgerInvoiceNumber);
            this.groupBox1.Controls.Add(this.labelLedgerMemo);
            this.groupBox1.Controls.Add(this.buttonLedgerAdd);
            this.groupBox1.Controls.Add(this.buttonLedgersRefresh);
            this.groupBox1.Controls.Add(this.textBoxLedgerAmount);
            this.groupBox1.Controls.Add(this.buttonLedgerSave);
            this.groupBox1.Controls.Add(this.labelLedgerAmount);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1059, 178);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ledgers";
            // 
            // labelLedgerChooseCategory
            // 
            this.labelLedgerChooseCategory.AutoSize = true;
            this.labelLedgerChooseCategory.Location = new System.Drawing.Point(355, 98);
            this.labelLedgerChooseCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLedgerChooseCategory.Name = "labelLedgerChooseCategory";
            this.labelLedgerChooseCategory.Size = new System.Drawing.Size(117, 17);
            this.labelLedgerChooseCategory.TabIndex = 43;
            this.labelLedgerChooseCategory.Text = "Choose Category";
            // 
            // comboBoxLedgerCategoryList
            // 
            this.comboBoxLedgerCategoryList.FormattingEnabled = true;
            this.comboBoxLedgerCategoryList.Location = new System.Drawing.Point(358, 119);
            this.comboBoxLedgerCategoryList.Name = "comboBoxLedgerCategoryList";
            this.comboBoxLedgerCategoryList.Size = new System.Drawing.Size(121, 24);
            this.comboBoxLedgerCategoryList.TabIndex = 42;
            // 
            // labelLedgerChooseContact
            // 
            this.labelLedgerChooseContact.AutoSize = true;
            this.labelLedgerChooseContact.Location = new System.Drawing.Point(355, 25);
            this.labelLedgerChooseContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLedgerChooseContact.Name = "labelLedgerChooseContact";
            this.labelLedgerChooseContact.Size = new System.Drawing.Size(108, 17);
            this.labelLedgerChooseContact.TabIndex = 41;
            this.labelLedgerChooseContact.Text = "Choose Contact";
            // 
            // comboBoxLedgerContactList
            // 
            this.comboBoxLedgerContactList.FormattingEnabled = true;
            this.comboBoxLedgerContactList.Location = new System.Drawing.Point(358, 46);
            this.comboBoxLedgerContactList.Name = "comboBoxLedgerContactList";
            this.comboBoxLedgerContactList.Size = new System.Drawing.Size(121, 24);
            this.comboBoxLedgerContactList.TabIndex = 40;
            // 
            // buttonLedgerDelete
            // 
            this.buttonLedgerDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonLedgerDelete.Location = new System.Drawing.Point(951, 56);
            this.buttonLedgerDelete.Name = "buttonLedgerDelete";
            this.buttonLedgerDelete.Size = new System.Drawing.Size(100, 28);
            this.buttonLedgerDelete.TabIndex = 39;
            this.buttonLedgerDelete.Text = "Delete";
            this.buttonLedgerDelete.UseVisualStyleBackColor = true;
            this.buttonLedgerDelete.Click += new System.EventHandler(this.buttonLedgerDelete_Click);
            // 
            // textBoxLedgerCheckNumber
            // 
            this.textBoxLedgerCheckNumber.Location = new System.Drawing.Point(184, 46);
            this.textBoxLedgerCheckNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLedgerCheckNumber.MaxLength = 6;
            this.textBoxLedgerCheckNumber.Name = "textBoxLedgerCheckNumber";
            this.textBoxLedgerCheckNumber.Size = new System.Drawing.Size(132, 22);
            this.textBoxLedgerCheckNumber.TabIndex = 36;
            // 
            // textBoxLedgerInvoiceNumber
            // 
            this.textBoxLedgerInvoiceNumber.Location = new System.Drawing.Point(184, 116);
            this.textBoxLedgerInvoiceNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLedgerInvoiceNumber.MaxLength = 50;
            this.textBoxLedgerInvoiceNumber.Name = "textBoxLedgerInvoiceNumber";
            this.textBoxLedgerInvoiceNumber.Size = new System.Drawing.Size(132, 22);
            this.textBoxLedgerInvoiceNumber.TabIndex = 34;
            // 
            // textBoxLedgerMemo
            // 
            this.textBoxLedgerMemo.Location = new System.Drawing.Point(19, 117);
            this.textBoxLedgerMemo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLedgerMemo.Name = "textBoxLedgerMemo";
            this.textBoxLedgerMemo.Size = new System.Drawing.Size(132, 22);
            this.textBoxLedgerMemo.TabIndex = 32;
            // 
            // labelLedgerCheckNumber
            // 
            this.labelLedgerCheckNumber.AutoSize = true;
            this.labelLedgerCheckNumber.Location = new System.Drawing.Point(181, 25);
            this.labelLedgerCheckNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLedgerCheckNumber.Name = "labelLedgerCheckNumber";
            this.labelLedgerCheckNumber.Size = new System.Drawing.Size(101, 17);
            this.labelLedgerCheckNumber.TabIndex = 29;
            this.labelLedgerCheckNumber.Text = "Check Number";
            // 
            // labelLedgerInvoiceNumber
            // 
            this.labelLedgerInvoiceNumber.AutoSize = true;
            this.labelLedgerInvoiceNumber.Location = new System.Drawing.Point(181, 96);
            this.labelLedgerInvoiceNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLedgerInvoiceNumber.Name = "labelLedgerInvoiceNumber";
            this.labelLedgerInvoiceNumber.Size = new System.Drawing.Size(106, 17);
            this.labelLedgerInvoiceNumber.TabIndex = 27;
            this.labelLedgerInvoiceNumber.Text = "Invoice Number";
            // 
            // labelLedgerMemo
            // 
            this.labelLedgerMemo.AutoSize = true;
            this.labelLedgerMemo.Location = new System.Drawing.Point(16, 96);
            this.labelLedgerMemo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLedgerMemo.Name = "labelLedgerMemo";
            this.labelLedgerMemo.Size = new System.Drawing.Size(46, 17);
            this.labelLedgerMemo.TabIndex = 26;
            this.labelLedgerMemo.Text = "Memo";
            // 
            // buttonLedgersRefresh
            // 
            this.buttonLedgersRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonLedgersRefresh.Location = new System.Drawing.Point(951, 140);
            this.buttonLedgersRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLedgersRefresh.Name = "buttonLedgersRefresh";
            this.buttonLedgersRefresh.Size = new System.Drawing.Size(100, 28);
            this.buttonLedgersRefresh.TabIndex = 10;
            this.buttonLedgersRefresh.Text = "Refresh";
            this.buttonLedgersRefresh.UseVisualStyleBackColor = true;
            this.buttonLedgersRefresh.Click += new System.EventHandler(this.buttonLedgersRefresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ledgers";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageLedger);
            this.tabControl1.Controls.Add(this.tabPageContacts);
            this.tabControl1.Controls.Add(this.tabPageCategories);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1081, 788);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPageLedger
            // 
            this.tabPageLedger.Controls.Add(this.labelLedgerBalanceAmount);
            this.tabPageLedger.Controls.Add(this.labelLedgerBalance);
            this.tabPageLedger.Controls.Add(this.groupBox1);
            this.tabPageLedger.Controls.Add(this.label3);
            this.tabPageLedger.Controls.Add(this.dataGridView1);
            this.tabPageLedger.Location = new System.Drawing.Point(4, 25);
            this.tabPageLedger.Name = "tabPageLedger";
            this.tabPageLedger.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLedger.Size = new System.Drawing.Size(1073, 759);
            this.tabPageLedger.TabIndex = 0;
            this.tabPageLedger.Text = "Ledger";
            this.tabPageLedger.UseVisualStyleBackColor = true;
            // 
            // labelLedgerBalanceAmount
            // 
            this.labelLedgerBalanceAmount.AutoSize = true;
            this.labelLedgerBalanceAmount.Location = new System.Drawing.Point(835, 193);
            this.labelLedgerBalanceAmount.Name = "labelLedgerBalanceAmount";
            this.labelLedgerBalanceAmount.Size = new System.Drawing.Size(0, 17);
            this.labelLedgerBalanceAmount.TabIndex = 9;
            // 
            // labelLedgerBalance
            // 
            this.labelLedgerBalance.AutoSize = true;
            this.labelLedgerBalance.Location = new System.Drawing.Point(765, 193);
            this.labelLedgerBalance.Name = "labelLedgerBalance";
            this.labelLedgerBalance.Size = new System.Drawing.Size(63, 17);
            this.labelLedgerBalance.TabIndex = 8;
            this.labelLedgerBalance.Text = "Balance:";
            // 
            // tabPageContacts
            // 
            this.tabPageContacts.Controls.Add(this.groupBox2);
            this.tabPageContacts.Controls.Add(this.label4);
            this.tabPageContacts.Controls.Add(this.datagridContacts);
            this.tabPageContacts.Location = new System.Drawing.Point(4, 25);
            this.tabPageContacts.Name = "tabPageContacts";
            this.tabPageContacts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageContacts.Size = new System.Drawing.Size(1073, 759);
            this.tabPageContacts.TabIndex = 1;
            this.tabPageContacts.Text = "Contacts";
            this.tabPageContacts.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonContactsRefresh);
            this.groupBox2.Controls.Add(this.buttonContactsDelete);
            this.groupBox2.Controls.Add(this.textBoxContactsLastName);
            this.groupBox2.Controls.Add(this.textBoxContactsAddressOne);
            this.groupBox2.Controls.Add(this.textBoxContactsAddressTwo);
            this.groupBox2.Controls.Add(this.textBoxContactsCity);
            this.groupBox2.Controls.Add(this.textBoxContactsState);
            this.groupBox2.Controls.Add(this.textBoxContactsZip);
            this.groupBox2.Controls.Add(this.textBoxContactsPhone);
            this.groupBox2.Controls.Add(this.textBoxContactsCompany);
            this.groupBox2.Controls.Add(this.labelContactsLastName);
            this.groupBox2.Controls.Add(this.labelContactsAddressOne);
            this.groupBox2.Controls.Add(this.labelContactsAddressTwo);
            this.groupBox2.Controls.Add(this.labelContactsCity);
            this.groupBox2.Controls.Add(this.labelContactsZip);
            this.groupBox2.Controls.Add(this.labelContactsCompany);
            this.groupBox2.Controls.Add(this.labelContactsState);
            this.groupBox2.Controls.Add(this.labelContactsPhone);
            this.groupBox2.Controls.Add(this.buttonContactsAdd);
            this.groupBox2.Controls.Add(this.textboxContactsFirstName);
            this.groupBox2.Controls.Add(this.buttonContactsSave);
            this.groupBox2.Controls.Add(this.labelContactsFirstName);
            this.groupBox2.Location = new System.Drawing.Point(7, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1076, 152);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contacts";
            // 
            // buttonContactsRefresh
            // 
            this.buttonContactsRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonContactsRefresh.Location = new System.Drawing.Point(959, 116);
            this.buttonContactsRefresh.Name = "buttonContactsRefresh";
            this.buttonContactsRefresh.Size = new System.Drawing.Size(100, 28);
            this.buttonContactsRefresh.TabIndex = 23;
            this.buttonContactsRefresh.Text = "Refresh";
            this.buttonContactsRefresh.UseVisualStyleBackColor = true;
            this.buttonContactsRefresh.Click += new System.EventHandler(this.buttonContactsRefresh_Click);
            // 
            // buttonContactsDelete
            // 
            this.buttonContactsDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonContactsDelete.Location = new System.Drawing.Point(959, 48);
            this.buttonContactsDelete.Name = "buttonContactsDelete";
            this.buttonContactsDelete.Size = new System.Drawing.Size(100, 28);
            this.buttonContactsDelete.TabIndex = 22;
            this.buttonContactsDelete.Text = "Delete";
            this.buttonContactsDelete.UseVisualStyleBackColor = true;
            this.buttonContactsDelete.Click += new System.EventHandler(this.buttonContactsDelete_Click);
            // 
            // textBoxContactsLastName
            // 
            this.textBoxContactsLastName.Location = new System.Drawing.Point(11, 109);
            this.textBoxContactsLastName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxContactsLastName.Name = "textBoxContactsLastName";
            this.textBoxContactsLastName.Size = new System.Drawing.Size(132, 22);
            this.textBoxContactsLastName.TabIndex = 21;
            // 
            // textBoxContactsAddressOne
            // 
            this.textBoxContactsAddressOne.Location = new System.Drawing.Point(176, 40);
            this.textBoxContactsAddressOne.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxContactsAddressOne.Name = "textBoxContactsAddressOne";
            this.textBoxContactsAddressOne.Size = new System.Drawing.Size(132, 22);
            this.textBoxContactsAddressOne.TabIndex = 20;
            // 
            // textBoxContactsAddressTwo
            // 
            this.textBoxContactsAddressTwo.Location = new System.Drawing.Point(176, 109);
            this.textBoxContactsAddressTwo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxContactsAddressTwo.Name = "textBoxContactsAddressTwo";
            this.textBoxContactsAddressTwo.Size = new System.Drawing.Size(132, 22);
            this.textBoxContactsAddressTwo.TabIndex = 19;
            // 
            // textBoxContactsCity
            // 
            this.textBoxContactsCity.Location = new System.Drawing.Point(345, 40);
            this.textBoxContactsCity.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxContactsCity.Name = "textBoxContactsCity";
            this.textBoxContactsCity.Size = new System.Drawing.Size(132, 22);
            this.textBoxContactsCity.TabIndex = 18;
            // 
            // textBoxContactsState
            // 
            this.textBoxContactsState.Location = new System.Drawing.Point(345, 109);
            this.textBoxContactsState.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxContactsState.Name = "textBoxContactsState";
            this.textBoxContactsState.Size = new System.Drawing.Size(132, 22);
            this.textBoxContactsState.TabIndex = 17;
            // 
            // textBoxContactsZip
            // 
            this.textBoxContactsZip.Location = new System.Drawing.Point(541, 40);
            this.textBoxContactsZip.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxContactsZip.Name = "textBoxContactsZip";
            this.textBoxContactsZip.Size = new System.Drawing.Size(132, 22);
            this.textBoxContactsZip.TabIndex = 16;
            // 
            // textBoxContactsPhone
            // 
            this.textBoxContactsPhone.Location = new System.Drawing.Point(541, 114);
            this.textBoxContactsPhone.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxContactsPhone.Name = "textBoxContactsPhone";
            this.textBoxContactsPhone.Size = new System.Drawing.Size(132, 22);
            this.textBoxContactsPhone.TabIndex = 15;
            // 
            // textBoxContactsCompany
            // 
            this.textBoxContactsCompany.Location = new System.Drawing.Point(729, 40);
            this.textBoxContactsCompany.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxContactsCompany.MaxLength = 50;
            this.textBoxContactsCompany.Name = "textBoxContactsCompany";
            this.textBoxContactsCompany.Size = new System.Drawing.Size(132, 22);
            this.textBoxContactsCompany.TabIndex = 14;
            // 
            // labelContactsLastName
            // 
            this.labelContactsLastName.AutoSize = true;
            this.labelContactsLastName.Location = new System.Drawing.Point(8, 88);
            this.labelContactsLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContactsLastName.Name = "labelContactsLastName";
            this.labelContactsLastName.Size = new System.Drawing.Size(76, 17);
            this.labelContactsLastName.TabIndex = 13;
            this.labelContactsLastName.Text = "Last Name";
            // 
            // labelContactsAddressOne
            // 
            this.labelContactsAddressOne.AutoSize = true;
            this.labelContactsAddressOne.Location = new System.Drawing.Point(173, 19);
            this.labelContactsAddressOne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContactsAddressOne.Name = "labelContactsAddressOne";
            this.labelContactsAddressOne.Size = new System.Drawing.Size(72, 17);
            this.labelContactsAddressOne.TabIndex = 12;
            this.labelContactsAddressOne.Text = "Address 1";
            // 
            // labelContactsAddressTwo
            // 
            this.labelContactsAddressTwo.AutoSize = true;
            this.labelContactsAddressTwo.Location = new System.Drawing.Point(173, 88);
            this.labelContactsAddressTwo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContactsAddressTwo.Name = "labelContactsAddressTwo";
            this.labelContactsAddressTwo.Size = new System.Drawing.Size(72, 17);
            this.labelContactsAddressTwo.TabIndex = 11;
            this.labelContactsAddressTwo.Text = "Address 2";
            // 
            // labelContactsCity
            // 
            this.labelContactsCity.AutoSize = true;
            this.labelContactsCity.Location = new System.Drawing.Point(342, 20);
            this.labelContactsCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContactsCity.Name = "labelContactsCity";
            this.labelContactsCity.Size = new System.Drawing.Size(31, 17);
            this.labelContactsCity.TabIndex = 10;
            this.labelContactsCity.Text = "City";
            // 
            // labelContactsZip
            // 
            this.labelContactsZip.AutoSize = true;
            this.labelContactsZip.Location = new System.Drawing.Point(538, 19);
            this.labelContactsZip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContactsZip.Name = "labelContactsZip";
            this.labelContactsZip.Size = new System.Drawing.Size(65, 17);
            this.labelContactsZip.TabIndex = 9;
            this.labelContactsZip.Text = "Zip Code";
            // 
            // labelContactsCompany
            // 
            this.labelContactsCompany.AutoSize = true;
            this.labelContactsCompany.Location = new System.Drawing.Point(726, 19);
            this.labelContactsCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContactsCompany.Name = "labelContactsCompany";
            this.labelContactsCompany.Size = new System.Drawing.Size(67, 17);
            this.labelContactsCompany.TabIndex = 8;
            this.labelContactsCompany.Text = "Company";
            // 
            // labelContactsState
            // 
            this.labelContactsState.AutoSize = true;
            this.labelContactsState.Location = new System.Drawing.Point(342, 88);
            this.labelContactsState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContactsState.Name = "labelContactsState";
            this.labelContactsState.Size = new System.Drawing.Size(41, 17);
            this.labelContactsState.TabIndex = 7;
            this.labelContactsState.Text = "State";
            // 
            // labelContactsPhone
            // 
            this.labelContactsPhone.AutoSize = true;
            this.labelContactsPhone.Location = new System.Drawing.Point(538, 93);
            this.labelContactsPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContactsPhone.Name = "labelContactsPhone";
            this.labelContactsPhone.Size = new System.Drawing.Size(103, 17);
            this.labelContactsPhone.TabIndex = 6;
            this.labelContactsPhone.Text = "Phone Number";
            // 
            // buttonContactsAdd
            // 
            this.buttonContactsAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonContactsAdd.Location = new System.Drawing.Point(959, 14);
            this.buttonContactsAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonContactsAdd.Name = "buttonContactsAdd";
            this.buttonContactsAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonContactsAdd.TabIndex = 0;
            this.buttonContactsAdd.Text = "Add";
            this.buttonContactsAdd.UseVisualStyleBackColor = true;
            this.buttonContactsAdd.Click += new System.EventHandler(this.buttonContactsAdd_Click);
            // 
            // textboxContactsFirstName
            // 
            this.textboxContactsFirstName.Location = new System.Drawing.Point(11, 40);
            this.textboxContactsFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.textboxContactsFirstName.MaxLength = 50;
            this.textboxContactsFirstName.Name = "textboxContactsFirstName";
            this.textboxContactsFirstName.Size = new System.Drawing.Size(132, 22);
            this.textboxContactsFirstName.TabIndex = 4;
            // 
            // buttonContactsSave
            // 
            this.buttonContactsSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonContactsSave.Location = new System.Drawing.Point(959, 82);
            this.buttonContactsSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonContactsSave.Name = "buttonContactsSave";
            this.buttonContactsSave.Size = new System.Drawing.Size(100, 28);
            this.buttonContactsSave.TabIndex = 1;
            this.buttonContactsSave.Text = "Save";
            this.buttonContactsSave.UseVisualStyleBackColor = true;
            this.buttonContactsSave.Click += new System.EventHandler(this.buttonContactsSave_Click);
            // 
            // labelContactsFirstName
            // 
            this.labelContactsFirstName.AutoSize = true;
            this.labelContactsFirstName.Location = new System.Drawing.Point(8, 19);
            this.labelContactsFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContactsFirstName.Name = "labelContactsFirstName";
            this.labelContactsFirstName.Size = new System.Drawing.Size(76, 17);
            this.labelContactsFirstName.TabIndex = 3;
            this.labelContactsFirstName.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Contacts";
            // 
            // datagridContacts
            // 
            this.datagridContacts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.datagridContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridContacts.Location = new System.Drawing.Point(7, 193);
            this.datagridContacts.Margin = new System.Windows.Forms.Padding(4);
            this.datagridContacts.Name = "datagridContacts";
            this.datagridContacts.Size = new System.Drawing.Size(1059, 559);
            this.datagridContacts.TabIndex = 14;
            // 
            // tabPageCategories
            // 
            this.tabPageCategories.Controls.Add(this.datagridCategories);
            this.tabPageCategories.Controls.Add(this.groupBox3);
            this.tabPageCategories.Location = new System.Drawing.Point(4, 25);
            this.tabPageCategories.Name = "tabPageCategories";
            this.tabPageCategories.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCategories.Size = new System.Drawing.Size(1073, 759);
            this.tabPageCategories.TabIndex = 2;
            this.tabPageCategories.Text = "Categories";
            this.tabPageCategories.UseVisualStyleBackColor = true;
            // 
            // datagridCategories
            // 
            this.datagridCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridCategories.Location = new System.Drawing.Point(6, 125);
            this.datagridCategories.Name = "datagridCategories";
            this.datagridCategories.RowTemplate.Height = 24;
            this.datagridCategories.Size = new System.Drawing.Size(1061, 628);
            this.datagridCategories.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.buttonCategoriesDelete);
            this.groupBox3.Controls.Add(this.buttonCategoriesRefresh);
            this.groupBox3.Controls.Add(this.buttonCategoriesSave);
            this.groupBox3.Controls.Add(this.buttonCategoriesAdd);
            this.groupBox3.Controls.Add(this.labelCategoriesName);
            this.groupBox3.Controls.Add(this.textBoxCategoriesName);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1061, 113);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Categories";
            // 
            // buttonCategoriesDelete
            // 
            this.buttonCategoriesDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonCategoriesDelete.Location = new System.Drawing.Point(819, 62);
            this.buttonCategoriesDelete.Name = "buttonCategoriesDelete";
            this.buttonCategoriesDelete.Size = new System.Drawing.Size(100, 28);
            this.buttonCategoriesDelete.TabIndex = 10;
            this.buttonCategoriesDelete.Text = "Delete";
            this.buttonCategoriesDelete.UseVisualStyleBackColor = true;
            this.buttonCategoriesDelete.Click += new System.EventHandler(this.buttonCategoriesDelete_Click);
            // 
            // buttonCategoriesRefresh
            // 
            this.buttonCategoriesRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonCategoriesRefresh.Location = new System.Drawing.Point(819, 22);
            this.buttonCategoriesRefresh.Name = "buttonCategoriesRefresh";
            this.buttonCategoriesRefresh.Size = new System.Drawing.Size(100, 28);
            this.buttonCategoriesRefresh.TabIndex = 9;
            this.buttonCategoriesRefresh.Text = "Refresh";
            this.buttonCategoriesRefresh.UseVisualStyleBackColor = true;
            this.buttonCategoriesRefresh.Click += new System.EventHandler(this.buttonCategoriesRefresh_Click);
            // 
            // buttonCategoriesSave
            // 
            this.buttonCategoriesSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonCategoriesSave.Location = new System.Drawing.Point(953, 62);
            this.buttonCategoriesSave.Name = "buttonCategoriesSave";
            this.buttonCategoriesSave.Size = new System.Drawing.Size(100, 28);
            this.buttonCategoriesSave.TabIndex = 8;
            this.buttonCategoriesSave.Text = "Save";
            this.buttonCategoriesSave.UseVisualStyleBackColor = true;
            this.buttonCategoriesSave.Click += new System.EventHandler(this.buttonCategoriesSave_Click);
            // 
            // buttonCategoriesAdd
            // 
            this.buttonCategoriesAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonCategoriesAdd.Location = new System.Drawing.Point(953, 22);
            this.buttonCategoriesAdd.Name = "buttonCategoriesAdd";
            this.buttonCategoriesAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonCategoriesAdd.TabIndex = 7;
            this.buttonCategoriesAdd.Text = "Add";
            this.buttonCategoriesAdd.UseVisualStyleBackColor = true;
            this.buttonCategoriesAdd.Click += new System.EventHandler(this.buttonCategoriesAdd_Click);
            // 
            // labelCategoriesName
            // 
            this.labelCategoriesName.AutoSize = true;
            this.labelCategoriesName.Location = new System.Drawing.Point(7, 18);
            this.labelCategoriesName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCategoriesName.Name = "labelCategoriesName";
            this.labelCategoriesName.Size = new System.Drawing.Size(45, 17);
            this.labelCategoriesName.TabIndex = 5;
            this.labelCategoriesName.Text = "Name";
            // 
            // textBoxCategoriesName
            // 
            this.textBoxCategoriesName.Location = new System.Drawing.Point(10, 39);
            this.textBoxCategoriesName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCategoriesName.Name = "textBoxCategoriesName";
            this.textBoxCategoriesName.Size = new System.Drawing.Size(132, 22);
            this.textBoxCategoriesName.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 812);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1123, 857);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageLedger.ResumeLayout(false);
            this.tabPageLedger.PerformLayout();
            this.tabPageContacts.ResumeLayout(false);
            this.tabPageContacts.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridContacts)).EndInit();
            this.tabPageCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridCategories)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLedgerAdd;
        private System.Windows.Forms.Button buttonLedgerSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelLedgerAmount;
        private System.Windows.Forms.TextBox textBoxLedgerAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLedgersRefresh;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLedger;
        private System.Windows.Forms.TabPage tabPageContacts;
        private System.Windows.Forms.TabPage tabPageCategories;
        private System.Windows.Forms.TextBox textBoxLedgerCheckNumber;
        private System.Windows.Forms.TextBox textBoxLedgerInvoiceNumber;
        private System.Windows.Forms.TextBox textBoxLedgerMemo;
        private System.Windows.Forms.Label labelLedgerCheckNumber;
        private System.Windows.Forms.Label labelLedgerInvoiceNumber;
        private System.Windows.Forms.Label labelLedgerMemo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonCategoriesSave;
        private System.Windows.Forms.Button buttonCategoriesAdd;
        private System.Windows.Forms.Label labelCategoriesName;
        private System.Windows.Forms.TextBox textBoxCategoriesName;
        private System.Windows.Forms.DataGridView datagridCategories;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxContactsLastName;
        private System.Windows.Forms.TextBox textBoxContactsAddressOne;
        private System.Windows.Forms.TextBox textBoxContactsAddressTwo;
        private System.Windows.Forms.TextBox textBoxContactsCity;
        private System.Windows.Forms.TextBox textBoxContactsState;
        private System.Windows.Forms.TextBox textBoxContactsZip;
        private System.Windows.Forms.TextBox textBoxContactsPhone;
        private System.Windows.Forms.TextBox textBoxContactsCompany;
        private System.Windows.Forms.Label labelContactsLastName;
        private System.Windows.Forms.Label labelContactsAddressOne;
        private System.Windows.Forms.Label labelContactsAddressTwo;
        private System.Windows.Forms.Label labelContactsCity;
        private System.Windows.Forms.Label labelContactsZip;
        private System.Windows.Forms.Label labelContactsCompany;
        private System.Windows.Forms.Label labelContactsState;
        private System.Windows.Forms.Label labelContactsPhone;
        private System.Windows.Forms.Button buttonContactsAdd;
        private System.Windows.Forms.TextBox textboxContactsFirstName;
        private System.Windows.Forms.Button buttonContactsSave;
        private System.Windows.Forms.Label labelContactsFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView datagridContacts;
        private System.Windows.Forms.Button buttonLedgerDelete;
        private System.Windows.Forms.Button buttonContactsDelete;
        private System.Windows.Forms.Button buttonContactsRefresh;
        private System.Windows.Forms.Button buttonCategoriesDelete;
        private System.Windows.Forms.Button buttonCategoriesRefresh;
        private System.Windows.Forms.ComboBox comboBoxLedgerContactList;
        private System.Windows.Forms.Label labelLedgerBalanceAmount;
        private System.Windows.Forms.Label labelLedgerBalance;
        private System.Windows.Forms.ComboBox comboBoxLedgerCategoryList;
        private System.Windows.Forms.Label labelLedgerChooseContact;
        private System.Windows.Forms.Label labelLedgerChooseCategory;
    }
}

