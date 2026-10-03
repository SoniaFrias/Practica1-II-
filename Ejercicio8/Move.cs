using UnityEngine;
using UnityEngine.Rendering;

public class Move : MonoBehaviour
{
    public Vector3 direction;
    public float speed;
    void Start()
    {
        speed = 2;
        transform.position = new Vector3(0, 0, 0);
    }

    void Update()
    {
        transform.Translate(direction * speed);
        //transform.Translate(direction * speed, Space.World);
    }
}
