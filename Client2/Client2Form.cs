using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client2
{
    public partial class Client2Form : Form
    {
        public Client2Form()
        {
            InitializeComponent();
            proxy = new ServiceReferenceClient2.WebshopContractClient();
        }
        private ServiceReferenceClient2.WebshopContractClient proxy;

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
            string productId = tbProductID.Text;

            if (proxy.BuyProduct(productId))
            {
                refreshList();
            }
        }

        private void refreshList()
        {
            lstBooks.Items.Clear();
            lstPrice.Items.Clear();
            lstStock.Items.Clear();

            var booksList = proxy.GetProductList();
            for (int i = 0; i < booksList.Length; i++)
            {
                lstBooks.Items.Add(booksList[i].ProductId);
                lstPrice.Items.Add(booksList[i].Price);
                lstStock.Items.Add(booksList[i].Stock);
            }
        }
    }
}
