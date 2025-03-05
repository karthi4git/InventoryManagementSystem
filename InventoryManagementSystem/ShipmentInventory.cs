using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public class ShipmentInventory
    {
        private static List<Shipment> shipments = new List<Shipment>();
        private static int nextId = 1;

        public List<Shipment> GetShipments()
        {
            return shipments.OrderBy(s => s.Id).ToList();
        }

        public Shipment GetShipmentById(int id)
        {
            return shipments.FirstOrDefault(s => s.Id == id);
        }

        public void AddShipment(Shipment shipment)
        {
            shipment.Id = nextId++;
            shipments.Add(shipment);
        }

        public void UpdateShipment(Shipment updatedShipment)
        {
            var existingShipment = GetShipmentById(updatedShipment.Id);
            if (existingShipment != null)
            {
                existingShipment.ProductName = updatedShipment.ProductName;
                existingShipment.Quantity = updatedShipment.Quantity;
                existingShipment.ShipmentDate = updatedShipment.ShipmentDate;
            }
        }

        public void DeleteShipment(int id)
        {
            var shipment = GetShipmentById(id);
            if (shipment != null)
            {
                shipments.Remove(shipment);
            }
        }
    }
}