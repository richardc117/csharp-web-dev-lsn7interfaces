using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    class ConeComparer : IComparer<Cone>
    {
        public int Compare(Cone x, Cone y)
        {
            return Comparer<double>.Default.Compare(x.Cost, y.Cost);
        }
    }
}
