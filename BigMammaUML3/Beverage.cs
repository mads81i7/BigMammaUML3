using System;
using System.Collections.Generic;
using System.Text;

namespace BigMammaUML3
{
    public class Beverage: MenuItem
    {
        private bool _isAlcoholic;

        public bool IsAlcoholic
        {
            get { return _isAlcoholic; }
            set { _isAlcoholic = value; }
        }

        public Beverage(int number, string name, string description, double price, MenuType menuType, bool isVegan, bool isOrganic, bool isAlcoholic) : base(number, name, description, price, menuType, isVegan, isOrganic)
        {
            _isAlcoholic = isAlcoholic;
        }

        public override string PrintInfo()
        {
            return $"Number {Number} || Name {Name} || Description {Description} || Price {Price} kr. || MenuType {Type} || Is Alcoholic {_isAlcoholic} || Is Vegan {IsVegan} || Is Organic {IsOrganic}";
        }

        public override string ToString()
        {
            return $"Number {Number} || Name {Name} || Description {Description} || Price {Price} kr. || MenuType {Type} || Is Alcoholic {_isAlcoholic} || Is Vegan {IsVegan} || Is Organic {IsOrganic}";
        }
    }
}
