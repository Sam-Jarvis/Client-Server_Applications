using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using client.ServiceReferenceWebshop;

namespace client
{
    public partial class Form1 : Form, ServiceReferenceWebshop.IWebshopContractCallback
    {
        Item[] booksList;

        public Form1()
        {
            InitializeComponent();
            InstanceContext instanceContext = new InstanceContext(this);
            proxy = new ServiceReferenceWebshop.WebshopContractClient(instanceContext);
            newClient(proxy.connect());

            booksList = proxy.GetProductList();
        }
        private ServiceReferenceWebshop.WebshopContractClient proxy;


        private void btnWebshopName_Click(object sender, EventArgs e)
        {
            string name = proxy.GetWebshopName();
            lbWebshopName.Text = name;
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            refreshList();
        }

        private void btnGetProductInfo_Click(object sender, EventArgs e)
        {
            string productId = tbProductID.Text;
            string productInfo = proxy.GetProductInfo(productId);
            lbProductInfo.Text = productInfo;
        }

        private void btnBuyProduct_Click(object sender, EventArgs e)
        {
            string productId = lstBooks.SelectedItem.ToString();
            for (int i = 0; i < booksList.Length; i++)
            {
                if (booksList[i].ProductId == productId)
                {
                    booksList[i].Stock = (Convert.ToInt32(booksList[i].Stock) - 1).ToString();
                    break;
                }
            }
            refreshList();

            if (proxy.BuyProduct(productId))
            {
                refreshList();
            }
            //string newStock = proxy.BuyProduct();
        }

        private void refreshList()
        {
            //booksList = proxy.GetProductList();
            lstBooks.Items.Clear();
            lstPrice.Items.Clear();
            lstStock.Items.Clear();

            for (int i = 0; i < booksList.Length; i++)
            {
                lstBooks.Items.Add(booksList[i].ProductId);
                lstPrice.Items.Add(booksList[i].Price);
                lstStock.Items.Add(booksList[i].Stock);
            }
        }

        public void newClient(int numOfClients)
        {
            lbNumClients.Text = "Number of connected clients: " + numOfClients.ToString();
        }

        public void productSold(Item product)
        {
            for (int i = 0; i < booksList.Length; i++)
            {
                if (booksList[i].ProductId == product.ProductId)
                {
                    booksList[i].Stock = product.Stock;
                    break;
                }
            }
            refreshList();
        }
    }
}
