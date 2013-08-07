using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Warehouse
    {
        public int ID { get; set; }
        public string WarehouseNome { get; set; }

        public Warehouse(string Nom, int ID)
        {
            WarehouseNome = Nom;
            this.ID = ID;
        }

        public Item FindAndReturnItem(int itemID)
        {
            Item returnItem = new Item() { ID = itemID, Nome = "Office" };
            return returnItem;
        }
    }
}
