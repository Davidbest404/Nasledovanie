using System;
using UnityEngine;

namespace Task1
{
    [Serializable]
    public class Parallelogram : ConvexTetragon
    {
        public Parallelogram(float a, float b, float angle) : base(a, b, angle) { }
        public override float CountPerimeter(float a, float b)
        {
            return 2f * (a + b);
        }

        public override float CountArea(float a, float b, float angle)
        {
            float angleRadians = angle * Mathf.Deg2Rad;
            return a * b * Mathf.Sin(angleRadians);
        }
    }
}