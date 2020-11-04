﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BigMammaUML3
{
    public interface IMenuCatalog
    {
        int Count { get; }
        void Add(IMenuItem aMenuItems);
        IMenuItem Search(int number);
        void Delete(int number);
        void PrintPizzasMenu();
        void PrintBeveragesMenu();
        void PrintToppingsMenu();
        void PrintPastaMenu();
        void Update(int number, IMenuItem theMenuItem);
        List<IMenuItem> FindAllVegan(MenuType type);
        List<IMenuItem> FindAllOrganic(MenuType type);
        IMenuItem MostExpensiveMenuItem();
    }

}
