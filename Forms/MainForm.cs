using MagazOnline.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazOnline.Forms
{
    public partial class MainForm : Form
    {
        private bool isLoggedIn = false;
        private List<string> cartItems = new List<string>();
        string userRole = "";
        int IDcont = 1;



        private void AfiseazaProduse()
        {
            flowLayoutPanelProduse.Controls.Clear();

            foreach (DataRow row in database1DataSet.Products.Rows)
            {
                Panel produsCard = new Panel();
                produsCard.Size = new Size(300, 180);
                produsCard.Margin = new Padding(10);
                produsCard.BackColor = Color.FromArgb(30, 30, 30);
                produsCard.BorderStyle = BorderStyle.FixedSingle;

                // Nume
                Label lblNume = new Label();
                lblNume.Text = row["Nume"].ToString();
                lblNume.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                lblNume.ForeColor = Color.White;
                lblNume.Location = new Point(10, 10);
                lblNume.AutoSize = true;

                // Pret
                Label lblPret = new Label();
                lblPret.Text = "Preț: " + row["Pret"].ToString() + " RON";
                lblPret.ForeColor = Color.LightGreen;
                lblPret.Location = new Point(10, 40);
                lblPret.AutoSize = true;

                // Descriere
                Label lblDescriere = new Label();
                lblDescriere.Text = row["Descriere"].ToString();
                lblDescriere.ForeColor = Color.LightGray;
                lblDescriere.Location = new Point(10, 70);
                lblDescriere.Size = new Size(280, 60);
                lblDescriere.AutoEllipsis = true;

                // Rating
                Label lblRating = new Label();
                lblRating.Text = "Rating: " + row["Rating"].ToString() + " ★";
                lblRating.ForeColor = Color.Gold;
                lblRating.Location = new Point(10, 135);
                lblRating.AutoSize = true;

                // Buton Adauga
                Button btnAdauga = new Button();
                btnAdauga.Text = "Adaugă în coș";
                btnAdauga.ForeColor = Color.White;
                btnAdauga.Location = new Point(180, 130);
                btnAdauga.Click += (s, e) =>
                {
                    cartItems.Add(row["Nume"].ToString());
                    UpdateCartDisplay();
                };

                // Adăugare controale
                produsCard.Controls.Add(lblNume);
                produsCard.Controls.Add(lblPret);
                produsCard.Controls.Add(lblDescriere);
                produsCard.Controls.Add(lblRating);
                produsCard.Controls.Add(btnAdauga);

                flowLayoutPanelProduse.Controls.Add(produsCard);
            }

            foreach (DataRow promoRow in database1DataSet.Promotions.Rows)
            {
                int promoId = promoRow.Field<int>("Id");
                string numePromo = promoRow.Field<string>("Nume");
                string descrierePromo = promoRow.Field<string>("Descriere");

                var produseInPromo = database1DataSet.PromotionsItems.AsEnumerable()
                    .Where(pi => pi.Field<int>("PromotionId") == promoId)
                    .Select(pi => pi.Field<int>("ProdusId"))
                    .ToList();

                var produseDetalii = database1DataSet.Products.AsEnumerable()
                    .Where(p => produseInPromo.Contains(p.Field<int>("Id")))
                    .ToList();

                double totalValoare = produseDetalii.Sum(p => p.Field<double>("Pret"));
                double discount = totalValoare * 0.10;

                Panel promoCard = new Panel();
                promoCard.Size = new Size(300, 200);
                promoCard.Margin = new Padding(10);
                promoCard.BackColor = Color.FromArgb(50, 30, 30);
                promoCard.BorderStyle = BorderStyle.FixedSingle;

                Label lblNume = new Label();
                lblNume.Text = $"[PROMO] {numePromo}";
                lblNume.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                lblNume.ForeColor = Color.LightPink;
                lblNume.Location = new Point(10, 10);
                lblNume.AutoSize = true;

                Label lblDescriere = new Label();
                lblDescriere.Text = descrierePromo;
                lblDescriere.ForeColor = Color.WhiteSmoke;
                lblDescriere.Location = new Point(10, 40);
                lblDescriere.Size = new Size(280, 40);

                Label lblProduse = new Label();
                lblProduse.Text = "Include: " + string.Join(", ", produseDetalii.Select(p => p.Field<string>("Nume")));
                lblProduse.ForeColor = Color.LightGray;
                lblProduse.Location = new Point(10, 85);
                lblProduse.Size = new Size(280, 60);

                Label lblDiscount = new Label();
                lblDiscount.Text = $"Reducere: -{discount:0.00} RON";
                lblDiscount.ForeColor = Color.LightGreen;
                lblDiscount.Location = new Point(10, 150);
                lblDiscount.AutoSize = true;

                Button btnAdaugaPromo = new Button();
                btnAdaugaPromo.Text = "Adaugă promoția";
                btnAdaugaPromo.ForeColor = Color.White;
                btnAdaugaPromo.BackColor = Color.DarkGreen;
                btnAdaugaPromo.Location = new Point(150, 150);
                btnAdaugaPromo.Click += (s, e) =>
                {
                    foreach (var p in produseDetalii)
                    {
                        string nume = p.Field<string>("Nume");
                        cartItems.Add("[PROMO] " + nume); // marcăm că e cu promoție
                    }

                    UpdateCartDisplay();
                };

                promoCard.Controls.Add(lblNume);
                promoCard.Controls.Add(lblDescriere);
                promoCard.Controls.Add(lblProduse);
                promoCard.Controls.Add(lblDiscount);
                promoCard.Controls.Add(btnAdaugaPromo);

                flowLayoutPanelProduse.Controls.Add(promoCard);
            }
        }

        private void UpdateCartDisplay()
        {
            flowLayoutPanelCos.Controls.Clear();

            foreach (string produs in cartItems)
            {
                Panel panelItem = new Panel();
                panelItem.Height = 30;
                panelItem.Width = flowLayoutPanelCos.Width - 25;
                panelItem.BackColor = Color.FromArgb(40, 40, 40);
                panelItem.Margin = new Padding(3);

                Label lbl = new Label();
                lbl.Text = produs.Replace("[PROMO] ", "");
                lbl.ForeColor = Color.White;
                lbl.AutoSize = false;
                lbl.TextAlign = ContentAlignment.MiddleLeft;
                lbl.Width = panelItem.Width - 30;
                lbl.Location = new Point(5, 5);

                Button btnRemove = new Button();
                btnRemove.Text = "X";
                btnRemove.ForeColor = Color.White;
                btnRemove.BackColor = Color.Red;
                btnRemove.FlatStyle = FlatStyle.Flat;
                btnRemove.Size = new Size(25, 25);
                btnRemove.Location = new Point(panelItem.Width - 30, 2);
                btnRemove.Tag = produs;  // folosim Tag să știm ce să ștergem

                btnRemove.Click += (s, e) =>
                {
                    string produsDeEliminat = (string)((Button)s).Tag;
                    cartItems.Remove(produsDeEliminat);
                    UpdateCartDisplay();
                };

                panelItem.Controls.Add(lbl);
                panelItem.Controls.Add(btnRemove);

                flowLayoutPanelCos.Controls.Add(panelItem);
            }
        }

        private void UpdateComenziDisplay()
        {
            flowLayoutPanelComenzi.Controls.Clear();

            foreach (DataRow orderRow in database1DataSet.Orders.Rows)
            {
                int orderId = orderRow.Field<int>("Id");
                int clientId = orderRow.Field<int>("Client");
                DateTime data = orderRow.Field<DateTime?>("Data") ?? DateTime.MinValue;
                string status = orderRow.Field<string>("Status") ?? "Necunoscut";
                string tip = orderRow.Field<string>("Tip") ?? "Necunoscut";

                // --- 1) Header comandă / service ---
                string numeClient = "Client necunoscut";
                var clientRow = database1DataSet.Users.AsEnumerable()
                    .FirstOrDefault(u => u.Field<int>("Id") == clientId);
                if (clientRow != null)
                    numeClient = clientRow.Field<string>("Nume");

                Label lblHeader = new Label
                {
                    ForeColor = Color.LightBlue,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Text = tip == "Service"
                                ? $"[SERVICE] Cerere #{orderId} – {numeClient} – {data:g}"
                                : $"Comanda #{orderId} – {numeClient} – {data:g} – Status: {status}"
                };
                flowLayoutPanelComenzi.Controls.Add(lblHeader);

                // --- 2) Dacă e service, afișăm descrierea ---
                if (tip == "Service")
                {
                    var srv = database1DataSet.ServiceRequest.AsEnumerable()
                        .FirstOrDefault(sr =>
                            sr.Field<int>("ClientId") == clientId &&
                            sr.Field<DateTime>("DataPreferata").Date == data.Date);

                    string descr = srv?.Field<string>("DescriereProblema") ?? "N/A";
                    flowLayoutPanelComenzi.Controls.Add(new Label
                    {
                        ForeColor = Color.WhiteSmoke,
                        AutoSize = true,
                        Text = $"  • Descriere: {descr}"
                    });
                }
                else
                {
                    // --- 3) Comandă normală: calculăm subtotal & discount, afișăm doar produsele ---
                    double subtotal = 0.0;
                    double totalDisc = 0.0;

                    var items = database1DataSet.OrderItems.AsEnumerable()
                        .Where(r => r.Field<int>("ComandaId") == orderId);

                    foreach (var it in items)
                    {
                        double pretUnit = it.Field<double>("PretUnit");
                        int cant = it.Field<int>("Cantitate");
                        int? maybeProdId = it.Field<int?>("ProdusId");

                        // Detectăm discount: fie pret negativ, fie ProdusId null
                        if (pretUnit < 0 || !maybeProdId.HasValue)
                        {
                            totalDisc += pretUnit * cant;
                            continue;  // nu afișăm linia de discount
                        }

                        // Altfel e produs normal
                        int produsId = maybeProdId.Value;
                        var prodRow = database1DataSet.Products.AsEnumerable()
                            .FirstOrDefault(p => p.Field<int>("Id") == produsId);

                        string numeProd = prodRow?.Field<string>("Nume") ?? "Produs necunoscut";
                        bool estePreasamblat = false;

                        if (prodRow != null)
                        {
                            // Verificăm dacă produsul e preasamblat
                            estePreasamblat = prodRow.Field<bool>("IsPreasamblat");
                        }

                        double subtotalProdus = pretUnit * cant;
                        subtotal += subtotalProdus;

                        flowLayoutPanelComenzi.Controls.Add(new Label
                        {
                            ForeColor = Color.WhiteSmoke,
                            AutoSize = true,
                            Text = $"  • {numeProd} x {cant} @ {pretUnit:0.00} RON = {subtotalProdus:0.00} RON"
                        });

                        if (estePreasamblat)
                        {
                            double taxa = 100 * cant;
                            subtotal += taxa;
                            flowLayoutPanelComenzi.Controls.Add(new Label
                            {
                                ForeColor = Color.Orange,
                                AutoSize = true,
                                Text = $"      ↳ Taxă preasamblare: {taxa:0.00} RON"
                            });
                        }

                    }

                    // --- 4) Afișăm subtotal, discount (dacă există) și total ---
                    flowLayoutPanelComenzi.Controls.Add(new Label
                    {
                        ForeColor = Color.LightGray,
                        AutoSize = true,
                        Text = $"Subtotal: {subtotal:0.00} RON"
                    });

                    if (totalDisc < 0)
                    {
                        flowLayoutPanelComenzi.Controls.Add(new Label
                        {
                            ForeColor = Color.LightGreen,
                            AutoSize = true,
                            Text = $"Reducere promoție: {totalDisc:0.00} RON"
                        });
                    }

                    flowLayoutPanelComenzi.Controls.Add(new Label
                    {
                        ForeColor = Color.WhiteSmoke,
                        AutoSize = true,
                        Font = new Font("Segoe UI", 10, FontStyle.Bold),
                        Text = $"Total: {(subtotal + totalDisc):0.00} RON"
                    });

                    // --- 5) Buton schimbă status ---
                    var btnSchimb = new Button
                    {
                        Text = "Schimbă status",
                        Tag = orderId,
                        AutoSize = true,
                        BackColor = Color.LightGray,
                        ForeColor = Color.Black
                    };
                    btnSchimb.Click += ButtonChangeStatus_Click;
                    flowLayoutPanelComenzi.Controls.Add(btnSchimb);
                }
            }
        }

        // Separator




                // Handler pentru butonul de schimbare status
        private void ButtonChangeStatus_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            int orderId = (int)btn.Tag;

            // Găsim rândul comenzii după ID
            var orderRow = database1DataSet.Orders.AsEnumerable()
                .FirstOrDefault(r => r.Field<int>("Id") == orderId);

            if (orderRow != null)
            {
                string currentStatus = orderRow.Field<string>("Status");
                string newStatus;

                if (currentStatus == "În așteptare")
                    newStatus = "Procesare";
                else if (currentStatus == "Procesare")
                    newStatus = "Finalizată";
                else
                    newStatus = "În așteptare";

                orderRow["Status"] = newStatus;

                // Salvează modificarea în baza de date - aici folosește table adapter-ul tău pentru Orders
                try
                {
                    this.ordersTableAdapter.Update(database1DataSet.Orders);
                    database1DataSet.Orders.AcceptChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la salvarea statusului: " + ex.Message);
                }

                // Reafișăm comenzile actualizate
                UpdateComenziDisplay();
            }
        }




        public MainForm()
        {
            InitializeComponent();
            SetupEventHandlers();
            btnAddProduct.ForeColor = Color.Black;
            //orders
            this.ordersTableAdapter.Fill(this.database1DataSet.Orders);
            //products
            this.productsTableAdapter.Fill(this.database1DataSet.Products);
            //users logare
            this.usersTableAdapter.Fill(this.database1DataSet.Users);
            // order items
            this.orderItemsTableAdapter.Fill(this.database1DataSet.OrderItems);
            // Cerere Service
            this.serviceRequestTableAdapter.Fill(this.database1DataSet.ServiceRequest);
            // Produse cu Promotiii
            this.promotionsItemsTableAdapter.Fill(this.database1DataSet.PromotionsItems);
            // Promotii
            this.promotionsTableAdapter.Fill(this.database1DataSet.Promotions);
            AfiseazaProduse();
            BindingSource promotionsBindingSource = new BindingSource();
            promotionsBindingSource.DataSource = database1DataSet.Promotions;
            RefreshPromoCheckList();
            clbPromoProduse.Items.Clear();
            foreach (DataRow row in database1DataSet.Products.Rows)
            {
                clbPromoProduse.Items.Add(row, false); // Adăugăm DataRow direct
            }
            clbPromoProduse.DisplayMember = "Nume"; // Va arăta numele produsului

            groupBoxAddProduct.Visible = false;
            cmbTipAngajat.Items.AddRange(new string[] { "junior", "senior" });
            cmbProdusCategorie.Items.AddRange(new string[]
{
    "Telefoane",
    "Periferice",
    "Componente",
    "Laptopuri",
    "Monitoare",
    "Rețelistică"
});

            cmbProdusSubcategorie.Items.AddRange(new string[]
            {
    "Smartphone",
    "Mouse",
    "Tastatură",
    "Stocare",
    "Procesor",
    "Placă Video",
    "Gaming",
    "Routere"
            });


        }
        private void SetupEventHandlers()
        {
            btnAddPromotion.Click += BtnAddPromotion_Click;
            btnPlaceOrder.Click += BtnPlaceOrder_Click;
            btnViewEmployees.Click += BtnViewEmployees_Click;
            btnAddEmployee.Click += BtnAddEmployee_Click;
            btnLogin.Click += BtnLogin_Click;
        }

        private void BtnAddPromotion_Click(object sender, EventArgs e)
        {

        }

        private void BtnRemovePromotion_Click(object sender, EventArgs e)
        {
       
        }

        private void BtnAddToCart_Click(object sender, EventArgs e)
        {

        }

        private void BtnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (cartItems.Count > 0)
            {
                cartItems.RemoveAt(cartItems.Count - 1);
                UpdateCartDisplay();
            }
            else
            {
                MessageBox.Show("Coșul este gol!");
            }
        }

        private void BtnPlaceOrder_Click(object sender, EventArgs e)
        {
          
        }

   

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
         
        }

        private void BtnRemoveOrders_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            groupBox1.Visible= button1.Visible=false;
                //userRole = this.database1DataSet.Users[0].Tip;
            groupBoxAddProduct.Visible = false;
            labelOrders.Visible = false;
            flowLayoutPanelComenzi.Visible = false;
            groupBox3.Visible = false;

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int k = 0;
                for (int i = 0; i < database1DataSet.Users.Count; i++)
                {
                    if (textBox1.Text == database1DataSet.Users[i].Nume && textBox2.Text == database1DataSet.Users[i].Parola)
                    {
                        k = 1;
                        IDcont= database1DataSet.Users[i].Id;
                        userRole =database1DataSet.Users[i].Tip;
                         if (userRole.Contains("manager")) { groupBox1.Visible = true; button1.Visible =  true; labelOrders.Visible = flowLayoutPanelComenzi.Visible=true; }
                         if (userRole.Contains("senior")) { button1.Visible = true; labelOrders.Visible = flowLayoutPanelComenzi.Visible = true; }
                        if (userRole.Contains("junior")) { labelOrders.Visible = flowLayoutPanelComenzi.Visible = true; }
                         isLoggedIn = true; 
                         MessageBox.Show("Autentificare cu succes!");
                    }
                }
                if (k == 0) { MessageBox.Show("Nu exista cont!"); }
            }
            else { MessageBox.Show("Completeza campurile corespunzator"); }

        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {

        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPlaceOrder_Click_1(object sender, EventArgs e)
        {
            if (!isLoggedIn)
            {
                MessageBox.Show("Trebuie să vă autentificați pentru a plasa o comandă!");
                return;
            }

            if (cartItems.Count == 0)
            {
                MessageBox.Show("Coșul este gol! Adăugați produse pentru a plasa o comandă.");
                return;
            }

            try
            {
                double totalComanda = 0;
                var produseCantitati = new Dictionary<string, int>(); // Nume produs -> Cantitate
                var produseCuReducere = new HashSet<string>();

                // Construim coșul logic
                foreach (var numeRaw in cartItems)
                {
                    string nume = numeRaw.Replace("[PROMO] ", "");
                    bool esteCuReducere = numeRaw.StartsWith("[PROMO]");

                    if (!produseCantitati.ContainsKey(nume))
                        produseCantitati[nume] = 0;
                    produseCantitati[nume]++;

                    if (esteCuReducere)
                        produseCuReducere.Add(nume);
                }

                // Inserăm comanda
                int clientId = IDcont;
                DateTime dataCurenta = DateTime.Now;
                string statusComanda = "În procesare";
                string tipComanda = "Online";

                this.ordersTableAdapter.Insert(clientId, dataCurenta, tipComanda, 0, statusComanda);
                this.ordersTableAdapter.Fill(this.database1DataSet.Orders);

                int idComandaNoua = database1DataSet.Orders.AsEnumerable()
                    .Where(r => r.Field<int>("Client") == clientId)
                    .Max(r => r.Field<int>("Id"));

                // Inserăm produsele
                foreach (var kvp in produseCantitati)
                {
                    string numeProdus = kvp.Key;
                    int cantitate = kvp.Value;

                    var produsRow = database1DataSet.Products.AsEnumerable()
                        .FirstOrDefault(p => p.Field<string>("Nume") == numeProdus);

                    if (produsRow == null)
                    {
                        MessageBox.Show($"Produsul {numeProdus} nu a fost găsit în baza de date!");
                        return;
                    }

                    int produsId = produsRow.Field<int>("Id");
                    double pretOriginal = produsRow.Field<double>("Pret");
                    double pretFinal = produseCuReducere.Contains(numeProdus)
                                        ? pretOriginal * 0.9
                                        : pretOriginal;

                    

                    this.orderItemsTableAdapter.Insert(idComandaNoua, produsId, cantitate, pretFinal);
                    // Adăugare 100 RON pentru fiecare produs preasamblat
                    bool estePreasamblat = produsRow.Field<bool>("IsPreasamblat");
                    if (estePreasamblat)
                    {
                        totalComanda += pretFinal+(100 * cantitate);
                        MessageBox.Show($"S-a adăugat taxa pentru {cantitate}x {numeProdus} preasamblat (+{100 * cantitate} RON)");

                    }else totalComanda += pretFinal * cantitate;
                }

                // Actualizăm totalul comenzii în tabelul Orders
                var orderRow = database1DataSet.Orders.FindById(idComandaNoua);
                orderRow["Total"] = totalComanda;
                this.ordersTableAdapter.Update(database1DataSet.Orders);
                database1DataSet.Orders.AcceptChanges();

                this.orderItemsTableAdapter.Fill(this.database1DataSet.OrderItems);

                cartItems.Clear();
                UpdateCartDisplay();
                MessageBox.Show("Comandă plasată cu succes!");
                UpdateComenziDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la plasarea comenzii: " + ex.Message);
            }
        }



        private void btnLogin_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string descriere = richTextBox1.Text;
            if (string.IsNullOrEmpty(descriere))
            {
                MessageBox.Show("Vă rugăm să completați descrierea problemei.");
                return;
            }

            try
            {
                int clientId = IDcont; // presupunem că-l ai setat la login

                // 1. Inserăm comanda în Orders (tip service)
                string tipComanda = "Service";
                string statusComanda = "În așteptare";
                double totalComanda = 0;

                this.ordersTableAdapter.Insert(clientId, dateTimePicker1.Value, tipComanda, totalComanda, statusComanda);

                this.ordersTableAdapter.Fill(this.database1DataSet.Orders);

                int orderIdNou = database1DataSet.Orders.AsEnumerable()
                    .Where(r => r.Field<int>("Client") == clientId && r.Field<string>("Tip") == "Service")
                    .Max(r => r.Field<int>("Id"));

                // 2. Inserăm detaliile cererii în ServiceRequest, legat de orderIdNou
                this.serviceRequestTableAdapter.Insert(clientId, descriere, dateTimePicker1.Value, statusComanda);

                this.serviceRequestTableAdapter.Fill(this.database1DataSet.ServiceRequest);

                // Resetare UI
                UpdateComenziDisplay();
                groupBox2.Visible = false;
                MessageBox.Show("Cererea de service a fost trimisă cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la trimiterea cererii: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!isLoggedIn)
            {
                MessageBox.Show("Trebuie să vă autentificați pentru a putea trimite o cerere de service!");
                return;
            }
            groupBox2.Visible = !groupBox2.Visible;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string nume = txtProdusNume.Text.Trim();
            string descriere = txtProdusDescriere.Text.Trim();
            string categorie = cmbProdusCategorie.SelectedItem?.ToString() ?? "";
            string subcategorie = cmbProdusSubcategorie.SelectedItem?.ToString() ?? "";
            double pret;

            if (string.IsNullOrEmpty(nume) || string.IsNullOrEmpty(descriere) ||
                string.IsNullOrEmpty(categorie) || string.IsNullOrEmpty(subcategorie) ||
                !double.TryParse(txtProdusPret.Text, out pret))
            {
                MessageBox.Show("Completează toate câmpurile corect!");
                return;
            }

            try
            {
                double ratingInitial = 5.0; // default
                bool estePreasamblat = false;

                // Inserare în baza de date prin TableAdapter (trebuie să ai metoda `Insert`)
                productsTableAdapter.Insert(nume, categorie, subcategorie, pret, descriere, ratingInitial, estePreasamblat);

                // Refresh produse
                productsTableAdapter.Fill(database1DataSet.Products);
                AfiseazaProduse();

                MessageBox.Show("Produs adăugat cu succes!");

                // Resetare câmpuri
                txtProdusNume.Clear();
                txtProdusDescriere.Clear();
                txtProdusPret.Clear();
                cmbProdusCategorie.SelectedIndex = -1;
                cmbProdusSubcategorie.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la adăugarea produsului: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBoxAddProduct.Visible = !groupBoxAddProduct.Visible;
        }

        private void btnAddEmployee_Click_1(object sender, EventArgs e)
        {
            var angajati = database1DataSet.Users.AsEnumerable()
        .Where(u => u.Field<string>("Tip") != "client") // eventual filtrare să afișezi doar angajați
        .Select(u => $"{u.Field<string>("Nume")} - {u.Field<string>("Tip")}");

            string mesaj = string.Join(Environment.NewLine, angajati);

            if (string.IsNullOrWhiteSpace(mesaj))
                mesaj = "Nu există angajați în baza de date.";

            MessageBox.Show(mesaj, "Lista angajaților");
        }

        

        private void BtnViewEmployees_Click(object sender, EventArgs e)
        {
            groupBoxAddAngajat.Visible=!groupBoxAddAngajat.Visible;
        }

        private void btnAddAngajat_Click(object sender, EventArgs e)
        {
            string nume = txtNumeAngajat.Text.Trim();
            string parola = txtParolaAngajat.Text.Trim();
            string tip = cmbTipAngajat.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(nume) || string.IsNullOrEmpty(parola) || string.IsNullOrEmpty(tip))
            {
                MessageBox.Show("Completează toate câmpurile!");
                return;
            }

            // Creează un nou rând în DataSet
            var newUserRow = database1DataSet.Users.NewUsersRow();
            newUserRow.Nume = nume;
            newUserRow.Parola = parola;
            newUserRow.Tip = tip;

            database1DataSet.Users.Rows.Add(newUserRow);

            try
            {
                // Salvează modificările în baza de date
                this.usersTableAdapter.Update(database1DataSet.Users);
                database1DataSet.Users.AcceptChanges();

                MessageBox.Show("Angajat adăugat cu succes!");

                // Curățare câmpuri după adăugare
                txtNumeAngajat.Clear();
                txtParolaAngajat.Clear();
                cmbTipAngajat.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la adăugarea angajatului: " + ex.Message);
            }
        }

        private List<int> GetSelectedProductIdsFromCheckedListBox()
        {
            List<int> selectedProductIds = new List<int>();

            foreach (var item in clbPromoProduse.CheckedItems)
            {
                if (item is DataRow row)
                {
                    selectedProductIds.Add((int)row["Id"]);
                }
                else if (item is DataRowView rowView)
                {
                    selectedProductIds.Add((int)rowView["Id"]);
                }
            }

            return selectedProductIds;
        }


        private void btnAddPromo_Click(object sender, EventArgs e)
        {
            string nume = txtPromoNume.Text.Trim();
            string descriere = txtPromoDescriere.Text.Trim();
            var produseSelectate = GetSelectedProductIdsFromCheckedListBox();

            if (string.IsNullOrEmpty(nume))
            {
                MessageBox.Show("Numele promoției este obligatoriu.");
                return;
            }

            if (produseSelectate.Count == 0)
            {
                MessageBox.Show("Selectează cel puțin un produs pentru promoție.");
                return;
            }

            // Verificăm dacă promoția există deja
            var exista = database1DataSet.Promotions.AsEnumerable()
                          .Any(p => p.Field<string>("Nume") == nume);
            if (exista)
            {
                MessageBox.Show("O promoție cu acest nume există deja.");
                return;
            }

            // 1) Adăugăm promoția
            var newPromo = database1DataSet.Promotions.NewPromotionsRow();
            newPromo.Nume = nume;
            newPromo.Descriere = descriere;
            newPromo.ManagerId = IDcont;
            database1DataSet.Promotions.Rows.Add(newPromo);
            promotionsTableAdapter.Update(database1DataSet.Promotions);
            database1DataSet.Promotions.AcceptChanges();

            int promoId = newPromo.Id;

            // 2) Legăm produsele la promoție
            foreach (int produsId in produseSelectate)
            {
                var newItem = database1DataSet.PromotionsItems.NewPromotionsItemsRow();
                newItem.PromotionId = promoId;
                newItem.ProdusId = produsId;
                database1DataSet.PromotionsItems.Rows.Add(newItem);
            }

            promotionsItemsTableAdapter.Update(database1DataSet.PromotionsItems);
            database1DataSet.PromotionsItems.AcceptChanges();

            MessageBox.Show("Promoție adăugată cu succes!");
            RefreshPromoCheckList();
            AfiseazaProduse();
        }

        private void RefreshPromoCheckList()
        {
            promotionsBindingSource.DataSource = database1DataSet.Promotions;
            clbPromotiiExistente.Items.Clear();

            foreach (DataRowView rowView in promotionsBindingSource)
            {
                clbPromotiiExistente.Items.Add(rowView, false);
            }

            clbPromotiiExistente.DisplayMember = "Nume";
        }




        private void btnDeletePromo_Click(object sender, EventArgs e)
        {
            if (clbPromotiiExistente.CheckedItems.Count == 0)
            {
                MessageBox.Show("Selectează cel puțin o promoție de șters.");
                return;
            }

            List<int> promoIdsDeSters = new List<int>();

            foreach (var item in clbPromotiiExistente.CheckedItems)
            {
                if (item is DataRowView rowView)
                {
                    promoIdsDeSters.Add((int)rowView["Id"]);
                }
            }

            // Ștergem legăturile și promoțiile propriu-zise
            foreach (int promoId in promoIdsDeSters)
            {
                // 1. Ștergem toate PromotionsItems legate de promo
                var items = database1DataSet.PromotionsItems.AsEnumerable()
                    .Where(pi => pi.Field<int>("PromotionId") == promoId)
                    .ToList();

                foreach (var i in items)
                    i.Delete();

                // 2. Ștergem promoția
                var promoRow = database1DataSet.Promotions.FindById(promoId);
                if (promoRow != null)
                    promoRow.Delete();
            }

            // 3. Salvăm modificările
            promotionsItemsTableAdapter.Update(database1DataSet.PromotionsItems);
            promotionsTableAdapter.Update(database1DataSet.Promotions);
            database1DataSet.Promotions.AcceptChanges();
            database1DataSet.PromotionsItems.AcceptChanges();

            MessageBox.Show("Promoții șterse cu succes!");

            RefreshPromoCheckList();
            AfiseazaProduse(); // reîmprospătăm catalogul
        }

        private void btnAddPromotion_Click_1(object sender, EventArgs e)
        {
            groupBox3.Visible = !groupBox3.Visible;
        }
    }
}