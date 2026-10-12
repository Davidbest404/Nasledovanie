using System;

namespace Task2
{
    [Serializable]
    public class Rectangle : Parallelogram
    {
        public Rectangle(float a, float b) : base(a, b, 90f) { }
        public override float CountArea(float a, float b, float angle)
        {
            return a * b;
        }
    }
}
