using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clothes.ClothItems
{
    public class LeatherJacket : Cloth
    {
        public LeatherJacket(ClothColor clothColor) : base(clothColor)
        {
        }

        public override List<object> GetMaterials()
        {
            var materials = new List<object>
            {
                Materials.Leather,
                Accessories.Stickers,
                Accessories.Glitter,
                Accessories.Stickers,
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

    public class LeatherJacketProxy : Cloth
    {
        private LeatherJacket _jacket;

        public LeatherJacketProxy(ClothColor clothColor) : base(clothColor)
        {
            _jacket = new LeatherJacket(clothColor);
        }

        public override List<object> GetMaterials()
        {
            return _jacket.GetMaterials();
        }

        public override void Sew(List<object> materials)
        {
            _jacket.Sew(materials);
        }
    }
}
