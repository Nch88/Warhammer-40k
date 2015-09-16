using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyBuilder.Model
{
    public class Upgrade
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int PointsPerModel { get; set; }

        public Tuple<int, int> UpgradeMinMaxCount { get; set; }
    }

    public class SelectedUpgrade : Upgrade
    {
        public int UpgradedUnits { get; set; }
    }
}
