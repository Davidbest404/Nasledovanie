using System;
using UnityEngine;

namespace Task2
{
    [Serializable]
    public class Parallelogram : ConvexTetragon
    {
        public Parallelogram(float a, float b, float angle) : base(a, b, angle) { }
        public override float CountPerimeter(float a, float b) => 2f * (a + b);
        public override float CountArea(float a, float b, float angle)
        {
            return a * b * Mathf.Sin(angle * Mathf.Deg2Rad);
        }
    }
}