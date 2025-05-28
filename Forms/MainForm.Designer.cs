namespace MagazOnline.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelOrders;
        private System.Windows.Forms.Button btnAddPromotion;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnViewEmployees;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelOrders = new System.Windows.Forms.Label();
            this.btnAddPromotion = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnViewEmployees = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new MagazOnline.Database1DataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcategorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPreasamblatDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanelProduse = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelCos = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comandaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanelComenzi = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriereDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promotionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promotionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produsIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promotionsItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriereProblemaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPreferataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxAddProduct = new System.Windows.Forms.GroupBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cmbProdusSubcategorie = new System.Windows.Forms.ComboBox();
            this.cmbProdusCategorie = new System.Windows.Forms.ComboBox();
            this.txtProdusDescriere = new System.Windows.Forms.TextBox();
            this.txtProdusPret = new System.Windows.Forms.TextBox();
            this.txtProdusNume = new System.Windows.Forms.TextBox();
            this.groupBoxAddAngajat = new System.Windows.Forms.GroupBox();
            this.btnAddAngajat = new System.Windows.Forms.Button();
            this.cmbTipAngajat = new System.Windows.Forms.ComboBox();
            this.txtParolaAngajat = new System.Windows.Forms.TextBox();
            this.txtNumeAngajat = new System.Windows.Forms.TextBox();
            this.usersTableAdapter = new MagazOnline.Database1DataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new MagazOnline.Database1DataSetTableAdapters.TableAdapterManager();
            this.ordersTableAdapter = new MagazOnline.Database1DataSetTableAdapters.OrdersTableAdapter();
            this.productsTableAdapter = new MagazOnline.Database1DataSetTableAdapters.ProductsTableAdapter();
            this.orderItemsTableAdapter = new MagazOnline.Database1DataSetTableAdapters.OrderItemsTableAdapter();
            this.promotionsTableAdapter = new MagazOnline.Database1DataSetTableAdapters.PromotionsTableAdapter();
            this.promotionsItemsTableAdapter = new MagazOnline.Database1DataSetTableAdapters.PromotionsItemsTableAdapter();
            this.serviceRequestTableAdapter = new MagazOnline.Database1DataSetTableAdapters.ServiceRequestTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clbPromotiiExistente = new System.Windows.Forms.CheckedListBox();
            this.btnDeletePromo = new System.Windows.Forms.Button();
            this.btnAddPromo = new System.Windows.Forms.Button();
            this.clbPromoProduse = new System.Windows.Forms.CheckedListBox();
            this.txtPromoDescriere = new System.Windows.Forms.TextBox();
            this.txtPromoNume = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionsItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceRequestBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxAddProduct.SuspendLayout();
            this.groupBoxAddAngajat.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelOrders
            // 
            this.labelOrders.ForeColor = System.Drawing.Color.White;
            this.labelOrders.Location = new System.Drawing.Point(377, 280);
            this.labelOrders.Name = "labelOrders";
            this.labelOrders.Size = new System.Drawing.Size(180, 20);
            this.labelOrders.TabIndex = 3;
            this.labelOrders.Text = "Comenzi și Cereri Service";
            this.labelOrders.Visible = false;
            // 
            // btnAddPromotion
            // 
            this.btnAddPromotion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAddPromotion.FlatAppearance.BorderSize = 0;
            this.btnAddPromotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPromotion.ForeColor = System.Drawing.Color.White;
            this.btnAddPromotion.Location = new System.Drawing.Point(27, 47);
            this.btnAddPromotion.Name = "btnAddPromotion";
            this.btnAddPromotion.Size = new System.Drawing.Size(136, 30);
            this.btnAddPromotion.TabIndex = 4;
            this.btnAddPromotion.Text = "Promotii";
            this.btnAddPromotion.UseVisualStyleBackColor = false;
            this.btnAddPromotion.Click += new System.EventHandler(this.btnAddPromotion_Click_1);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnPlaceOrder.FlatAppearance.BorderSize = 0;
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.Location = new System.Drawing.Point(23, 694);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(184, 30);
            this.btnPlaceOrder.TabIndex = 8;
            this.btnPlaceOrder.Text = "Plasează Comandă";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click_1);
            // 
            // btnViewEmployees
            // 
            this.btnViewEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnViewEmployees.FlatAppearance.BorderSize = 0;
            this.btnViewEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewEmployees.ForeColor = System.Drawing.Color.White;
            this.btnViewEmployees.Location = new System.Drawing.Point(169, 72);
            this.btnViewEmployees.Name = "btnViewEmployees";
            this.btnViewEmployees.Size = new System.Drawing.Size(150, 28);
            this.btnViewEmployees.TabIndex = 9;
            this.btnViewEmployees.Text = "Adaugare Angajat";
            this.btnViewEmployees.UseVisualStyleBackColor = false;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAddEmployee.Location = new System.Drawing.Point(169, 28);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(150, 30);
            this.btnAddEmployee.TabIndex = 10;
            this.btnAddEmployee.Text = "Vizualizare Angajat";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click_1);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(23, 613);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(184, 30);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.parolaDataGridViewTextBoxColumn,
            this.tipDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(465, 812);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(18, 37);
            this.dataGridView1.TabIndex = 13;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            // 
            // parolaDataGridViewTextBoxColumn
            // 
            this.parolaDataGridViewTextBoxColumn.DataPropertyName = "Parola";
            this.parolaDataGridViewTextBoxColumn.HeaderText = "Parola";
            this.parolaDataGridViewTextBoxColumn.Name = "parolaDataGridViewTextBoxColumn";
            // 
            // tipDataGridViewTextBoxColumn
            // 
            this.tipDataGridViewTextBoxColumn.DataPropertyName = "Tip";
            this.tipDataGridViewTextBoxColumn.HeaderText = "Tip";
            this.tipDataGridViewTextBoxColumn.Name = "tipDataGridViewTextBoxColumn";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.numeDataGridViewTextBoxColumn1,
            this.categorieDataGridViewTextBoxColumn,
            this.subcategorieDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.descriereDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.isPreasamblatDataGridViewCheckBoxColumn});
            this.dataGridView2.DataSource = this.productsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(385, 810);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(25, 39);
            this.dataGridView2.TabIndex = 14;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // numeDataGridViewTextBoxColumn1
            // 
            this.numeDataGridViewTextBoxColumn1.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn1.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn1.Name = "numeDataGridViewTextBoxColumn1";
            // 
            // categorieDataGridViewTextBoxColumn
            // 
            this.categorieDataGridViewTextBoxColumn.DataPropertyName = "Categorie";
            this.categorieDataGridViewTextBoxColumn.HeaderText = "Categorie";
            this.categorieDataGridViewTextBoxColumn.Name = "categorieDataGridViewTextBoxColumn";
            // 
            // subcategorieDataGridViewTextBoxColumn
            // 
            this.subcategorieDataGridViewTextBoxColumn.DataPropertyName = "Subcategorie";
            this.subcategorieDataGridViewTextBoxColumn.HeaderText = "Subcategorie";
            this.subcategorieDataGridViewTextBoxColumn.Name = "subcategorieDataGridViewTextBoxColumn";
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            // 
            // descriereDataGridViewTextBoxColumn
            // 
            this.descriereDataGridViewTextBoxColumn.DataPropertyName = "Descriere";
            this.descriereDataGridViewTextBoxColumn.HeaderText = "Descriere";
            this.descriereDataGridViewTextBoxColumn.Name = "descriereDataGridViewTextBoxColumn";
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            // 
            // isPreasamblatDataGridViewCheckBoxColumn
            // 
            this.isPreasamblatDataGridViewCheckBoxColumn.DataPropertyName = "IsPreasamblat";
            this.isPreasamblatDataGridViewCheckBoxColumn.HeaderText = "IsPreasamblat";
            this.isPreasamblatDataGridViewCheckBoxColumn.Name = "isPreasamblatDataGridViewCheckBoxColumn";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.database1DataSet;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.clientDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.tipDataGridViewTextBoxColumn1,
            this.totalDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.ordersBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(433, 812);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(21, 43);
            this.dataGridView3.TabIndex = 15;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // tipDataGridViewTextBoxColumn1
            // 
            this.tipDataGridViewTextBoxColumn1.DataPropertyName = "Tip";
            this.tipDataGridViewTextBoxColumn1.HeaderText = "Tip";
            this.tipDataGridViewTextBoxColumn1.Name = "tipDataGridViewTextBoxColumn1";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.database1DataSet;
            // 
            // flowLayoutPanelProduse
            // 
            this.flowLayoutPanelProduse.AutoScroll = true;
            this.flowLayoutPanelProduse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanelProduse.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelProduse.Location = new System.Drawing.Point(6, 12);
            this.flowLayoutPanelProduse.Name = "flowLayoutPanelProduse";
            this.flowLayoutPanelProduse.Size = new System.Drawing.Size(365, 482);
            this.flowLayoutPanelProduse.TabIndex = 16;
            this.flowLayoutPanelProduse.WrapContents = false;
            // 
            // flowLayoutPanelCos
            // 
            this.flowLayoutPanelCos.AutoScroll = true;
            this.flowLayoutPanelCos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanelCos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelCos.Location = new System.Drawing.Point(380, 48);
            this.flowLayoutPanelCos.Name = "flowLayoutPanelCos";
            this.flowLayoutPanelCos.Size = new System.Drawing.Size(417, 191);
            this.flowLayoutPanelCos.TabIndex = 17;
            this.flowLayoutPanelCos.WrapContents = false;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(377, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cos de Cumparaturi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn3,
            this.comandaIdDataGridViewTextBoxColumn,
            this.produsIdDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn,
            this.pretUnitDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.orderItemsBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(330, 810);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(32, 41);
            this.dataGridView4.TabIndex = 19;
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            this.idDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // comandaIdDataGridViewTextBoxColumn
            // 
            this.comandaIdDataGridViewTextBoxColumn.DataPropertyName = "ComandaId";
            this.comandaIdDataGridViewTextBoxColumn.HeaderText = "ComandaId";
            this.comandaIdDataGridViewTextBoxColumn.Name = "comandaIdDataGridViewTextBoxColumn";
            // 
            // produsIdDataGridViewTextBoxColumn
            // 
            this.produsIdDataGridViewTextBoxColumn.DataPropertyName = "ProdusId";
            this.produsIdDataGridViewTextBoxColumn.HeaderText = "ProdusId";
            this.produsIdDataGridViewTextBoxColumn.Name = "produsIdDataGridViewTextBoxColumn";
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            // 
            // pretUnitDataGridViewTextBoxColumn
            // 
            this.pretUnitDataGridViewTextBoxColumn.DataPropertyName = "PretUnit";
            this.pretUnitDataGridViewTextBoxColumn.HeaderText = "PretUnit";
            this.pretUnitDataGridViewTextBoxColumn.Name = "pretUnitDataGridViewTextBoxColumn";
            // 
            // orderItemsBindingSource
            // 
            this.orderItemsBindingSource.DataMember = "OrderItems";
            this.orderItemsBindingSource.DataSource = this.database1DataSet;
            // 
            // flowLayoutPanelComenzi
            // 
            this.flowLayoutPanelComenzi.AutoScroll = true;
            this.flowLayoutPanelComenzi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanelComenzi.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelComenzi.Location = new System.Drawing.Point(380, 303);
            this.flowLayoutPanelComenzi.Name = "flowLayoutPanelComenzi";
            this.flowLayoutPanelComenzi.Size = new System.Drawing.Size(417, 191);
            this.flowLayoutPanelComenzi.TabIndex = 18;
            this.flowLayoutPanelComenzi.Visible = false;
            this.flowLayoutPanelComenzi.WrapContents = false;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn4,
            this.numeDataGridViewTextBoxColumn2,
            this.descriereDataGridViewTextBoxColumn1,
            this.managerIdDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.promotionsBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(523, 810);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(13, 41);
            this.dataGridView5.TabIndex = 20;
            // 
            // idDataGridViewTextBoxColumn4
            // 
            this.idDataGridViewTextBoxColumn4.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn4.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn4.Name = "idDataGridViewTextBoxColumn4";
            this.idDataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // numeDataGridViewTextBoxColumn2
            // 
            this.numeDataGridViewTextBoxColumn2.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn2.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn2.Name = "numeDataGridViewTextBoxColumn2";
            // 
            // descriereDataGridViewTextBoxColumn1
            // 
            this.descriereDataGridViewTextBoxColumn1.DataPropertyName = "Descriere";
            this.descriereDataGridViewTextBoxColumn1.HeaderText = "Descriere";
            this.descriereDataGridViewTextBoxColumn1.Name = "descriereDataGridViewTextBoxColumn1";
            // 
            // managerIdDataGridViewTextBoxColumn
            // 
            this.managerIdDataGridViewTextBoxColumn.DataPropertyName = "ManagerId";
            this.managerIdDataGridViewTextBoxColumn.HeaderText = "ManagerId";
            this.managerIdDataGridViewTextBoxColumn.Name = "managerIdDataGridViewTextBoxColumn";
            // 
            // promotionsBindingSource
            // 
            this.promotionsBindingSource.DataMember = "Promotions";
            this.promotionsBindingSource.DataSource = this.database1DataSet;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn5,
            this.promotionIdDataGridViewTextBoxColumn,
            this.produsIdDataGridViewTextBoxColumn1});
            this.dataGridView6.DataSource = this.promotionsItemsBindingSource;
            this.dataGridView6.Location = new System.Drawing.Point(542, 810);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(13, 43);
            this.dataGridView6.TabIndex = 21;
            // 
            // idDataGridViewTextBoxColumn5
            // 
            this.idDataGridViewTextBoxColumn5.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn5.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn5.Name = "idDataGridViewTextBoxColumn5";
            this.idDataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // promotionIdDataGridViewTextBoxColumn
            // 
            this.promotionIdDataGridViewTextBoxColumn.DataPropertyName = "PromotionId";
            this.promotionIdDataGridViewTextBoxColumn.HeaderText = "PromotionId";
            this.promotionIdDataGridViewTextBoxColumn.Name = "promotionIdDataGridViewTextBoxColumn";
            // 
            // produsIdDataGridViewTextBoxColumn1
            // 
            this.produsIdDataGridViewTextBoxColumn1.DataPropertyName = "ProdusId";
            this.produsIdDataGridViewTextBoxColumn1.HeaderText = "ProdusId";
            this.produsIdDataGridViewTextBoxColumn1.Name = "produsIdDataGridViewTextBoxColumn1";
            // 
            // promotionsItemsBindingSource
            // 
            this.promotionsItemsBindingSource.DataMember = "PromotionsItems";
            this.promotionsItemsBindingSource.DataSource = this.database1DataSet;
            // 
            // dataGridView7
            // 
            this.dataGridView7.AutoGenerateColumns = false;
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn6,
            this.clientIdDataGridViewTextBoxColumn,
            this.descriereProblemaDataGridViewTextBoxColumn,
            this.dataPreferataDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn1});
            this.dataGridView7.DataSource = this.serviceRequestBindingSource;
            this.dataGridView7.Location = new System.Drawing.Point(489, 812);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.Size = new System.Drawing.Size(28, 39);
            this.dataGridView7.TabIndex = 22;
            // 
            // idDataGridViewTextBoxColumn6
            // 
            this.idDataGridViewTextBoxColumn6.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn6.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn6.Name = "idDataGridViewTextBoxColumn6";
            this.idDataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            this.clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            // 
            // descriereProblemaDataGridViewTextBoxColumn
            // 
            this.descriereProblemaDataGridViewTextBoxColumn.DataPropertyName = "DescriereProblema";
            this.descriereProblemaDataGridViewTextBoxColumn.HeaderText = "DescriereProblema";
            this.descriereProblemaDataGridViewTextBoxColumn.Name = "descriereProblemaDataGridViewTextBoxColumn";
            // 
            // dataPreferataDataGridViewTextBoxColumn
            // 
            this.dataPreferataDataGridViewTextBoxColumn.DataPropertyName = "DataPreferata";
            this.dataPreferataDataGridViewTextBoxColumn.HeaderText = "DataPreferata";
            this.dataPreferataDataGridViewTextBoxColumn.Name = "dataPreferataDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            // 
            // serviceRequestBindingSource
            // 
            this.serviceRequestBindingSource.DataMember = "ServiceRequest";
            this.serviceRequestBindingSource.DataSource = this.database1DataSet;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 525);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 23);
            this.textBox1.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 565);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 23);
            this.textBox2.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 528);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "User:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 571);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Parola:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(624, 664);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 60);
            this.button1.TabIndex = 27;
            this.button1.Text = "Adaugare Produs";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnViewEmployees);
            this.groupBox1.Controls.Add(this.btnAddPromotion);
            this.groupBox1.Controls.Add(this.btnAddEmployee);
            this.groupBox1.Location = new System.Drawing.Point(506, 524);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 118);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(23, 654);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 30);
            this.button3.TabIndex = 30;
            this.button3.Text = "Cerere Service";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(235, 520);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 209);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(44, 164);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 30);
            this.button4.TabIndex = 11;
            this.button4.Text = "Confirmare";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 121);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(200, 57);
            this.richTextBox1.TabIndex = 28;
            this.richTextBox1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Descriere:";
            // 
            // groupBoxAddProduct
            // 
            this.groupBoxAddProduct.Controls.Add(this.btnAddProduct);
            this.groupBoxAddProduct.Controls.Add(this.cmbProdusSubcategorie);
            this.groupBoxAddProduct.Controls.Add(this.cmbProdusCategorie);
            this.groupBoxAddProduct.Controls.Add(this.txtProdusDescriere);
            this.groupBoxAddProduct.Controls.Add(this.txtProdusPret);
            this.groupBoxAddProduct.Controls.Add(this.txtProdusNume);
            this.groupBoxAddProduct.ForeColor = System.Drawing.Color.Cornsilk;
            this.groupBoxAddProduct.Location = new System.Drawing.Point(235, 528);
            this.groupBoxAddProduct.Name = "groupBoxAddProduct";
            this.groupBoxAddProduct.Size = new System.Drawing.Size(250, 201);
            this.groupBoxAddProduct.TabIndex = 30;
            this.groupBoxAddProduct.TabStop = false;
            this.groupBoxAddProduct.Text = "AdaugareProdus";
            this.groupBoxAddProduct.Visible = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(44, 166);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(157, 23);
            this.btnAddProduct.TabIndex = 5;
            this.btnAddProduct.Text = "Adauga produsul";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // cmbProdusSubcategorie
            // 
            this.cmbProdusSubcategorie.FormattingEnabled = true;
            this.cmbProdusSubcategorie.Location = new System.Drawing.Point(129, 113);
            this.cmbProdusSubcategorie.Name = "cmbProdusSubcategorie";
            this.cmbProdusSubcategorie.Size = new System.Drawing.Size(103, 23);
            this.cmbProdusSubcategorie.TabIndex = 4;
            this.cmbProdusSubcategorie.Text = "Subcategorie";
            // 
            // cmbProdusCategorie
            // 
            this.cmbProdusCategorie.FormattingEnabled = true;
            this.cmbProdusCategorie.Location = new System.Drawing.Point(16, 113);
            this.cmbProdusCategorie.Name = "cmbProdusCategorie";
            this.cmbProdusCategorie.Size = new System.Drawing.Size(100, 23);
            this.cmbProdusCategorie.TabIndex = 3;
            this.cmbProdusCategorie.Text = "Categorie";
            // 
            // txtProdusDescriere
            // 
            this.txtProdusDescriere.Location = new System.Drawing.Point(16, 73);
            this.txtProdusDescriere.Name = "txtProdusDescriere";
            this.txtProdusDescriere.Size = new System.Drawing.Size(216, 23);
            this.txtProdusDescriere.TabIndex = 2;
            this.txtProdusDescriere.Text = "Descriere";
            // 
            // txtProdusPret
            // 
            this.txtProdusPret.Location = new System.Drawing.Point(132, 35);
            this.txtProdusPret.Name = "txtProdusPret";
            this.txtProdusPret.Size = new System.Drawing.Size(100, 23);
            this.txtProdusPret.TabIndex = 1;
            this.txtProdusPret.Text = "Pret";
            // 
            // txtProdusNume
            // 
            this.txtProdusNume.Location = new System.Drawing.Point(16, 35);
            this.txtProdusNume.Name = "txtProdusNume";
            this.txtProdusNume.Size = new System.Drawing.Size(100, 23);
            this.txtProdusNume.TabIndex = 0;
            this.txtProdusNume.Text = "Nume";
            // 
            // groupBoxAddAngajat
            // 
            this.groupBoxAddAngajat.Controls.Add(this.btnAddAngajat);
            this.groupBoxAddAngajat.Controls.Add(this.cmbTipAngajat);
            this.groupBoxAddAngajat.Controls.Add(this.txtParolaAngajat);
            this.groupBoxAddAngajat.Controls.Add(this.txtNumeAngajat);
            this.groupBoxAddAngajat.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.groupBoxAddAngajat.Location = new System.Drawing.Point(235, 534);
            this.groupBoxAddAngajat.Name = "groupBoxAddAngajat";
            this.groupBoxAddAngajat.Size = new System.Drawing.Size(250, 194);
            this.groupBoxAddAngajat.TabIndex = 6;
            this.groupBoxAddAngajat.TabStop = false;
            this.groupBoxAddAngajat.Text = "AdaugareAngajat";
            this.groupBoxAddAngajat.Visible = false;
            // 
            // btnAddAngajat
            // 
            this.btnAddAngajat.ForeColor = System.Drawing.Color.Black;
            this.btnAddAngajat.Location = new System.Drawing.Point(80, 149);
            this.btnAddAngajat.Name = "btnAddAngajat";
            this.btnAddAngajat.Size = new System.Drawing.Size(100, 23);
            this.btnAddAngajat.TabIndex = 3;
            this.btnAddAngajat.Text = "Adaugare";
            this.btnAddAngajat.UseVisualStyleBackColor = true;
            this.btnAddAngajat.Click += new System.EventHandler(this.btnAddAngajat_Click);
            // 
            // cmbTipAngajat
            // 
            this.cmbTipAngajat.FormattingEnabled = true;
            this.cmbTipAngajat.Location = new System.Drawing.Point(13, 81);
            this.cmbTipAngajat.Name = "cmbTipAngajat";
            this.cmbTipAngajat.Size = new System.Drawing.Size(100, 23);
            this.cmbTipAngajat.TabIndex = 2;
            this.cmbTipAngajat.Text = "Tip";
            // 
            // txtParolaAngajat
            // 
            this.txtParolaAngajat.Location = new System.Drawing.Point(129, 33);
            this.txtParolaAngajat.Name = "txtParolaAngajat";
            this.txtParolaAngajat.Size = new System.Drawing.Size(100, 23);
            this.txtParolaAngajat.TabIndex = 1;
            this.txtParolaAngajat.Text = "Parola";
            // 
            // txtNumeAngajat
            // 
            this.txtNumeAngajat.Location = new System.Drawing.Point(13, 33);
            this.txtNumeAngajat.Name = "txtNumeAngajat";
            this.txtNumeAngajat.Size = new System.Drawing.Size(100, 23);
            this.txtNumeAngajat.TabIndex = 0;
            this.txtNumeAngajat.Text = "Nume";
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrderItemsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.PromotionsItemsTableAdapter = null;
            this.tableAdapterManager.PromotionsTableAdapter = null;
            this.tableAdapterManager.ServiceRequestTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MagazOnline.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // orderItemsTableAdapter
            // 
            this.orderItemsTableAdapter.ClearBeforeFill = true;
            // 
            // promotionsTableAdapter
            // 
            this.promotionsTableAdapter.ClearBeforeFill = true;
            // 
            // promotionsItemsTableAdapter
            // 
            this.promotionsItemsTableAdapter.ClearBeforeFill = true;
            // 
            // serviceRequestTableAdapter
            // 
            this.serviceRequestTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.clbPromotiiExistente);
            this.groupBox3.Controls.Add(this.btnDeletePromo);
            this.groupBox3.Controls.Add(this.btnAddPromo);
            this.groupBox3.Controls.Add(this.clbPromoProduse);
            this.groupBox3.Controls.Add(this.txtPromoDescriere);
            this.groupBox3.Controls.Add(this.txtPromoNume);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(213, 500);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(287, 231);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Promotii";
            this.groupBox3.Visible = false;
            // 
            // clbPromotiiExistente
            // 
            this.clbPromotiiExistente.FormattingEnabled = true;
            this.clbPromotiiExistente.Location = new System.Drawing.Point(152, 79);
            this.clbPromotiiExistente.Name = "clbPromotiiExistente";
            this.clbPromotiiExistente.Size = new System.Drawing.Size(120, 94);
            this.clbPromotiiExistente.TabIndex = 5;
            // 
            // btnDeletePromo
            // 
            this.btnDeletePromo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeletePromo.Location = new System.Drawing.Point(163, 188);
            this.btnDeletePromo.Name = "btnDeletePromo";
            this.btnDeletePromo.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePromo.TabIndex = 4;
            this.btnDeletePromo.Text = "Sterge";
            this.btnDeletePromo.UseVisualStyleBackColor = true;
            this.btnDeletePromo.Click += new System.EventHandler(this.btnDeletePromo_Click);
            // 
            // btnAddPromo
            // 
            this.btnAddPromo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddPromo.Location = new System.Drawing.Point(31, 188);
            this.btnAddPromo.Name = "btnAddPromo";
            this.btnAddPromo.Size = new System.Drawing.Size(75, 23);
            this.btnAddPromo.TabIndex = 3;
            this.btnAddPromo.Text = "Adauga";
            this.btnAddPromo.UseVisualStyleBackColor = true;
            this.btnAddPromo.Click += new System.EventHandler(this.btnAddPromo_Click);
            // 
            // clbPromoProduse
            // 
            this.clbPromoProduse.FormattingEnabled = true;
            this.clbPromoProduse.Location = new System.Drawing.Point(13, 79);
            this.clbPromoProduse.Name = "clbPromoProduse";
            this.clbPromoProduse.Size = new System.Drawing.Size(120, 94);
            this.clbPromoProduse.TabIndex = 2;
            // 
            // txtPromoDescriere
            // 
            this.txtPromoDescriere.Location = new System.Drawing.Point(156, 42);
            this.txtPromoDescriere.Name = "txtPromoDescriere";
            this.txtPromoDescriere.Size = new System.Drawing.Size(100, 23);
            this.txtPromoDescriere.TabIndex = 1;
            this.txtPromoDescriere.Text = "Descriere";
            // 
            // txtPromoNume
            // 
            this.txtPromoNume.Location = new System.Drawing.Point(23, 42);
            this.txtPromoNume.Name = "txtPromoNume";
            this.txtPromoNume.Size = new System.Drawing.Size(100, 23);
            this.txtPromoNume.TabIndex = 0;
            this.txtPromoNume.Text = "Nume Promotie";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(896, 741);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxAddAngajat);
            this.Controls.Add(this.groupBoxAddProduct);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView7);
            this.Controls.Add(this.dataGridView6);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.flowLayoutPanelComenzi);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanelCos);
            this.Controls.Add(this.flowLayoutPanelProduse);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelOrders);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnLogin);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "MagazOnline - Management Producție";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionsItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceRequestBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxAddProduct.ResumeLayout(false);
            this.groupBoxAddProduct.PerformLayout();
            this.groupBoxAddAngajat.ResumeLayout(false);
            this.groupBoxAddAngajat.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Database1DataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn;
        private Database1DataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private Database1DataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcategorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPreasamblatDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProduse;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource orderItemsBindingSource;
        private Database1DataSetTableAdapters.OrderItemsTableAdapter orderItemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn comandaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produsIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelComenzi;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.BindingSource promotionsBindingSource;
        private Database1DataSetTableAdapters.PromotionsTableAdapter promotionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriereDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.BindingSource promotionsItemsBindingSource;
        private Database1DataSetTableAdapters.PromotionsItemsTableAdapter promotionsItemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn promotionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produsIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.BindingSource serviceRequestBindingSource;
        private Database1DataSetTableAdapters.ServiceRequestTableAdapter serviceRequestTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriereProblemaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPreferataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxAddProduct;
        private System.Windows.Forms.TextBox txtProdusNume;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ComboBox cmbProdusSubcategorie;
        private System.Windows.Forms.ComboBox cmbProdusCategorie;
        private System.Windows.Forms.TextBox txtProdusDescriere;
        private System.Windows.Forms.TextBox txtProdusPret;
        private System.Windows.Forms.GroupBox groupBoxAddAngajat;
        private System.Windows.Forms.Button btnAddAngajat;
        private System.Windows.Forms.ComboBox cmbTipAngajat;
        private System.Windows.Forms.TextBox txtParolaAngajat;
        private System.Windows.Forms.TextBox txtNumeAngajat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPromoDescriere;
        private System.Windows.Forms.TextBox txtPromoNume;
        private System.Windows.Forms.Button btnAddPromo;
        private System.Windows.Forms.CheckedListBox clbPromoProduse;
        private System.Windows.Forms.Button btnDeletePromo;
        private System.Windows.Forms.CheckedListBox clbPromotiiExistente;
    }
}