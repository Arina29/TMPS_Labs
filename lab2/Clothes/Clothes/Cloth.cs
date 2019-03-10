using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Clothes
{
    public abstract class Cloth
    {
        protected ClothColor _color;

        protected Cloth(ClothColor color)
        {
            _color = color;
        }

        public abstract List<Object> GetMaterials();

        public abstract void Sew(List<Object> materials);
    }
}
