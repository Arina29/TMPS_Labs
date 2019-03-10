using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clothes
{
    public abstract class ClothDecorator : ClothColor
    {
        protected ClothColor _clothDecorator;

        public ClothDecorator(ClothColor clothDecorator)
        {
            _clothDecorator = clothDecorator;
        }

        public virtual void ChooseColor()
        {
            _clothDecorator.ChooseColor();
        }
    }

    public class BlueBlouseWithPatterns : ClothDecorator
    {
        public BlueBlouseWithPatterns(ClothColor _clothDecorator) : base(_clothDecorator)
        {
        }

        public override void ChooseColor()
        {
           _clothDecorator.ChooseColor();
           setFlowerPattern();
        }

        public void setFlowerPattern()
        {
            Console.WriteLine("\t\tAdd flower Patch to the blouse");
        }
    }
}
