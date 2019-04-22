using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeGrow
{
    class Genom
    {
        public static readonly TimeSpan livingTime = TimeSpan.FromSeconds(60);
        public static readonly int growingPause = 500;
        public static readonly int maxBrunches = 20;
        public static readonly int maxLeafs = 80;
        public static readonly int ChanceOfNewBrunch = 10;
        public static readonly int ChanceOfNewLeaf = 5;

        public static readonly int maxBrunchLength = 10;
        public static readonly int maxTrunkLength = 20;
        public static readonly int maxBrunchWidth = 3;
        public static readonly int maxTrunkWidth = 4;
        public static readonly double minSizeReadyToChild = 0.4;

    }
}
