using System;

namespace BigMammaUML3
{
    class Program
    {

        public static void AddWithTest(IMenuCatalog imc, IMenuItem aMenuItem)
        {
            try { imc.Add(aMenuItem); }
            catch (MenuItemNumberExist mex) { Console.WriteLine("Exception Encountered: " + mex.Message); }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }
        static void Main(string[] args)
        {
            ICustomer c1 = new Customer("Poul", "Vej 123", 123, "12 12 12 12"); //ved at bruge interfacet kan man bruge andre evt. "customers" der benytter det samme interface
            ICustomerCatalog catalog = new CustomerCatalog();
            catalog.AddCustomer(c1);
            catalog.PrintCustomerList();

            IMenuCatalog mc = new MenuCatalog();

            IMenuItem p1 = new Pizza(1, "Pizza no.1", "alkjg", 75, MenuType.Pizza, true, false, false);
            IMenuItem p1New = new Pizza(1, "Updated Pizza no. 1", "This pizza was updated", 75, MenuType.Pizza, true, true, true);
            IMenuItem p2 = new Pizza(2, "Pizza no.2", "The pizza to be deleted", 100, MenuType.Pizza, true, false, false);
            IMenuItem p3 = new Pizza(3, "Pizza no.3", "The most expensive", 100, MenuType.Pizza, true, false, false);
            IMenuItem p4 = new Pizza(4, "Organic pizza", "This pizza is Organic", 80, MenuType.Pizza, false, true, true);
            IMenuItem p4ExpTest = new Pizza(4, "Exception pizza", "This pizza should catch an exception", 80, MenuType.Pizza, false, true, true);

            IMenuItem b1 = new Beverage(5, "Øl", "det er øl", 35, MenuType.AlcoholicDrink, false, true);
            IMenuItem b2 = new Beverage(6, "Cola", "det er cola", 20, MenuType.SoftDrink, true, false);

            IMenuItem pasta1 = new Pasta(7, "Bolognese", "Something", 90.50, MenuType.Pasta, false, true, PastaType.Spaghetti);
            IMenuItem pasta2 = new Pasta(8, "Big Mamma special", "Spinach and ricotta", 80, MenuType.Pasta, true, true, PastaType.Ravioli);

            IMenuItem t1 = new Topping(9, "Pepperoni", "___", 8, MenuType.Topping, false, false);
            IMenuItem t2 = new Topping(10, "Løg", "----", 5, MenuType.Topping, true, true);

            AddWithTest(mc, p1);
            AddWithTest(mc, p2);
            AddWithTest(mc, p3);
            AddWithTest(mc, p4);
            AddWithTest(mc, p4ExpTest);
            AddWithTest(mc, b1);
            AddWithTest(mc, b2);
            AddWithTest(mc, pasta1);
            AddWithTest(mc, pasta2);
            AddWithTest(mc, t1);
            AddWithTest(mc, t2);

            mc.PrintPizzasMenu();

            Console.WriteLine();
            try { mc.Delete(2); }
            catch (MenuItemNumberDoesNotExist mex) { Console.WriteLine($"EXCEPTION ENCOUNTERED while trying to delete: {mex.Message}"); }

            try { mc.Delete(100000); }
            catch (MenuItemNumberDoesNotExist mex) { Console.WriteLine($"EXCEPTION ENCOUNTERED while trying to delete: {mex.Message}"); }


            try { mc.Update(1, p1New); }
            catch (MenuItemNumberDoesNotExist mex) { Console.WriteLine($"EXCEPTION ENCOUNTERED while updating: {mex.Message}"); }

            try { mc.Update(10000, p1New); }
            catch (MenuItemNumberDoesNotExist mex) { Console.WriteLine($"EXCEPTION ENCOUNTERED while updating: {mex.Message}"); }


            try { Console.WriteLine("Search results: " + mc.Search(1)); }
            catch (MenuItemNumberDoesNotExist mex) { Console.WriteLine($"EXCEPTION ENCOUNTERED while searching: {mex.Message}"); }

            try { Console.WriteLine("Search results: " + mc.Search(1000)); }
            catch (MenuItemNumberDoesNotExist mex) { Console.WriteLine($"EXCEPTION ENCOUNTERED while searching: {mex.Message}"); }

            mc.PrintPizzasMenu();
            mc.PrintBeveragesMenu();
            mc.PrintPastaMenu();
            mc.PrintToppingsMenu();

            Console.WriteLine("\nVegan Pizza Menu");
            foreach (IMenuItem m in mc.FindAllVegan(MenuType.Pizza))
            {
                Console.WriteLine(m);
            }

            Console.WriteLine("\nOrganic Pizza Menu");
            foreach (IMenuItem m in mc.FindAllOrganic(MenuType.Pizza))
            {
                Console.WriteLine(m);
            }


            Console.WriteLine($"\n\nTHE MOST EXPENSIVE ITEM ON THE MENU IS\n{mc.MostExpensiveMenuItem()}");
            
            Console.WriteLine("Tryk enter for afslut");
            Console.ReadLine();
        }
    }
}
