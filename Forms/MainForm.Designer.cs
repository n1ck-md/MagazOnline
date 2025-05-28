namespace MagazOnline.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Panel panelCart;
        private System.Windows.Forms.Label labelCart;
        private System.Windows.Forms.ListBox listBoxOrders;
        private System.Windows.Forms.Label labelOrders;
        private System.Windows.Forms.Button btnAddPromotion;
        private System.Windows.Forms.Button btnRemovePromotion;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnViewEmployees;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnRemoveOrders;
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
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.panelCart = new System.Windows.Forms.Panel();
            this.labelCart = new System.Windows.Forms.Label();
            this.listBoxOrders = new System.Windows.Forms.ListBox();
            this.labelOrders = new System.Windows.Forms.Label();
            this.btnAddPromotion = new System.Windows.Forms.Button();
            this.btnRemovePromotion = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnViewEmployees = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnRemoveOrders = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.listBoxProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxProducts.ForeColor = System.Drawing.Color.White;
            this.listBoxProducts.ItemHeight = 15;
            this.listBoxProducts.Location = new System.Drawing.Point(20, 20);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(320, 497);
            this.listBoxProducts.TabIndex = 0;
            // 
            // panelCart
            // 
            this.panelCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelCart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCart.Controls.Add(this.labelCart);
            this.panelCart.Location = new System.Drawing.Point(360, 20);
            this.panelCart.Name = "panelCart";
            this.panelCart.Size = new System.Drawing.Size(420, 250);
            this.panelCart.TabIndex = 1;
            // 
            // labelCart
            // 
            this.labelCart.ForeColor = System.Drawing.Color.White;
            this.labelCart.Location = new System.Drawing.Point(10, 10);
            this.labelCart.Name = "labelCart";
            this.labelCart.Size = new System.Drawing.Size(120, 20);
            this.labelCart.TabIndex = 0;
            this.labelCart.Text = "Coș Cumpărături";
            // 
            // listBoxOrders
            // 
            this.listBoxOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.listBoxOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxOrders.ForeColor = System.Drawing.Color.White;
            this.listBoxOrders.ItemHeight = 15;
            this.listBoxOrders.Location = new System.Drawing.Point(360, 300);
            this.listBoxOrders.Name = "listBoxOrders";
            this.listBoxOrders.Size = new System.Drawing.Size(420, 212);
            this.listBoxOrders.TabIndex = 2;
            // 
            // labelOrders
            // 
            this.labelOrders.ForeColor = System.Drawing.Color.White;
            this.labelOrders.Location = new System.Drawing.Point(360, 280);
            this.labelOrders.Name = "labelOrders";
            this.labelOrders.Size = new System.Drawing.Size(180, 20);
            this.labelOrders.TabIndex = 3;
            this.labelOrders.Text = "Comenzi și Cereri Service";
            // 
            // btnAddPromotion
            // 
            this.btnAddPromotion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAddPromotion.FlatAppearance.BorderSize = 0;
            this.btnAddPromotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPromotion.ForeColor = System.Drawing.Color.White;
            this.btnAddPromotion.Location = new System.Drawing.Point(20, 530);
            this.btnAddPromotion.Name = "btnAddPromotion";
            this.btnAddPromotion.Size = new System.Drawing.Size(150, 30);
            this.btnAddPromotion.TabIndex = 4;
            this.btnAddPromotion.Text = "Adăuga Promoții";
            this.btnAddPromotion.UseVisualStyleBackColor = false;
            // 
            // btnRemovePromotion
            // 
            this.btnRemovePromotion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnRemovePromotion.FlatAppearance.BorderSize = 0;
            this.btnRemovePromotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePromotion.ForeColor = System.Drawing.Color.White;
            this.btnRemovePromotion.Location = new System.Drawing.Point(190, 530);
            this.btnRemovePromotion.Name = "btnRemovePromotion";
            this.btnRemovePromotion.Size = new System.Drawing.Size(150, 30);
            this.btnRemovePromotion.TabIndex = 5;
            this.btnRemovePromotion.Text = "Șterge Promoții";
            this.btnRemovePromotion.UseVisualStyleBackColor = false;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(20, 570);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(150, 30);
            this.btnAddToCart.TabIndex = 6;
            this.btnAddToCart.Text = "Adauga în Coș";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnRemoveFromCart.FlatAppearance.BorderSize = 0;
            this.btnRemoveFromCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFromCart.ForeColor = System.Drawing.Color.White;
            this.btnRemoveFromCart.Location = new System.Drawing.Point(190, 570);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(150, 30);
            this.btnRemoveFromCart.TabIndex = 7;
            this.btnRemoveFromCart.Text = "Elimină din Coș";
            this.btnRemoveFromCart.UseVisualStyleBackColor = false;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnPlaceOrder.FlatAppearance.BorderSize = 0;
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.Location = new System.Drawing.Point(20, 610);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(150, 30);
            this.btnPlaceOrder.TabIndex = 8;
            this.btnPlaceOrder.Text = "Plasează Comandă";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            // 
            // btnViewEmployees
            // 
            this.btnViewEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnViewEmployees.FlatAppearance.BorderSize = 0;
            this.btnViewEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewEmployees.ForeColor = System.Drawing.Color.White;
            this.btnViewEmployees.Location = new System.Drawing.Point(190, 610);
            this.btnViewEmployees.Name = "btnViewEmployees";
            this.btnViewEmployees.Size = new System.Drawing.Size(150, 30);
            this.btnViewEmployees.TabIndex = 9;
            this.btnViewEmployees.Text = "Vizualizare Angajați";
            this.btnViewEmployees.UseVisualStyleBackColor = false;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAddEmployee.Location = new System.Drawing.Point(20, 650);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(150, 30);
            this.btnAddEmployee.TabIndex = 10;
            this.btnAddEmployee.Text = "Cere Angajat";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            // 
            // btnRemoveOrders
            // 
            this.btnRemoveOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnRemoveOrders.FlatAppearance.BorderSize = 0;
            this.btnRemoveOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveOrders.ForeColor = System.Drawing.Color.White;
            this.btnRemoveOrders.Location = new System.Drawing.Point(190, 650);
            this.btnRemoveOrders.Name = "btnRemoveOrders";
            this.btnRemoveOrders.Size = new System.Drawing.Size(150, 30);
            this.btnRemoveOrders.TabIndex = 11;
            this.btnRemoveOrders.Text = "Șterge Comenzi";
            this.btnRemoveOrders.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(20, 690);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 30);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(689, 561);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(41, 30);
            this.dataGridView1.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 730);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.panelCart);
            this.Controls.Add(this.listBoxOrders);
            this.Controls.Add(this.labelOrders);
            this.Controls.Add(this.btnAddPromotion);
            this.Controls.Add(this.btnRemovePromotion);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnRemoveFromCart);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnViewEmployees);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnRemoveOrders);
            this.Controls.Add(this.btnLogin);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "MagazOnline - Management Producție";
            this.panelCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dataGridView1;
    }
}