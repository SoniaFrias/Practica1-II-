using UnityEngine;

public class Speed : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            string press = Input.GetKey(KeyCode.UpArrow) ? "Up" : "Down";
            Debug.Log($"{press}: {Input.GetAxis("Vertical") * speed}");
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            string press = Input.GetKey(KeyCode.RightArrow) ? "Right" : "Left";
            Debug.Log($"{press}: {Input.GetAxis("Horizontal") * speed}");
        }
    }
}
