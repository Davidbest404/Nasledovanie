using System;

namespace Task2
{
    [Serializable]
    public class Square : Rectangle
    {
        public Square(float side) : base(side, side) { }
        public override float CountPerimeter(float a, float b)
        {
            return 4f * a;
        }

        public override float CountArea(float a, float b, float angle)
        {
            return a * a;
        }
    }
}