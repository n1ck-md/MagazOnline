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
        private List<string> cartItems = new List<string>();
        private bool isLoggedIn = false;
        private string userRole = "client"; // poate fi "manager", "senior", "junior" - de extins

        public MainForm()
        {
            InitializeComponent();
            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            btnAddPromotion.Click += BtnAddPromotion_Click;
            btnRemovePromotion.Click += BtnRemovePromotion_Click;
            btnAddToCart.Click += BtnAddToCart_Click;
            btnRemoveFromCart.Click += BtnRemoveFromCart_Click;
            btnPlaceOrder.Click += BtnPlaceOrder_Click;
            btnViewEmployees.Click += BtnViewEmployees_Click;
            btnAddEmployee.Click += BtnAddEmployee_Click;
            btnRemoveOrders.Click += BtnRemoveOrders_Click;
            btnLogin.Click += BtnLogin_Click;
        }

        private void BtnAddPromotion_Click(object sender, EventArgs e)
        {
            if (userRole == "manager")
            {
                MessageBox.Show("Adăugare promoție - disponibilă doar pentru manager.");
            }
            else
            {
                MessageBox.Show("Doar managerul poate adăuga promoții!");
            }
        }

        private void BtnRemovePromotion_Click(object sender, EventArgs e)
        {
            if (userRole == "manager")
            {
                MessageBox.Show("Ștergere promoție - disponibilă doar pentru manager.");
            }
            else
            {
                MessageBox.Show("Doar managerul poate șterge promoții!");
            }
        }

        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            if (!isLoggedIn)
            {
                MessageBox.Show("Trebuie să vă autentificați pentru a adăuga produse în coș!");
                return;
            }

            if (listBoxProducts.SelectedItem != null)
            {
                cartItems.Add(listBoxProducts.SelectedItem.ToString());
                UpdateCartDisplay();
            }
            else
            {
                MessageBox.Show("Selectați un produs pentru a-l adăuga în coș!");
            }
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
            if (!isLoggedIn)
            {
                MessageBox.Show("Trebuie să vă autentificați pentru a plasa o comandă!");
                return;
            }

            if (cartItems.Count > 0)
            {
                MessageBox.Show("Comandă plasată cu succes!");
                cartItems.Clear();
                UpdateCartDisplay();
            }
            else
            {
                MessageBox.Show("Coșul este gol! Adăugați produse pentru a plasa o comandă.");
            }
        }

        private void BtnViewEmployees_Click(object sender, EventArgs e)
        {
            if (userRole == "manager")
            {
                MessageBox.Show("Vizualizare angajați - disponibilă doar pentru manager.");
            }
            else
            {
                MessageBox.Show("Doar managerul poate vizualiza angajații!");
            }
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            if (userRole == "manager")
            {
                MessageBox.Show("Adăugare angajat - disponibilă doar pentru manager.");
            }
            else
            {
                MessageBox.Show("Doar managerul poate adăuga angajați!");
            }
        }

        private void BtnRemoveOrders_Click(object sender, EventArgs e)
        {
            if (isLoggedIn && (userRole == "junior" || userRole == "senior"))
            {
                MessageBox.Show("Ștergere comandă - disponibilă pentru angajați.");
            }
            else
            {
                MessageBox.Show("Doar angajații pot șterge comenzi!");
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (!isLoggedIn)
            {
                isLoggedIn = true;
                userRole = "client";
                MessageBox.Show("Autentificare cu succes!");
                btnLogin.Text = "Logout";
                btnLogin.Click -= BtnLogin_Click;
                btnLogin.Click += BtnLogout_Click;
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            isLoggedIn = false;
            userRole = "client";
            MessageBox.Show("Deconectare cu succes!");
            btnLogin.Text = "Login";
            btnLogin.Click -= BtnLogout_Click;
            btnLogin.Click += BtnLogin_Click;
        }

        private void UpdateCartDisplay()
        {
            panelCart.Controls.Clear();
            panelCart.Controls.Add(labelCart);

            int yOffset = 40;
            foreach (var item in cartItems)
            {
                Label lbl = new Label();
                lbl.Text = item;
                lbl.Location = new Point(10, yOffset);
                lbl.Size = new Size(400, 60);
                lbl.ForeColor = System.Drawing.Color.White;
                panelCart.Controls.Add(lbl);
                yOffset += 70;
            }
        }
    }
}