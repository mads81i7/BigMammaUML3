using System;
using System.Collections.Generic;
using System.Text;

namespace BigMammaUML3
{
    public enum PastaType { Spaghetti, Ravioli, Tagliatelle, Fusilli};
    public class Pasta: MenuItem
    {
        private PastaType _pastaType;
        public PastaType TypeOfPasta
        {
            get { return _pastaType; }
            set { _pastaType = value; }
        }

        public Pasta(int number, string name, string description, double price, MenuType menuType, bool isVegan, bool isOrganic, PastaType pastaType) : base(number, name, description, price, menuType, isVegan, isOrganic)
        {
            _pastaType = pastaType;
        }

        public override string PrintInfo()
        {
            return $"Number {Number} || Name {Name} || Description {Description} || Price {Price} kr. || Menu Type {Type} || Pasta Type {_pastaType} || Is Vegan {IsVegan} || Is Organic {IsOrganic}";
        }

        public override string ToString()
        {
            return $"Number {Number} || Name {Name} || Description {Description} || Price {Price} kr. || Menu Type {Type} || Pasta Type {_pastaType} || Is Vegan {IsVegan} || Is Organic {IsOrganic}";
        }
    }
}
