using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigMammaUML3
{
    public class MenuCatalog : IMenuCatalog
    {
        private Dictionary<int, IMenuItem> _menuItems;

        public MenuCatalog()
        {
            _menuItems = new Dictionary<int, IMenuItem>();
        }

        public int Count
        {
            get { return _menuItems.Count; }
        }

        public void Add(IMenuItem aMenuItems)
        {
            if (_menuItems.ContainsKey(aMenuItems.Number))
            {
                throw new MenuItemNumberExist($"An item with the number {aMenuItems.Number} is already on the menu");
            }
            _menuItems.Add(aMenuItems.Number, aMenuItems);
        }

        public IMenuItem Search(int number)
        {
            if (!_menuItems.ContainsKey(number))
            {
                throw new MenuItemNumberDoesNotExist($"an item with the number {number} is not on the menu");
            }
            return _menuItems[number];
        }

        public void Delete(int number)
        {
            if (!_menuItems.ContainsKey(number))
            {
                throw new MenuItemNumberDoesNotExist($"an item with the number {number} is not on the menu");
            }
            _menuItems.Remove(number);
            Console.WriteLine($"The item with the number {number} has now been removed");
        }

        public void PrintPizzasMenu()
        {
            Console.WriteLine("\nPIZZA MENU");

            foreach (IMenuItem m in _menuItems.Values)
            {
                if (m is Pizza)
                {
                    Console.WriteLine(m);
                }
            }
        }

        public void PrintBeveragesMenu()
        {
            Console.WriteLine("\nBEVERAGE MENU");
            foreach (IMenuItem m in _menuItems.Values)
            {
                if (m is Beverage)
                {
                    Console.WriteLine(m);
                }
            }
        }

        public void PrintToppingsMenu()
        {
            Console.WriteLine("\nTOPPING MENU");
            foreach (IMenuItem m in _menuItems.Values)
            {
                if (m is Topping)
                {
                    Console.WriteLine(m);
                }
            }
        }

        public void PrintPastaMenu()
        {
            Console.WriteLine("\nPASTA MENU");

            foreach (IMenuItem m in _menuItems.Values)
            {
                if (m is Pasta)
                {
                    Console.WriteLine(m);
                }
            }
        }

        public void Update(int number, IMenuItem theMenuItem)
        {
            if (!_menuItems.ContainsKey(number))
            {
                throw new MenuItemNumberDoesNotExist($"an item with the number {number} is not on the menu");
            }
            _menuItems[number] = theMenuItem;
            Console.WriteLine($"The item with the number {number} has now been updated");
        }

        public List<IMenuItem> FindAllVegan(MenuType type)
        {
            List<IMenuItem> veganList = new List<IMenuItem>();
            foreach (IMenuItem m in _menuItems.Values)
            {
                if (m.IsVegan == true && m.Type == type)
                {
                    veganList.Add(m);
                }
            }
            return veganList;
        }

        public List<IMenuItem> FindAllOrganic(MenuType type)
        {
            List<IMenuItem> organicList = new List<IMenuItem>();
            foreach (IMenuItem m in _menuItems.Values)
            {
                if (m.IsOrganic == true && m.Type == type)
                {
                    organicList.Add(m);
                }
            }
            return organicList;
        }

        public IMenuItem MostExpensiveMenuItem()
        {
            IMenuItem mostExpensive = null;
            if (_menuItems.Count > 0)
            {
                mostExpensive = _menuItems.Values.FirstOrDefault();

                foreach (IMenuItem m in _menuItems.Values)
                {
                    if (m.Price > mostExpensive.Price)
                    {
                        mostExpensive = m;
                    }
                }
            }
            return mostExpensive;
        }

    }
}
