using System;
using UnityEngine;

namespace Task2
{
    [Serializable]
    public class ConvexTetragon : ITetragon
    {
        [SerializeField] float _sideA;
        [SerializeField] float _sideB;
        [SerializeField] float _angleDegrees;

        public float SideA => _sideA;
        public float SideB => _sideB;
        public float AngleDegrees => _angleDegrees;

        public ConvexTetragon(float a, float b, float angle)
        {
            _sideA = a;
            _sideB = b;
            _angleDegrees = angle;
        }

        public virtual float CountPerimeter(float a, float b)
        {
            return 0f;
        }

        public virtual float CountArea(float a, float b, float angle)
        {
            return 0f;
        }
    }
}
