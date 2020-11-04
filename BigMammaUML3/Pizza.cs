using System;
using System.Collections.Generic;
using System.Text;

namespace BigMammaUML3
{
    public class Pizza: MenuItem
    {
        private bool _isDeepPan;
        public bool IsDeepPan
        {
            get { return _isDeepPan; }
            set { _isDeepPan = value; }
        }

        public Pizza(int number, string name, string description, double price, MenuType menuType, bool isVegan, bool isOrganic, bool isDeepPan) : base(number, name, description, price, menuType, isVegan, isOrganic)
        {
            _isDeepPan = isDeepPan;
        }

        public override string PrintInfo()
        {
            return $"Number {Number} || Name {Name} || Description {Description} || Price {Price} kr. || MenuType {Type} || Is DeepPan {_isDeepPan} || Is Vegan {IsVegan} || Is Organic {IsOrganic}";
        }

        public override string ToString()
        {
            return $"Number {Number} || Name {Name} || Description {Description} || Price {Price} kr. || MenuType {Type} || Is DeepPan {_isDeepPan} || Is Vegan {IsVegan} || Is Organic {IsOrganic}";
        }
    }
}
