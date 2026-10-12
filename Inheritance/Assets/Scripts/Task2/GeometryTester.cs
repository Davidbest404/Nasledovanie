using UnityEngine;
using Task1;

public class GeometryTester : MonoBehaviour
{
    [SerializeField] Parallelogram _myParallelogram = new Parallelogram(5f, 10f, 30f);
    [SerializeField] Square _mySquare = new Square(4f);

    void Start() => TestShapes();

    void TestShapes()
    {
        float pArea = _myParallelogram.CountArea(_myParallelogram.SideA, _myParallelogram.SideB, _myParallelogram.AngleDegrees);
        Debug.Log($"Площадь параллелограмма: {pArea}");
        float sPerimeter = _mySquare.CountPerimeter(_mySquare.SideA, _mySquare.SideB);
        Debug.Log($"Периметр квадрата: {sPerimeter}");
    }
}