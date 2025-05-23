namespace Lab_Ivaniuk
{
    partial class Vzeni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vzeni));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFind = new System.Windows.Forms.ToolStripButton();
            this.btnFilter = new System.Windows.Forms.ToolStripButton();
            this.btnAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.deleteItem = new System.Windows.Forms.ToolStripButton();
            this.Edit = new System.Windows.Forms.ToolStripButton();
            this.findLabeel = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxPhone = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelReit = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.txtReitTo = new System.Windows.Forms.TextBox();
            this.txtReitFrom = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.labelLasrName = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelAdres = new System.Windows.Forms.Label();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.comboBoxAdres = new System.Windows.Forms.ComboBox();
            this.btnFilterCancel = new System.Windows.Forms.Button();
            this.btnFilterOk = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStream = new System.Windows.Forms.Button();
            this.btnOLEDB = new System.Windows.Forms.Button();
            this.btnComObject = new System.Windows.Forms.Button();
            this.btnXML = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioBtnXls = new System.Windows.Forms.RadioButton();
            this.radioBtnDoc = new System.Windows.Forms.RadioButton();
            this.radioBtnTsv = new System.Windows.Forms.RadioButton();
            this.radioBtnTxt = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(859, 331);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.dataGridView1_CellParsing);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnFind,
            this.btnFilter,
            this.btnAddNewItem,
            this.deleteItem,
            this.Edit});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1229, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnFind
            // 
            this.btnFind.CheckOnClick = true;
            this.btnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(23, 22);
            this.btnFind.Text = "Find";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.CheckOnClick = true;
            this.btnFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(23, 22);
            this.btnFilter.Text = "Filter";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewItem.Image")));
            this.btnAddNewItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.btnAddNewItem.Text = "toolStripButton1";
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // deleteItem
            // 
            this.deleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteItem.Image")));
            this.deleteItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(23, 22);
            this.deleteItem.Text = "toolStripButton2";
            this.deleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // Edit
            // 
            this.Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(23, 22);
            this.Edit.Text = "toolStripButton1";
            this.Edit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // findLabeel
            // 
            this.findLabeel.AutoSize = true;
            this.findLabeel.Location = new System.Drawing.Point(540, 11);
            this.findLabeel.Name = "findLabeel";
            this.findLabeel.Size = new System.Drawing.Size(40, 13);
            this.findLabeel.TabIndex = 2;
            this.findLabeel.Text = "Пошук";
            this.findLabeel.Visible = false;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(638, 5);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(100, 20);
            this.txtFind.TabIndex = 3;
            this.txtFind.Visible = false;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            this.txtFind.Leave += new System.EventHandler(this.txtFind_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxPhone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelReit);
            this.groupBox1.Controls.Add(this.labelTo);
            this.groupBox1.Controls.Add(this.labelFrom);
            this.groupBox1.Controls.Add(this.txtReitTo);
            this.groupBox1.Controls.Add(this.txtReitFrom);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.labelLasrName);
            this.groupBox1.Controls.Add(this.labelSex);
            this.groupBox1.Controls.Add(this.labelAdres);
            this.groupBox1.Controls.Add(this.comboBoxSex);
            this.groupBox1.Controls.Add(this.comboBoxAdres);
            this.groupBox1.Controls.Add(this.btnFilterCancel);
            this.groupBox1.Controls.Add(this.btnFilterOk);
            this.groupBox1.Location = new System.Drawing.Point(39, 588);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(953, 128);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            this.groupBox1.Visible = false;
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBoxPhone
            // 
            this.comboBoxPhone.FormattingEnabled = true;
            this.comboBoxPhone.Location = new System.Drawing.Point(692, 67);
            this.comboBoxPhone.Name = "comboBoxPhone";
            this.comboBoxPhone.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPhone.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(689, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Мобільний оператор";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(334, 90);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 17;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(334, 42);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Дата народження";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "ДО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "ВІД";
            // 
            // labelReit
            // 
            this.labelReit.AutoSize = true;
            this.labelReit.Location = new System.Drawing.Point(190, 15);
            this.labelReit.Name = "labelReit";
            this.labelReit.Size = new System.Drawing.Size(48, 13);
            this.labelReit.TabIndex = 12;
            this.labelReit.Text = "Рейтинг";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(128, 93);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(24, 13);
            this.labelTo.TabIndex = 11;
            this.labelTo.Text = "ДО";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(128, 42);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(26, 13);
            this.labelFrom.TabIndex = 10;
            this.labelFrom.Text = "ВІД";
            // 
            // txtReitTo
            // 
            this.txtReitTo.Location = new System.Drawing.Point(171, 89);
            this.txtReitTo.Name = "txtReitTo";
            this.txtReitTo.Size = new System.Drawing.Size(100, 20);
            this.txtReitTo.TabIndex = 9;
            // 
            // txtReitFrom
            // 
            this.txtReitFrom.Location = new System.Drawing.Point(171, 41);
            this.txtReitFrom.Name = "txtReitFrom";
            this.txtReitFrom.Size = new System.Drawing.Size(100, 20);
            this.txtReitFrom.TabIndex = 8;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(15, 66);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // labelLasrName
            // 
            this.labelLasrName.AutoSize = true;
            this.labelLasrName.Location = new System.Drawing.Point(23, 49);
            this.labelLasrName.Name = "labelLasrName";
            this.labelLasrName.Size = new System.Drawing.Size(56, 13);
            this.labelLasrName.TabIndex = 6;
            this.labelLasrName.Text = "Прізвище";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(547, 76);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(36, 13);
            this.labelSex.TabIndex = 5;
            this.labelSex.Text = "Стать";
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Location = new System.Drawing.Point(547, 23);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(44, 13);
            this.labelAdres.TabIndex = 4;
            this.labelAdres.Text = "Адреса";
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Location = new System.Drawing.Point(550, 92);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSex.TabIndex = 3;
            // 
            // comboBoxAdres
            // 
            this.comboBoxAdres.FormattingEnabled = true;
            this.comboBoxAdres.Location = new System.Drawing.Point(550, 39);
            this.comboBoxAdres.Name = "comboBoxAdres";
            this.comboBoxAdres.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAdres.TabIndex = 2;
            // 
            // btnFilterCancel
            // 
            this.btnFilterCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilterCancel.Location = new System.Drawing.Point(839, 83);
            this.btnFilterCancel.Name = "btnFilterCancel";
            this.btnFilterCancel.Size = new System.Drawing.Size(104, 36);
            this.btnFilterCancel.TabIndex = 1;
            this.btnFilterCancel.Text = "Відміна";
            this.btnFilterCancel.UseVisualStyleBackColor = true;
            this.btnFilterCancel.Click += new System.EventHandler(this.btnFilterCancel_Click);
            // 
            // btnFilterOk
            // 
            this.btnFilterOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnFilterOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilterOk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFilterOk.Location = new System.Drawing.Point(839, 30);
            this.btnFilterOk.Name = "btnFilterOk";
            this.btnFilterOk.Size = new System.Drawing.Size(104, 43);
            this.btnFilterOk.TabIndex = 0;
            this.btnFilterOk.Text = "Фільтрувати";
            this.btnFilterOk.UseVisualStyleBackColor = false;
            this.btnFilterOk.Click += new System.EventHandler(this.btnFilterOk_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(921, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 406);
            this.panel2.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // btnStream
            // 
            this.btnStream.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnStream.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStream.ForeColor = System.Drawing.Color.Transparent;
            this.btnStream.Location = new System.Drawing.Point(39, 97);
            this.btnStream.Name = "btnStream";
            this.btnStream.Size = new System.Drawing.Size(79, 28);
            this.btnStream.TabIndex = 25;
            this.btnStream.Text = "Stream";
            this.btnStream.UseVisualStyleBackColor = false;
            this.btnStream.Click += new System.EventHandler(this.btnStream_Click);
            // 
            // btnOLEDB
            // 
            this.btnOLEDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOLEDB.Location = new System.Drawing.Point(392, 97);
            this.btnOLEDB.Name = "btnOLEDB";
            this.btnOLEDB.Size = new System.Drawing.Size(79, 28);
            this.btnOLEDB.TabIndex = 26;
            this.btnOLEDB.Text = "OLEDB";
            this.btnOLEDB.UseVisualStyleBackColor = true;
            this.btnOLEDB.Click += new System.EventHandler(this.btnOLEDB_Click);
            // 
            // btnComObject
            // 
            this.btnComObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnComObject.Location = new System.Drawing.Point(488, 97);
            this.btnComObject.Name = "btnComObject";
            this.btnComObject.Size = new System.Drawing.Size(107, 28);
            this.btnComObject.TabIndex = 27;
            this.btnComObject.Text = "Com Object";
            this.btnComObject.UseVisualStyleBackColor = true;
            this.btnComObject.Click += new System.EventHandler(this.btnComObject_Click);
            // 
            // btnXML
            // 
            this.btnXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnXML.Location = new System.Drawing.Point(612, 97);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(79, 28);
            this.btnXML.TabIndex = 28;
            this.btnXML.Text = "XML";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioBtnXls);
            this.panel1.Controls.Add(this.radioBtnDoc);
            this.panel1.Controls.Add(this.radioBtnTsv);
            this.panel1.Controls.Add(this.radioBtnTxt);
            this.panel1.Location = new System.Drawing.Point(170, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 100);
            this.panel1.TabIndex = 29;
            // 
            // radioBtnXls
            // 
            this.radioBtnXls.AutoSize = true;
            this.radioBtnXls.Location = new System.Drawing.Point(119, 67);
            this.radioBtnXls.Name = "radioBtnXls";
            this.radioBtnXls.Size = new System.Drawing.Size(37, 17);
            this.radioBtnXls.TabIndex = 3;
            this.radioBtnXls.TabStop = true;
            this.radioBtnXls.Text = "xls";
            this.radioBtnXls.UseVisualStyleBackColor = true;
            // 
            // radioBtnDoc
            // 
            this.radioBtnDoc.AutoSize = true;
            this.radioBtnDoc.Location = new System.Drawing.Point(119, 13);
            this.radioBtnDoc.Name = "radioBtnDoc";
            this.radioBtnDoc.Size = new System.Drawing.Size(43, 17);
            this.radioBtnDoc.TabIndex = 2;
            this.radioBtnDoc.TabStop = true;
            this.radioBtnDoc.Text = "doc";
            this.radioBtnDoc.UseVisualStyleBackColor = true;
            // 
            // radioBtnTsv
            // 
            this.radioBtnTsv.AutoSize = true;
            this.radioBtnTsv.Location = new System.Drawing.Point(15, 67);
            this.radioBtnTsv.Name = "radioBtnTsv";
            this.radioBtnTsv.Size = new System.Drawing.Size(39, 17);
            this.radioBtnTsv.TabIndex = 1;
            this.radioBtnTsv.Text = "tsv";
            this.radioBtnTsv.UseVisualStyleBackColor = true;
            // 
            // radioBtnTxt
            // 
            this.radioBtnTxt.AutoSize = true;
            this.radioBtnTxt.Checked = true;
            this.radioBtnTxt.Location = new System.Drawing.Point(15, 13);
            this.radioBtnTxt.Name = "radioBtnTxt";
            this.radioBtnTxt.Size = new System.Drawing.Size(36, 17);
            this.radioBtnTxt.TabIndex = 0;
            this.radioBtnTxt.TabStop = true;
            this.radioBtnTxt.Text = "txt";
            this.radioBtnTxt.UseVisualStyleBackColor = true;
            // 
            // Vzeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 757);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnXML);
            this.Controls.Add(this.btnComObject);
            this.Controls.Add(this.btnOLEDB);
            this.Controls.Add(this.btnStream);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.findLabeel);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Vzeni";
            this.Text = "Vzeni";
            this.Load += new System.EventHandler(this.Vzeni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnFind;
        private System.Windows.Forms.Label findLabeel;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.ToolStripButton btnFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFilterCancel;
        private System.Windows.Forms.Button btnFilterOk;
        private System.Windows.Forms.ComboBox comboBoxAdres;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.Label labelLasrName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtReitTo;
        private System.Windows.Forms.TextBox txtReitFrom;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelReit;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPhone;
        private System.Windows.Forms.ToolStripButton btnAddNewItem;
        private System.Windows.Forms.ToolStripButton deleteItem;
        private System.Windows.Forms.ToolStripButton Edit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStream;
        private System.Windows.Forms.Button btnOLEDB;
        private System.Windows.Forms.Button btnComObject;
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioBtnXls;
        private System.Windows.Forms.RadioButton radioBtnDoc;
        private System.Windows.Forms.RadioButton radioBtnTsv;
        private System.Windows.Forms.RadioButton radioBtnTxt;
    }
}