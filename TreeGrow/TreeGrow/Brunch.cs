using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeGrow
{
    class Brunch : PlantBase
    {
        int length, width;
        int angle;
        float startPoint;
        PlantBase parent;
        Tree parentTree;

        public Brunch(Brunch brunchParent) //передаем PlantBase или Три для тру ооп
        {
            length = 1;
            width = 1;
            angle = GetAngle();
            startPoint = GetStartPoint();
            parent = brunchParent;
        }


        public override void Grow()
        {
            length++;
            width++;
            TryMakeBrunch();
        }

        public override void Die()
        {

        }

        public void TryMakeBrunch()
        {
            if (parentTree.brunches.Count > Genom.maxBrunches)
                return;

            var r = new Random();
            var chance = r.Next(Genom.ChanceOfNewBrunch);

            if (chance == 1)
            {
                MakeBrunch(this);
            }
        }

        public Brunch MakeBrunch(Brunch parentBrunch)
        {
            return new Brunch(parentBrunch);
        }

        public int GetAngle()
        {
            var r = new Random();
            var angle = r.Next(5, 90);
            return angle;
        }

        public int GetStartPoint()
        {
            var r = new Random();
            var point = r.Next(1, 99);
            return point/100;
        }
    }
}
