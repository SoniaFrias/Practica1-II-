using UnityEngine;

public class VectorOperations : MonoBehaviour
{
    public Vector3 vector1, vector2;
    // show on inspector
    [SerializeField] private float magnitude1, magnitude2, angle, distance;
    [SerializeField] private string higher;

    // Executes when a value is changed in the inspector
    void OnValidate()
    {
        magnitude1 = Vector3.Magnitude(vector1);
        magnitude2 = Vector3.Magnitude(vector2);
        Debug.Log("Magnitud del vector 1: " + magnitude1);
        Debug.Log("Magnitud del vector 2: " + magnitude2);

        angle = Vector3.Angle(vector1, vector2);
        Debug.Log("Angulo: " + angle);

        distance = Vector3.Distance(vector1, vector2);
        Debug.Log("Distancia: " + distance);

        if (vector1[1] == vector2[1])
        {
            higher = "Misma altura";
            Debug.Log("Los vectores se encuentran a la misma altura"); 
        } 
        else
        {
            higher = vector1[1] > vector2[1] ? "vector 1" : "vector 2";
            Debug.Log("El " + higher + " se encuentra a una altura mayor"); 
        }
    }

}
