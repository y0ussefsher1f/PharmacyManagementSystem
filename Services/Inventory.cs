using System;
using System.Collections.Generic;
using PharmacyManagementSystem.Models;

namespace PharmacyManagementSystem.Services
{
    public class Inventory
    {
        private List<Medicine> medicines;

        public Inventory()
        {
            medicines = new List<Medicine>();
        }

        public void AddMedicine(Medicine medicine)
        {
            medicines.Add(medicine);
        }

        public bool UpdateMedicine(int medicineID, Medicine updatedMedicine)
        {
            Medicine medicine = null;
            foreach (var m in medicines)
            {
                if (m.MedicineID == medicineID)
                {
                    medicine = m;
                    break;
                }
            }
            if (medicine != null)
            {
                medicine.Name = updatedMedicine.Name;
                medicine.Price = updatedMedicine.Price;
                medicine.Quantity = updatedMedicine.Quantity;
                medicine.ExpiryDate = updatedMedicine.ExpiryDate;
                medicine.Category = updatedMedicine.Category;
                return true;
            }
            return false;
        }

        public bool RemoveMedicine(int medicineID)
        {
            Medicine medicine = null;
            foreach (var m in medicines)
            {
                if (m.MedicineID == medicineID)
                {
                    medicine = m;
                    break;
                }
            }
            if (medicine != null)
            {
                medicines.Remove(medicine);
                return true;
            }
            return false;
        }

        public Medicine SearchMedicine(string name)
        {
            foreach (var m in medicines)
            {
                if (m.Name != null && m.Name.ToLower().Contains(name.ToLower()))
                {
                    return m;
                }
            }
            return null;
        }

        public List<Medicine> CheckLowStock(int threshold)
        {
            List<Medicine> lowStock = new List<Medicine>();
            foreach (var m in medicines)
            {
                if (m.Quantity <= threshold)
                {
                    lowStock.Add(m);
                }
            }
            return lowStock;
        }

        public bool UpdateStock(int medicineID, int quantitySold)
        {
            Medicine medicine = null;
            foreach (var m in medicines)
            {
                if (m.MedicineID == medicineID)
                {
                    medicine = m;
                    break;
                }
            }
            if (medicine != null && medicine.Quantity >= quantitySold)
            {
                medicine.Quantity -= quantitySold;
                return true;
            }
            return false;
        }

        public List<Medicine> GetAllMedicines()
        {
            return medicines;
        }
    }
}