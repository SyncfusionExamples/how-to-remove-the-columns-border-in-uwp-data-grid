using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class OrderInfo : INotifyPropertyChanged
    {
        private int productId;
        private string name;
        private string email;
        private string role;
        private double _NoOfOrders;
        private DateTime _orderDate;
        private string countryName;
        private string shipCity;
        private int _shipid;

        public int ProductId
        {
            get
            {
                return productId;
            }
            set
            {
                productId = value;
                this.RaisePropertyChanged("ProductId");
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                RaisePropertyChanged("Name");
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
                RaisePropertyChanged("Email");
            }
        }

        public string Role
        {
            get
            {
                return role;
            }
            set
            {
                role = value;
                RaisePropertyChanged("Role");
            }
        }

        public double NoOfOrders
        {
            get
            {
                return _NoOfOrders;
            }
            set
            {
                _NoOfOrders = value;
                RaisePropertyChanged("NoOfOrders");
            }
        }

        public DateTime OrderDate
        {
            get
            {
                return _orderDate;
            }
            set
            {
                _orderDate = value;
                RaisePropertyChanged("OrderDate");
            }
        }

        public string CountryName
        {
            get
            {
                return countryName;
            }
            set
            {
                countryName = value;
                RaisePropertyChanged("CountryName");
            }
        }

        public string ShipCity
        {
            get
            {
                return shipCity;
            }
            set
            {
                shipCity = value;
                RaisePropertyChanged("ShipCity");
            }
        }
        public int ShipId
        {
            get
            {
                return _shipid;
            }
            set
            {
                _shipid = value;
                RaisePropertyChanged("ShipId");
            }
        }

        public OrderInfo()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }

    public class OrderDetails : INotifyPropertyChanged
    {
        public OrderDetails(string orderIDName)
        {
            this.orderIDName = orderIDName;
        }
        public OrderDetails()
        { }
        private string orderIDName = "Custom Header Text";
        public string OrderIDText
        {
            get { return orderIDName; }
            set { orderIDName = value; RaisePropertyChanged("OrderID"); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
