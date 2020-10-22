using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignmentShop
{
    public partial class Shop : Form
    {
        private StoreClass store = new StoreClass();
        // this list is generated once then stored as an object
        // we need to update the list on purchase!
        private List<ItemClass> shoppingCartData = new List<ItemClass>();

        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        private decimal storeProfit = 0;
        public Shop()
        {
            InitializeComponent();
            SetupData();
            // to add our list of items to the ui...
            // call a binding source above...
            // then
            // this links our items to the binding source
            // adding a condition so sold items are not populated in item list
            // arrow functions exist in c# too lol
            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            //note!!! itemsListBox is the name of the instance of the itembox we made in the design. if the name isn't exactly the same it won't know what to look for!
            itemsListbox.DataSource = itemsBinding;

            itemsListbox.DisplayMember = "Display";
            itemsListbox.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            ShoppingCartListBox.DataSource = cartBinding;
            ShoppingCartListBox.DisplayMember = "Display";
            ShoppingCartListBox.ValueMember = "Display";

            vendorsBinding.DataSource = store.Vendors;
            VendorListbox.DataSource = vendorsBinding;

            VendorListbox.DisplayMember = "Display";
            VendorListbox.ValueMember = "Display";


        }

        private void Shop_Load(object sender, EventArgs e)
        {

        }
        private void SetupData()
        {   // one way to add a new vendor instantiate the vendor then add it with add statement
            VendorClass demoVendor = new VendorClass();
            demoVendor.FirstName = "Bill";
            demoVendor.LastName = "Smith";
            demoVendor.Commission = .5;

            // made a new variable called store
            // which is a new StoreClass() Class
            //store.vendors add a vendor...
            store.Vendors.Add(demoVendor);

            // second way is to use curly braces
            store.Vendors.Add(new VendorClass { FirstName = "John", LastName = "Johnson", Commission = .5 });
            store.Vendors.Add(new VendorClass { FirstName = "Linda", LastName = "Malfoy", Commission = .3 });
            store.Vendors.Add(new VendorClass { FirstName = "Xernona", LastName = "Kardashian", Commission = .7 });
            store.Vendors.Add(new VendorClass { FirstName = "Larry", LastName = "Fishman(Fish Lawyer)", Commission = .4 });



            // added a default value for commission in vendor class!

            store.Items.Add(new ItemClass { Title = "Moby Dick", 
                Description = "A book about a white whale", 
                Price = 4.50M, 
                Owner = store.Vendors[0], });

            store.Items.Add(new ItemClass
            {
                Title = "Atlas Shrugged",
                Description = "A book about a people and their government",
                Price = 5.75M,
                Owner = store.Vendors[1],
            });

            store.Items.Add(new ItemClass
            {
                Title = "Drawing on the Right Side of the Brain",
                Description = "A book on how to draw",
                Price = 7.75M,
                Owner = store.Vendors[2],
            });
            store.Items.Add(new ItemClass
            {
                Title = "Lessons From the Old Masters",
                Description = "A book about a Old Master Art",
                Price = 5.75M,
                Owner = store.Vendors[3],
            });
            store.Items.Add(new ItemClass
            {
                Title = "Fish Law 1800-Present",
                Description = "A book about Fish Law",
                Price = 9.00M,
                Owner = store.Vendors[4],
            });
            store.Items.Add(new ItemClass
            {
                Title = "Studying For the Fish BAR Exam",
                Description = "A book about studying for the Fish BAR Exam",
                Price = 8.20M,
                Owner = store.Vendors[4],
            });
            store.Items.Add(new ItemClass
            {
                Title = "Plato's Symposium",
                Description = "A book about philosophy",
                Price = 5.20M,
                Owner = store.Vendors[3],
            });
            store.Name = "Book Shop";

        }

        private void AddCartButton_Click(object sender, EventArgs e)
        {
            // always delete the onClick property of the component when you also delete code!!
            //MessageBox.Show("clicked!");

            // button should pass selected item from items list. remove it from items list, send to shopping Cart
            ItemClass selectedItem = (ItemClass)itemsListbox.SelectedItem;

            //MessageBox.Show(selectedItem.Title);
            // whenever item is selected add to cart list
            shoppingCartData.Add(selectedItem);
            cartBinding.ResetBindings(false);


        }

        private void PurchaseItemButton_Click(object sender, EventArgs e)
        {
            // mark each itme in cart as sold.
            //distribute payments
            //clear the cart

            foreach (ItemClass item in shoppingCartData)
            {
                item.Sold = true;
                // adding vendor info here
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                // updating store profit
                storeProfit += (1 - (decimal)item.Owner.Commission) * item.Price;
            }
            shoppingCartData.Clear();
            // re instantiating the items list after a purchase is made so sold items don't populate
            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

            StoreProfitValue.Text = string.Format("${0}", storeProfit);

            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
