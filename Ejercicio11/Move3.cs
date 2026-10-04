using UnityEngine;

public class Move3 : MonoBehaviour
{
    public float speed;
    private GameObject sphere;

    void Start()
    {
       sphere = GameObject.FindWithTag("Sphere");
    }
    // Update is called once per frame
    void Update()
    {  
        Vector3 direction = (sphere.transform.position - transform.position).normalized;
        direction.y = 0;
        transform.Translate(direction * speed * Time.deltaTime); 
    }
}
