namespace RefactoringToDesignPatterns.CH01_CodeSmells.HomeWork
{
    internal class LargeClass
    {
    }

    public class WarehouseManager(OrderProcessor orderProcessor, InventoryManager inventoryManager, DeliveryCoordinator deliveryCoordinator, ReturnHandler returnHandler)
    {

    }

    public class OrderProcessor
    {
        public void ProcessOrders()
        {
            Console.WriteLine("Processing orders.");
        }
    }

    public class InventoryManager
    {
        public void ManageInventory()
        {
            Console.WriteLine("Managing inventory.");
        }
    }

    public class DeliveryCoordinator
    {
        public void CoordinateDeliveries()
        {
            Console.WriteLine("Coordinating deliveries.");
        }
    }

    public class ReturnHandler
    {
        public void HandleReturns()
        {
            Console.WriteLine("Handling returns.");
        }
    }
}
