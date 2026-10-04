using UnityEngine;

public class DeltaMove : MonoBehaviour
{
    public Vector3 delta;

    void Update()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            transform.position += delta; 
        }
    }
}
