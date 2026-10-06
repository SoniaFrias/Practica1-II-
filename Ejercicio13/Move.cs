using UnityEngine;

public class Move5 : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {  
        float horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(0, horizontal, 0);
        Debug.DrawRay(transform.position, transform.forward * 100, Color.green);
        transform.Translate(transform.forward * speed * Time.deltaTime, Space.World); 
    }
}
