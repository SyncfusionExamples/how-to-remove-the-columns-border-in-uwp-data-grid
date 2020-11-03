using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class ViewModel : INotifyPropertyChanged
    {
        public OrderDetails order = new OrderDetails();
        public OrderDetails Order
        {
            get { return order; }
            set
            {
                order = value;
                RaisePropertyChanged("Order");
            }
        }
        private ObservableCollection<OrderInfo> _orderList;
        public ObservableCollection<OrderInfo> OrderList
        {
            get
            {
                return _orderList;
            }
            set
            {
                _orderList = value;
                RaisePropertyChanged("OrderList");
            }
        }
        public ObservableCollection<string> _shipcities;
        public ObservableCollection<string> Shipcities
        {
            get
            {
                return _shipcities;
            }
            set
            {
                _shipcities = value;
            }
        }
        public ViewModel()
        {
            this.Generate();
        }

        public void Generate()
        {
            _orderList = new ObservableCollection<OrderInfo>();
            _orderList.Add(new OrderInfo() { ProductId = 1001, Name = "Alice", Email = "alicemutton@arpy.com", Role = "Manager", NoOfOrders = 10, OrderDate = new DateTime(2015, 5, 2), CountryName = "Argentina", ShipCity = "Graz", ShipId = 1 });
            _orderList.Add(new OrderInfo() { ProductId = 1002, Name = "Wimmers", Email = "nuNuCa@arpy.com", Role = "Manager", NoOfOrders = 10, OrderDate = new DateTime(2015, 5, 20), CountryName = "Austria", ShipCity = "Cork", ShipId = 2 });
            _orderList.Add(new OrderInfo() { ProductId = 1003, Name = "Boston", Email = "bostonn@arpy.com", Role = "Manager", NoOfOrders = 100, OrderDate = new DateTime(2015, 5, 3), CountryName = "Belgium", ShipCity = "Helsinki", ShipId = 3 });
            _orderList.Add(new OrderInfo() { ProductId = 1004, Name = "Konbu", NoOfOrders = 50, Email = "konbu@arpy.com", Role = "Manager", OrderDate = new DateTime(2015, 5, 13), CountryName = "Argentina", ShipCity = "Århus", ShipId = 4 });
            _orderList.Add(new OrderInfo() { ProductId = 1005, Name = "Boston", NoOfOrders = 20, Email = "boston@arpy.com", Role = "Manager", OrderDate = new DateTime(2015, 5, 23), CountryName = "Canada", ShipCity = "Bergamo", ShipId = 5 });
            _orderList.Add(new OrderInfo() { ProductId = 1006, Name = "Raclette", Email = "raclette@arpy.com", Role = "Manager", NoOfOrders = 20, OrderDate = new DateTime(2015, 5, 13), CountryName = "Denmark", ShipCity = "Campinas", ShipId = 6 });
            _orderList.Add(new OrderInfo() { ProductId = 1007, Name = "Alice", Email = "wimmers@arpy.com", Role = "Manager", NoOfOrders = 20, OrderDate = new DateTime(2015, 5, 13), CountryName = "Argentina", ShipCity = "Montréal", ShipId = 7 });
            _orderList.Add(new OrderInfo() { ProductId = 1005, Name = "Konbu", Email = "boston@arpy.com", Role = "Manager", NoOfOrders = 25, OrderDate = new DateTime(2015, 1, 23), CountryName = "Italy", ShipCity = "Campinas", ShipId = 8 });
            _orderList.Add(new OrderInfo() { ProductId = 1006, Name = "Raclette", Email = "raclette@arpy.com", Role = "Manager", NoOfOrders = 24, OrderDate = new DateTime(2015, 4, 28), CountryName = "Canada", ShipCity = "Graz", ShipId = 9 });
            _orderList.Add(new OrderInfo() { ProductId = 1007, Name = "Wimmers", Email = "wimmers@arpy.com", Role = "Manager", NoOfOrders = 40, OrderDate = new DateTime(2015, 5, 8), CountryName = "Canada", ShipCity = "Bergamo", ShipId = 10 });

            _shipcities = new ObservableCollection<string>();
            _shipcities.Add("Bergamo");
            _shipcities.Add("Graz");
            _shipcities.Add("Campinas");
            _shipcities.Add("Helsinki");
            _shipcities.Add("Århus");
            _shipcities.Add("Cork");
            _shipcities.Add("Montréal");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
