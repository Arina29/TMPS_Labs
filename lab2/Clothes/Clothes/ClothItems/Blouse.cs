using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clothes.ClothItems
{
    public class Blouse : Cloth
    {
        public Blouse(ClothColor clothColor) : base(clothColor)
        {
        }

        public override List<object> GetMaterials()
        {
            var materials = new List<object>
            {
                Materials.Cotton,
                Accessories.Rhinestones,
                Additional.Button
            };
            return materials;
        }

        public override void Sew(List<Object> materials)
        {
            Console.WriteLine("\tSewing a blouse");
            base._color.ChooseColor();
            foreach (var item in materials)
            {
                Console.WriteLine("\t\tAdd " + item.ToString());
            }
        }
    }

    public class BlouseProxy : Cloth
    {
        private Blouse _blouse;

        public BlouseProxy(ClothColor clothColor) : base(clothColor)
        {
            _blouse = new Blouse(clothColor);
        }

        public override List<object> GetMaterials()
        {
            var materials = _blouse.GetMaterials();
            materials.Add(Additional.Collar);
            return materials;
        }

        public override void Sew(List<Object> materials)
        {
            _blouse.Sew(materials);
        }
    }
}
