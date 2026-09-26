using UnityEngine;

public class Distance : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 cylinder = GameObject.FindWithTag("Cylinder").transform.position;
        Vector3 cube = GameObject.FindWithTag("Cube").transform.position;
        Debug.Log($"Distancia respecto al cilindro: {Vector3.Distance(cylinder, transform.position)}");
        Debug.Log($"Distancia respecto al cubo: {Vector3.Distance(cube, transform.position)}");
    }
}
