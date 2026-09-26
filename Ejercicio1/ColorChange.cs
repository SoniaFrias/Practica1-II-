using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public int frameAwait = 120;
    private int initialFrame;
    private Vector3 color;
    private Renderer rd;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initialFrame = Time.frameCount;

        for (int i = 0; i < 3; i++)
        {
            color[i] = Random.Range(0f, 1f);
        }
        rd = GetComponent<Renderer>();
        ChangeColor();
    }

    // Update is called once per frame
    void Update()
    {
        int frames = Time.frameCount - initialFrame;
        if (frames >= frameAwait)
        {
            Debug.Log("Cambio de color: " + frames); 
            initialFrame = Time.frameCount;
            int index = Random.Range(0,3);
            color[index] = Random.Range(0f,1f);
            ChangeColor();
        }
        
    }

    void ChangeColor()
    {
        rd.material.color = new Color(color.x, color.y, color.z);
    }
}
