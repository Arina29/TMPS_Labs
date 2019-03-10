using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clothes.ClothItems
{
    public class Trousers : Cloth
    {
        public Trousers(ClothColor clothColor) : base(clothColor)
        {
        }

        public override List<object> GetMaterials()
        {

            var materials = new List<object>
            {
                Materials.Jeans,
                Accessories.Stickers,
                Additional.Button,
                Additional.Zipper
            };
            return materials;
        }

        public override void Sew(List<Object> materials)
        {
            Console.WriteLine("\tSewing a trousers");
            base._color.ChooseColor();
            foreach (var item in materials)
            {
                Console.WriteLine("\t\tAdd " + item.ToString());
            }
        }
    }

    public class TrousersProxy : Cloth
    {
        private Trousers _trousers;

        public TrousersProxy(ClothColor clothColor) : base(clothColor)
        {
            _trousers = new Trousers(clothColor);
        }

        public override List<object> GetMaterials()
        {
            return _trousers.GetMaterials();
        }

        public override void Sew(List<object> materials)
        {
            _trousers.Sew(materials);
        }
    }
}
