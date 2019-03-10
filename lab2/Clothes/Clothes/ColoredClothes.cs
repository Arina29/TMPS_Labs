using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clothes
{
    public interface ClothColor
    {
        void ChooseColor();
    }

    #region blouse
    public class RedBlouse : ClothColor
    {
        public void ChooseColor()
        {
            Console.WriteLine("\t\tChoosing red materials for the new Blouse");
        }
    }

    public class BlueBlouse : ClothColor
    {
        public void ChooseColor()
        {
            Console.WriteLine("\t\tChoosing blue materials for the new Blouse");
        }
    }
    #endregion blouse

    #region trousers
    public class RedTrousers : ClothColor
    {
        public void ChooseColor()
        {
            Console.WriteLine("\tChoosing red materials for the new trousers");
        }
    }

    public class BlueTrousers : ClothColor
    {
        public void ChooseColor()
        {
            Console.WriteLine("\t\tChoosing blue materials for the new trousers");
        }
    }
    #endregion trousers

    #region Jacket
    public class RedLeatherJacket : ClothColor
    {
        public void ChooseColor()
        {
            Console.WriteLine("\t\tChoosing red materials for the new leather jacket");
        }
    }

    public class BlueLeatherJacket : ClothColor
    {
        public void ChooseColor()
        {
            Console.WriteLine("\t\tChoosing blue materials for the new leather jacket");
        }
    }
    #endregion Jacket
}
