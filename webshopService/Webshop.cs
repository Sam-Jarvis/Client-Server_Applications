using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace webshopService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Webshop : IWebshopContract
    {
        //IWebshopCallback clientCallback;

        List<Item> books;
        List<IWebshopCallback> callbacks;

        string name;
        int numOfClients;

        public Webshop()
        {
            name = "Fum Duck";
            books = new List<Item>();
            addBooks(books);
            callbacks = new List<IWebshopCallback>();
            numOfClients = 0;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        private void addBooks(List<Item> books)
        {
            Item Wot1 = new Item("The Eye of The World", "100", "12.00", "10", "No");
            Item Wot2 = new Item("The Great Hunt", "102", "10.00", "5", "Yes");
            Item Wot3 = new Item("The Dragon Reborn", "103", "13.00", "9", "No");
            Item Wot4 = new Item("The Shadow Rising", "104", "9.00", "15", "Yes");

            books.Add(Wot1);
            books.Add(Wot2);
            books.Add(Wot3);
            books.Add(Wot4);
        }

        public string GetWebshopName()
        {
            return name;
        }

        public List<Item> GetProductList()
        {
            return books;
        }

        public string GetProductInfo(string ProductId)
        {
            string info = "";
            for(int i = 0; i < books.Count; i++)
            {
                if(books[i].ProductId == ProductId)
                {
                    info = books[i].ProductInfo;
                }
            }
            return info;
        }

        public bool BuyProduct(string ProductId)
        {
            for(int i = 0; i < books.Count; i++)
            {
                if(books[i].ProductId == ProductId)
                {

                    int stock = Convert.ToInt32(books[i].Stock);
                    stock = stock - 1;
                    books[i].Stock = stock.ToString();

                    foreach (IWebshopCallback callback in callbacks)
                    {
                        if (callback != OperationContext.Current.GetCallbackChannel<IWebshopCallback>())
                        {
                            callback.productSold(books[i]);
                        }                       
                    }
                    return true;
                }
            }
            return false;
        } 

        public int connect()
        {
            numOfClients++;

            foreach(IWebshopCallback callback in callbacks)
            {
                callback.newClient(numOfClients);
            }

            IWebshopCallback session = OperationContext.Current.GetCallbackChannel<IWebshopCallback>();
            callbacks.Add(session);
            return numOfClients;
        }
    }
}
