using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryApp
{
    public static class ErrorHandler
    {
        public static void HandleError(Exception ex)
        {
            // Handle the exception (e.g., display error message to the user, log the error)
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static class InputValidator
    {
        public static bool ValidateItem(InventoryItem item)
        {
            // Validate item properties (e.g., name, price, quantity)
            // Return true if valid, false otherwise
            return !string.IsNullOrEmpty(item.Name) && item.Price > 0 && item.Quantity > 0 && !string.IsNullOrEmpty(item.Category);
        }
    }

}
