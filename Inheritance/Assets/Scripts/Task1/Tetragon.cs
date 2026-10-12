using System;
using UnityEngine;

namespace Task1
{
    [Serializable]
    public class Tetragon
    {
        [SerializeField] float _sideA;
        [SerializeField] float _sideB;
        [SerializeField] float _angleDegrees;

        public float SideA => _sideA;
        public float SideB => _sideB;
        public float AngleDegrees => _angleDegrees;

        public Tetragon(float a, float b, float angle)
        {
            _sideA = a;
            _sideB = b;
            _angleDegrees = angle;
        }

        public virtual float CountPerimeter(float a, float b)
        {
            Debug.LogWarning("Tetragon: недостаточно данных для точного расчета периметра четырехугольника");
            return 0f;
        }

        public virtual float CountArea(float a, float b, float angle)
        {
            Debug.LogWarning("Tetragon: недостаточно данных для точного расчета площади четырехугольника");
            return 0f;
        }
    }
}