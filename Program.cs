using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SoldierClone mainSoldier = new SoldierClone();
            mainSoldier.Health = 100;
            mainSoldier.Name = "Some name of real soldier";
            Console.WriteLine(String.Format("{0} :: {1}", mainSoldier.Name, mainSoldier.Health));
            SoldierClone cloneSoldier = mainSoldier.Clone() as SoldierClone;
            cloneSoldier.Health = 200;
            cloneSoldier.Name = "Clone of real soldier name";
            Console.WriteLine(String.Format("{0} :: {1}", cloneSoldier.Name, cloneSoldier.Health));
            Console.WriteLine(String.Format("{0} :: {1}", mainSoldier.GetHashCode().ToString(), cloneSoldier.GetHashCode().ToString()));
            Console.Write("mainSoldier.Equals(mainSoldier.Clone()) == ");
            Console.WriteLine(mainSoldier.Equals(mainSoldier.Clone()));
        }
    }
    public abstract class Soldier
    {

        public int Health { set; get; }
        public String Name { set; get; }

        public abstract Soldier Clone();
    }

    public class SoldierClone : Soldier
    {

        public override Soldier Clone()
        {
            return this.MemberwiseClone() as Soldier;
        }
    }

}
