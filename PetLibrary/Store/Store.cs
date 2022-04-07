using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetLibrary.Store
{
    public class Store
    {
        public List<Food> Foods { get; set; }
        public List<Medicine> Medicines { get; set; }


        public Store()
        {
            Foods = new List<Food>();
            Foods.Add(new Food("Хліб", 10, 25.00F, 2, 4, @"\Images\Food\bread.png"));
            Foods.Add(new Food("Шоколад", 3, 55.50F, 10, 10, @"\Images\Food\chocolate.png"));
            Foods.Add(new Food("Кава", 1, 25.00F, 25, 0, @"\Images\Food\coffee.png"));
            Foods.Add(new Food("Сік", 2, 10.00F, 1, 10, @"\Images\Food\juice.png"));
            Foods.Add(new Food("Онігірі", 30, 40.00F, 8, 9, @"\Images\Food\onigiri.png"));
            Foods.Add(new Food("Піца", 35, 60.00F, 10, 10, @"\Images\Food\pizza.png"));

            Medicines = new List<Medicine>();
            Medicines.Add(new Medicine("Зілля здоров'я", 40, 30, @"\Images\Medicines\healthPotion.png"));
        }
    }
}
