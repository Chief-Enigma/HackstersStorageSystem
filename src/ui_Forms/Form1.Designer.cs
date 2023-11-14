namespace ui_Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "Heissnes", "100", "Hoties" }, -1);
            lbSearchResults = new ListBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnSaveItem = new Button();
            btnAddItem = new Button();
            btnDeleteItem = new Button();
            groupBox1 = new GroupBox();
            gbStoragePlace = new GroupBox();
            intStorageBox = new NumericUpDown();
            intStorageLevel = new NumericUpDown();
            label11 = new Label();
            label8 = new Label();
            txtStorageShelf = new TextBox();
            label9 = new Label();
            txtStorageRoom = new TextBox();
            label10 = new Label();
            gbSpecifiactions = new GroupBox();
            LvSpecs = new ListView();
            SpecsLb_Name = new ColumnHeader();
            SpecsLb_Value = new ColumnHeader();
            SpecsLb_Unite = new ColumnHeader();
            btnSpecAdd = new Button();
            txtSpecValue = new TextBox();
            txtSpecUnite = new TextBox();
            txtSpecName = new TextBox();
            btnEditItem = new Button();
            gbCategorys = new GroupBox();
            clbCategorys = new CheckedListBox();
            btnCategoryAdd = new Button();
            txtCategory = new TextBox();
            btnBookOut = new Button();
            gbItemOverview = new GroupBox();
            intQuantity = new NumericUpDown();
            txtProductNumber = new TextBox();
            label13 = new Label();
            label12 = new Label();
            txtDBID = new TextBox();
            label1 = new Label();
            txtItemID = new TextBox();
            label2 = new Label();
            txtItemName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtHSSNumber = new TextBox();
            btnBookIn = new Button();
            gbSupplier = new GroupBox();
            txtSupplierPrice = new TextBox();
            label7 = new Label();
            txtSupplierNumber = new TextBox();
            label6 = new Label();
            txtSupplierName = new TextBox();
            label5 = new Label();
            groupBox2 = new GroupBox();
            btnLogin = new Button();
            txtUserName = new TextBox();
            txtUserPassword = new TextBox();
            cbDBList = new ComboBox();
            groupBox3 = new GroupBox();
            btnDeleteMember = new Button();
            btnSetRole = new Button();
            cbDBRoles = new ComboBox();
            btnAddUserDB = new Button();
            txtNewDBMember = new TextBox();
            label14 = new Label();
            listBox1 = new ListBox();
            btnLoadDB = new Button();
            btnCreatenewDB = new Button();
            txtCreatenewDB = new TextBox();
            groupBox1.SuspendLayout();
            gbStoragePlace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)intStorageBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)intStorageLevel).BeginInit();
            gbSpecifiactions.SuspendLayout();
            gbCategorys.SuspendLayout();
            gbItemOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)intQuantity).BeginInit();
            gbSupplier.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lbSearchResults
            // 
            lbSearchResults.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbSearchResults.FormattingEnabled = true;
            lbSearchResults.ItemHeight = 15;
            lbSearchResults.Location = new Point(6, 69);
            lbSearchResults.Name = "lbSearchResults";
            lbSearchResults.Size = new Size(235, 649);
            lbSearchResults.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearch.Location = new Point(6, 41);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(170, 23);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.ActiveCaptionText;
            btnSearch.Location = new Point(182, 41);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(60, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSaveItem
            // 
            btnSaveItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveItem.ForeColor = SystemColors.ActiveCaptionText;
            btnSaveItem.Location = new Point(773, 322);
            btnSaveItem.Name = "btnSaveItem";
            btnSaveItem.Size = new Size(122, 25);
            btnSaveItem.TabIndex = 3;
            btnSaveItem.Text = "Save Item";
            btnSaveItem.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            btnAddItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddItem.ForeColor = SystemColors.ActiveCaptionText;
            btnAddItem.Location = new Point(646, 353);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(122, 24);
            btnAddItem.TabIndex = 4;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteItem.ForeColor = SystemColors.ActiveCaptionText;
            btnDeleteItem.Location = new Point(774, 352);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(123, 25);
            btnDeleteItem.TabIndex = 5;
            btnDeleteItem.Text = "Delete Item";
            btnDeleteItem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(gbStoragePlace);
            groupBox1.Controls.Add(gbSpecifiactions);
            groupBox1.Controls.Add(btnEditItem);
            groupBox1.Controls.Add(gbCategorys);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(btnBookOut);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(gbItemOverview);
            groupBox1.Controls.Add(lbSearchResults);
            groupBox1.Controls.Add(btnBookIn);
            groupBox1.Controls.Add(gbSupplier);
            groupBox1.Controls.Add(btnSaveItem);
            groupBox1.Controls.Add(btnDeleteItem);
            groupBox1.Controls.Add(btnAddItem);
            groupBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(213, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(902, 723);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Itemview";
            // 
            // gbStoragePlace
            // 
            gbStoragePlace.Controls.Add(intStorageBox);
            gbStoragePlace.Controls.Add(intStorageLevel);
            gbStoragePlace.Controls.Add(label11);
            gbStoragePlace.Controls.Add(label8);
            gbStoragePlace.Controls.Add(txtStorageShelf);
            gbStoragePlace.Controls.Add(label9);
            gbStoragePlace.Controls.Add(txtStorageRoom);
            gbStoragePlace.Controls.Add(label10);
            gbStoragePlace.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            gbStoragePlace.ForeColor = SystemColors.ButtonHighlight;
            gbStoragePlace.Location = new Point(646, 150);
            gbStoragePlace.Name = "gbStoragePlace";
            gbStoragePlace.Size = new Size(249, 135);
            gbStoragePlace.TabIndex = 30;
            gbStoragePlace.TabStop = false;
            gbStoragePlace.Text = "Storage Place";
            // 
            // intStorageBox
            // 
            intStorageBox.Location = new Point(71, 106);
            intStorageBox.Name = "intStorageBox";
            intStorageBox.Size = new Size(172, 22);
            intStorageBox.TabIndex = 24;
            // 
            // intStorageLevel
            // 
            intStorageLevel.Location = new Point(71, 77);
            intStorageLevel.Name = "intStorageLevel";
            intStorageLevel.Size = new Size(172, 22);
            intStorageLevel.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(22, 105);
            label11.Name = "label11";
            label11.Size = new Size(40, 20);
            label11.TabIndex = 22;
            label11.Text = "Box:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(9, 76);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 20;
            label8.Text = "Level:";
            // 
            // txtStorageShelf
            // 
            txtStorageShelf.Location = new Point(71, 48);
            txtStorageShelf.Name = "txtStorageShelf";
            txtStorageShelf.Size = new Size(172, 22);
            txtStorageShelf.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(12, 48);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 18;
            label9.Text = "Shelf:";
            // 
            // txtStorageRoom
            // 
            txtStorageRoom.Location = new Point(71, 19);
            txtStorageRoom.Name = "txtStorageRoom";
            txtStorageRoom.Size = new Size(172, 22);
            txtStorageRoom.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(6, 19);
            label10.Name = "label10";
            label10.Size = new Size(56, 20);
            label10.TabIndex = 16;
            label10.Text = "Room:";
            // 
            // gbSpecifiactions
            // 
            gbSpecifiactions.Controls.Add(LvSpecs);
            gbSpecifiactions.Controls.Add(btnSpecAdd);
            gbSpecifiactions.Controls.Add(txtSpecValue);
            gbSpecifiactions.Controls.Add(txtSpecUnite);
            gbSpecifiactions.Controls.Add(txtSpecName);
            gbSpecifiactions.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            gbSpecifiactions.ForeColor = SystemColors.ButtonHighlight;
            gbSpecifiactions.Location = new Point(247, 424);
            gbSpecifiactions.Name = "gbSpecifiactions";
            gbSpecifiactions.Size = new Size(393, 294);
            gbSpecifiactions.TabIndex = 29;
            gbSpecifiactions.TabStop = false;
            gbSpecifiactions.Text = "Specifiactions";
            // 
            // LvSpecs
            // 
            LvSpecs.Columns.AddRange(new ColumnHeader[] { SpecsLb_Name, SpecsLb_Value, SpecsLb_Unite });
            LvSpecs.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LvSpecs.FullRowSelect = true;
            LvSpecs.GridLines = true;
            LvSpecs.Items.AddRange(new ListViewItem[] { listViewItem2 });
            LvSpecs.Location = new Point(6, 51);
            LvSpecs.Name = "LvSpecs";
            LvSpecs.Size = new Size(381, 234);
            LvSpecs.TabIndex = 20;
            LvSpecs.UseCompatibleStateImageBehavior = false;
            LvSpecs.View = View.Details;
            // 
            // SpecsLb_Name
            // 
            SpecsLb_Name.Text = "Name";
            SpecsLb_Name.Width = 114;
            // 
            // SpecsLb_Value
            // 
            SpecsLb_Value.Text = "Value";
            SpecsLb_Value.Width = 114;
            // 
            // SpecsLb_Unite
            // 
            SpecsLb_Unite.Text = "Unite";
            SpecsLb_Unite.Width = 114;
            // 
            // btnSpecAdd
            // 
            btnSpecAdd.BackColor = Color.Transparent;
            btnSpecAdd.FlatAppearance.BorderColor = Color.White;
            btnSpecAdd.ForeColor = Color.Black;
            btnSpecAdd.Location = new Point(321, 22);
            btnSpecAdd.Name = "btnSpecAdd";
            btnSpecAdd.Size = new Size(66, 23);
            btnSpecAdd.TabIndex = 19;
            btnSpecAdd.Text = "Add";
            btnSpecAdd.UseVisualStyleBackColor = false;
            // 
            // txtSpecValue
            // 
            txtSpecValue.Location = new Point(111, 22);
            txtSpecValue.Name = "txtSpecValue";
            txtSpecValue.PlaceholderText = "Value";
            txtSpecValue.Size = new Size(99, 22);
            txtSpecValue.TabIndex = 18;
            // 
            // txtSpecUnite
            // 
            txtSpecUnite.Location = new Point(216, 22);
            txtSpecUnite.Name = "txtSpecUnite";
            txtSpecUnite.PlaceholderText = "Unite";
            txtSpecUnite.Size = new Size(99, 22);
            txtSpecUnite.TabIndex = 17;
            // 
            // txtSpecName
            // 
            txtSpecName.Location = new Point(6, 22);
            txtSpecName.Name = "txtSpecName";
            txtSpecName.PlaceholderText = "Name";
            txtSpecName.Size = new Size(99, 22);
            txtSpecName.TabIndex = 16;
            // 
            // btnEditItem
            // 
            btnEditItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditItem.ForeColor = SystemColors.ActiveCaptionText;
            btnEditItem.Location = new Point(646, 322);
            btnEditItem.Name = "btnEditItem";
            btnEditItem.Size = new Size(122, 25);
            btnEditItem.TabIndex = 10;
            btnEditItem.Text = "Edit Item";
            btnEditItem.UseVisualStyleBackColor = true;
            // 
            // gbCategorys
            // 
            gbCategorys.Controls.Add(clbCategorys);
            gbCategorys.Controls.Add(btnCategoryAdd);
            gbCategorys.Controls.Add(txtCategory);
            gbCategorys.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            gbCategorys.ForeColor = SystemColors.ButtonHighlight;
            gbCategorys.Location = new Point(247, 233);
            gbCategorys.Name = "gbCategorys";
            gbCategorys.Size = new Size(393, 185);
            gbCategorys.TabIndex = 28;
            gbCategorys.TabStop = false;
            gbCategorys.Text = "Categorys";
            // 
            // clbCategorys
            // 
            clbCategorys.FormattingEnabled = true;
            clbCategorys.Items.AddRange(new object[] { "Bumsdings", "Girlfriend" });
            clbCategorys.Location = new Point(6, 48);
            clbCategorys.Name = "clbCategorys";
            clbCategorys.Size = new Size(381, 123);
            clbCategorys.TabIndex = 20;
            // 
            // btnCategoryAdd
            // 
            btnCategoryAdd.BackColor = Color.Transparent;
            btnCategoryAdd.FlatAppearance.BorderColor = Color.White;
            btnCategoryAdd.ForeColor = Color.Black;
            btnCategoryAdd.Location = new Point(312, 18);
            btnCategoryAdd.Name = "btnCategoryAdd";
            btnCategoryAdd.Size = new Size(75, 23);
            btnCategoryAdd.TabIndex = 19;
            btnCategoryAdd.Text = "Add";
            btnCategoryAdd.UseVisualStyleBackColor = false;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(8, 19);
            txtCategory.Name = "txtCategory";
            txtCategory.PlaceholderText = "Name";
            txtCategory.Size = new Size(298, 22);
            txtCategory.TabIndex = 16;
            // 
            // btnBookOut
            // 
            btnBookOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBookOut.ForeColor = SystemColors.ActiveCaptionText;
            btnBookOut.Location = new Point(773, 291);
            btnBookOut.Name = "btnBookOut";
            btnBookOut.Size = new Size(122, 25);
            btnBookOut.TabIndex = 9;
            btnBookOut.Text = "Book out";
            btnBookOut.UseVisualStyleBackColor = true;
            // 
            // gbItemOverview
            // 
            gbItemOverview.Controls.Add(intQuantity);
            gbItemOverview.Controls.Add(txtProductNumber);
            gbItemOverview.Controls.Add(label13);
            gbItemOverview.Controls.Add(label12);
            gbItemOverview.Controls.Add(txtDBID);
            gbItemOverview.Controls.Add(label1);
            gbItemOverview.Controls.Add(txtItemID);
            gbItemOverview.Controls.Add(label2);
            gbItemOverview.Controls.Add(txtItemName);
            gbItemOverview.Controls.Add(label3);
            gbItemOverview.Controls.Add(label4);
            gbItemOverview.Controls.Add(txtHSSNumber);
            gbItemOverview.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            gbItemOverview.ForeColor = SystemColors.ButtonHighlight;
            gbItemOverview.Location = new Point(247, 34);
            gbItemOverview.Name = "gbItemOverview";
            gbItemOverview.Size = new Size(393, 195);
            gbItemOverview.TabIndex = 26;
            gbItemOverview.TabStop = false;
            gbItemOverview.Text = "Item Overview";
            // 
            // intQuantity
            // 
            intQuantity.Location = new Point(153, 163);
            intQuantity.Name = "intQuantity";
            intQuantity.Size = new Size(234, 22);
            intQuantity.TabIndex = 18;
            // 
            // txtProductNumber
            // 
            txtProductNumber.Location = new Point(153, 133);
            txtProductNumber.Name = "txtProductNumber";
            txtProductNumber.Size = new Size(234, 22);
            txtProductNumber.TabIndex = 17;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(6, 133);
            label13.Name = "label13";
            label13.Size = new Size(128, 20);
            label13.TabIndex = 16;
            label13.Text = "Product Number:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(6, 46);
            label12.Name = "label12";
            label12.Size = new Size(106, 20);
            label12.TabIndex = 14;
            label12.Text = "DataBase ID:";
            // 
            // txtDBID
            // 
            txtDBID.Location = new Point(153, 46);
            txtDBID.Name = "txtDBID";
            txtDBID.Size = new Size(234, 22);
            txtDBID.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(6, 17);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 6;
            label1.Text = "Item ID:";
            // 
            // txtItemID
            // 
            txtItemID.Location = new Point(153, 17);
            txtItemID.Name = "txtItemID";
            txtItemID.Size = new Size(234, 22);
            txtItemID.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(6, 75);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 8;
            label2.Text = "Item Name:";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(153, 75);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(234, 22);
            txtItemName.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(6, 104);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 10;
            label3.Text = "HSS Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(6, 162);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 12;
            label4.Text = "Quantity:";
            // 
            // txtHSSNumber
            // 
            txtHSSNumber.Location = new Point(153, 104);
            txtHSSNumber.Name = "txtHSSNumber";
            txtHSSNumber.Size = new Size(234, 22);
            txtHSSNumber.TabIndex = 11;
            // 
            // btnBookIn
            // 
            btnBookIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBookIn.ForeColor = SystemColors.ActiveCaptionText;
            btnBookIn.Location = new Point(646, 291);
            btnBookIn.Name = "btnBookIn";
            btnBookIn.Size = new Size(122, 25);
            btnBookIn.TabIndex = 8;
            btnBookIn.Text = "Book in";
            btnBookIn.UseVisualStyleBackColor = true;
            // 
            // gbSupplier
            // 
            gbSupplier.Controls.Add(txtSupplierPrice);
            gbSupplier.Controls.Add(label7);
            gbSupplier.Controls.Add(txtSupplierNumber);
            gbSupplier.Controls.Add(label6);
            gbSupplier.Controls.Add(txtSupplierName);
            gbSupplier.Controls.Add(label5);
            gbSupplier.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            gbSupplier.ForeColor = SystemColors.ButtonHighlight;
            gbSupplier.Location = new Point(646, 34);
            gbSupplier.Name = "gbSupplier";
            gbSupplier.Size = new Size(249, 110);
            gbSupplier.TabIndex = 24;
            gbSupplier.TabStop = false;
            gbSupplier.Text = "Supplier";
            // 
            // txtSupplierPrice
            // 
            txtSupplierPrice.Location = new Point(90, 80);
            txtSupplierPrice.Name = "txtSupplierPrice";
            txtSupplierPrice.Size = new Size(153, 22);
            txtSupplierPrice.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(29, 80);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 20;
            label7.Text = "Price:";
            // 
            // txtSupplierNumber
            // 
            txtSupplierNumber.Location = new Point(90, 51);
            txtSupplierNumber.Name = "txtSupplierNumber";
            txtSupplierNumber.Size = new Size(153, 22);
            txtSupplierNumber.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(8, 51);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 18;
            label6.Text = "Number:";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(90, 22);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(153, 22);
            txtSupplierName.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(5, 22);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 16;
            label5.Text = "Supplier:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnLogin);
            groupBox2.Controls.Add(txtUserName);
            groupBox2.Controls.Add(txtUserPassword);
            groupBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.Control;
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(195, 127);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Usersettings";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ControlText;
            btnLogin.Location = new Point(6, 92);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(183, 27);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserName.Location = new Point(6, 34);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Username";
            txtUserName.Size = new Size(183, 23);
            txtUserName.TabIndex = 11;
            // 
            // txtUserPassword
            // 
            txtUserPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserPassword.Location = new Point(6, 63);
            txtUserPassword.Name = "txtUserPassword";
            txtUserPassword.PasswordChar = '*';
            txtUserPassword.PlaceholderText = "Password";
            txtUserPassword.Size = new Size(183, 23);
            txtUserPassword.TabIndex = 12;
            // 
            // cbDBList
            // 
            cbDBList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbDBList.FormattingEnabled = true;
            cbDBList.Location = new Point(6, 118);
            cbDBList.Name = "cbDBList";
            cbDBList.Size = new Size(183, 23);
            cbDBList.TabIndex = 13;
            cbDBList.Text = "Chose DataBase";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnDeleteMember);
            groupBox3.Controls.Add(btnSetRole);
            groupBox3.Controls.Add(cbDBRoles);
            groupBox3.Controls.Add(btnAddUserDB);
            groupBox3.Controls.Add(txtNewDBMember);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(listBox1);
            groupBox3.Controls.Add(btnLoadDB);
            groupBox3.Controls.Add(btnCreatenewDB);
            groupBox3.Controls.Add(txtCreatenewDB);
            groupBox3.Controls.Add(cbDBList);
            groupBox3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.ForeColor = SystemColors.Control;
            groupBox3.Location = new Point(12, 145);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(195, 590);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "DB Settings";
            // 
            // btnDeleteMember
            // 
            btnDeleteMember.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteMember.ForeColor = SystemColors.ControlText;
            btnDeleteMember.Location = new Point(6, 479);
            btnDeleteMember.Name = "btnDeleteMember";
            btnDeleteMember.Size = new Size(183, 27);
            btnDeleteMember.TabIndex = 37;
            btnDeleteMember.Text = "Delete Member";
            btnDeleteMember.UseVisualStyleBackColor = true;
            // 
            // btnSetRole
            // 
            btnSetRole.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSetRole.ForeColor = SystemColors.ControlText;
            btnSetRole.Location = new Point(6, 557);
            btnSetRole.Name = "btnSetRole";
            btnSetRole.Size = new Size(183, 27);
            btnSetRole.TabIndex = 36;
            btnSetRole.Text = "Set Member Role";
            btnSetRole.UseVisualStyleBackColor = true;
            // 
            // cbDBRoles
            // 
            cbDBRoles.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbDBRoles.FormattingEnabled = true;
            cbDBRoles.Location = new Point(6, 528);
            cbDBRoles.Name = "cbDBRoles";
            cbDBRoles.Size = new Size(183, 23);
            cbDBRoles.TabIndex = 35;
            cbDBRoles.Text = "Select Role";
            // 
            // btnAddUserDB
            // 
            btnAddUserDB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddUserDB.ForeColor = SystemColors.ControlText;
            btnAddUserDB.Location = new Point(6, 446);
            btnAddUserDB.Name = "btnAddUserDB";
            btnAddUserDB.Size = new Size(183, 27);
            btnAddUserDB.TabIndex = 34;
            btnAddUserDB.Text = "Add to DB";
            btnAddUserDB.UseVisualStyleBackColor = true;
            // 
            // txtNewDBMember
            // 
            txtNewDBMember.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtNewDBMember.Location = new Point(6, 417);
            txtNewDBMember.Name = "txtNewDBMember";
            txtNewDBMember.PlaceholderText = "Name of new Member";
            txtNewDBMember.Size = new Size(183, 23);
            txtNewDBMember.TabIndex = 33;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(6, 221);
            label14.Name = "label14";
            label14.Size = new Size(120, 20);
            label14.TabIndex = 32;
            label14.Text = "Members of DB";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(6, 242);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(183, 169);
            listBox1.TabIndex = 31;
            // 
            // btnLoadDB
            // 
            btnLoadDB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoadDB.ForeColor = SystemColors.ControlText;
            btnLoadDB.Location = new Point(6, 147);
            btnLoadDB.Name = "btnLoadDB";
            btnLoadDB.Size = new Size(183, 27);
            btnLoadDB.TabIndex = 14;
            btnLoadDB.Text = "Load DataBase";
            btnLoadDB.UseVisualStyleBackColor = true;
            // 
            // btnCreatenewDB
            // 
            btnCreatenewDB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreatenewDB.ForeColor = SystemColors.ControlText;
            btnCreatenewDB.Location = new Point(6, 64);
            btnCreatenewDB.Name = "btnCreatenewDB";
            btnCreatenewDB.Size = new Size(183, 27);
            btnCreatenewDB.TabIndex = 11;
            btnCreatenewDB.Text = "Create new DataBase";
            btnCreatenewDB.UseVisualStyleBackColor = true;
            // 
            // txtCreatenewDB
            // 
            txtCreatenewDB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtCreatenewDB.Location = new Point(6, 34);
            txtCreatenewDB.Name = "txtCreatenewDB";
            txtCreatenewDB.PlaceholderText = "Name of new DataBase";
            txtCreatenewDB.Size = new Size(183, 23);
            txtCreatenewDB.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 24);
            ClientSize = new Size(1123, 744);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbStoragePlace.ResumeLayout(false);
            gbStoragePlace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)intStorageBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)intStorageLevel).EndInit();
            gbSpecifiactions.ResumeLayout(false);
            gbSpecifiactions.PerformLayout();
            gbCategorys.ResumeLayout(false);
            gbCategorys.PerformLayout();
            gbItemOverview.ResumeLayout(false);
            gbItemOverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)intQuantity).EndInit();
            gbSupplier.ResumeLayout(false);
            gbSupplier.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbSearchResults;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnSaveItem;
        private Button btnAddItem;
        private Button btnDeleteItem;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnBookIn;
        private Button btnBookOut;
        private Button btnEditItem;
        private TextBox txtUserPassword;
        private TextBox txtUserName;
        private GroupBox gbItemOverview;
        private Label label1;
        private TextBox txtItemID;
        private Label label2;
        private TextBox txtItemName;
        private Label label3;
        private Label label4;
        private TextBox txtHSSNumber;
        private GroupBox gbSupplier;
        private TextBox txtSupplierPrice;
        private Label label7;
        private TextBox txtSupplierNumber;
        private Label label6;
        private TextBox txtSupplierName;
        private Label label5;
        private Button btnLogin;
        private Button btnLoadDB;
        private ComboBox cbDBList;
        private TextBox txtProductNumber;
        private Label label13;
        private Label label12;
        private TextBox txtDBID;
        private GroupBox gbStoragePlace;
        private NumericUpDown intStorageBox;
        private NumericUpDown intStorageLevel;
        private Label label11;
        private Label label8;
        private TextBox txtStorageShelf;
        private Label label9;
        private TextBox txtStorageRoom;
        private Label label10;
        private GroupBox gbSpecifiactions;
        private ListView LvSpecs;
        private ColumnHeader SpecsLb_Name;
        private ColumnHeader SpecsLb_Value;
        private ColumnHeader SpecsLb_Unite;
        private Button btnSpecAdd;
        private TextBox txtSpecValue;
        private TextBox txtSpecUnite;
        private TextBox txtSpecName;
        private GroupBox gbCategorys;
        private CheckedListBox clbCategorys;
        private Button btnCategoryAdd;
        private TextBox txtCategory;
        private NumericUpDown intQuantity;
        private GroupBox groupBox3;
        private Button btnCreatenewDB;
        private TextBox txtCreatenewDB;
        private Label label14;
        private ListBox listBox1;
        private Button btnSetRole;
        private ComboBox cbDBRoles;
        private Button btnAddUserDB;
        private TextBox txtNewDBMember;
        private Button btnDeleteMember;
    }
}