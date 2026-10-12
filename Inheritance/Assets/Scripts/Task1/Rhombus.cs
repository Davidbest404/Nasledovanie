using System;

namespace Task1
{
    [Serializable]
    public class Rhombus : Parallelogram
    {
        public Rhombus(float side, float angle) : base(side, side, angle) { }
        public override float CountPerimeter(float a, float b)
        {
            return 4f * a; 
        }
    }
}