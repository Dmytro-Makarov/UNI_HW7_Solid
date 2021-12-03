using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1
{
    //Який принцип S.O.L.I.D. порушено? Виправте! Принцип єдиного обов'язку

    interface IOrderable
    {
        void GetOrder(Order order);
    }
    class Item
    {

    }
    class Order
    {
        private List<Item> itemList;

        internal List<Item> ItemList
        {
            get
            {
                return itemList;
            }

            set
            {
                itemList = value;
            }
        }
    }

    class OrderWriter : IOrderable
    {
        private Order _order;
        public void GetOrder(Order order) {_order = order;}
        public void PrintOrder() {/*...*/}
        public void ShowOrder() {/*...*/}
    }

    class OrderCalculator : IOrderable
    {
        private Order _order;
        public void GetOrder(Order order) {_order = order;}
        public void CalculateTotalSum() {/*...*/}
    }

    class OrderItemManipulator : IOrderable
    {
        private Order _order;
        public void GetOrder(Order order) {_order = order;}
        public void GetItems() {/*...*/}
        public void GetItemCount() {/*...*/}
        public void AddItem(Item item) {/*...*/}
        public void DeleteItem(Item item) {/*...*/}
    }

    class OrderFileManipulator : IOrderable
    {
        private Order _order;
        public void GetOrder(Order order) {_order = order;}
        public void Load() {/*...*/}
        public void Save() {/*...*/}
        public void Update() {/*...*/}
        public void Delete() {/*...*/}
    }

    class Program
    {
        static void Main()
        {
        }
    }
}
