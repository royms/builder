using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class BaconHam : HamburgerBuilder
    {
        protected override void PrepareBun()
        {
            hamburger.PrepareBun("not Healthy flour");
        }

        protected override void PrepareMain()
        {
            hamburger.PrepareMain("burger with bacon");
        }

        protected override void PrepareTopping()
        {
            hamburger.PrepareTopping("bacon");
        }

        protected override void PrepareVegg()
        {
            hamburger.PrepareVegg("Tomato and cucumber");
        }

        protected override void PreparePriceLabel()
        {
            hamburger.PreparePriceLabel("Today sale - 70 ILS");
        }
    }
}
