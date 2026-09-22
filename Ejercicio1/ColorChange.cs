using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public int frame_await = 120;
    private Vector3 color;

    private int initial_frame;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initial_frame = Time.frameCount;

        float red = Random.Range(0f, 1f);
        float green = Random.Range(0f, 1f);
        float blue = Random.Range(0f, 1f);
        color = new Vector3(red, green, blue);

       ChangeColor();
    }

    // Update is called once per frame
    void Update()
    {
        int frames = Time.frameCount - initial_frame;
        if (frames >= frame_await)
        {
            Debug.Log("Cambio de color: " + frames); 
            initial_frame = Time.frameCount;
            int index = Random.Range(0,3);
            color[index] = Random.Range(0f,1f);
            ChangeColor();
        }
        
    }

    void ChangeColor()
    {
        GetComponent<Renderer>().material.color = new Color(color.x, color.y, color.z);
    }
}

