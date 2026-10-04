using UnityEngine;

public class Move2 : MonoBehaviour
{
    public float speed;

    public KeyCode up;
    public KeyCode down;
    public KeyCode right;
    public KeyCode left; 

    // Update is called once per frame
    void Update()
    {
        float horizontal = (Input.GetKey(right) ? 1f : 0f) - (Input.GetKey(left) ? 1f : 0f);
        float vertical = (Input.GetKey(up) ? 1f : 0f) - (Input.GetKey(down) ? 1f : 0f);
        Vector3 direction = new Vector3(horizontal, 0f, vertical);
        transform.Translate(direction * speed); 
    }
}
