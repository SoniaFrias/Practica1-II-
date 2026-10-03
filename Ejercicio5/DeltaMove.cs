using UnityEngine;

public class DeltaMove : MonoBehaviour
{
    public Vector3 delta;
    private bool isPressed = false;

    void Update()
    {
        bool press = Input.GetAxis("Jump") == 1;
        if (press && !isPressed)
        {
            transform.position += delta; 
        }
        isPressed = press;
    }
}
