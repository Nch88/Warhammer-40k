using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyBuilder.Model
{
    public enum Armies
    {
        Necrons
    }

    public class Unit
    {
        public Armies Army { get; set; }
        public string Name { get; set; }

        //Attributes
        public int WeaponSkill { get; set; }
        public int BalisticSkill { get; set; }
        public int Toughness { get; set; }
        public int Strength { get; set; }
        public int Wounds { get; set; }
        public int Attacks { get; set; }
        public int Initiative { get; set; }
        public int Leadership { get; set; }

        public Tuple<int, int> UnitMinMaxSize { get; set; }
        public int PointsPerModel { get; set; }
    }

    public class SelectedUnit : Unit
    {
        public int UnitSize { get; set; }

        public int PointCost { get; set; }
    }
}
