using UnityEngine;

public class Move4 : MonoBehaviour
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
        Vector3 direction = sphere.transform.position - transform.position;
        direction.y = 0;
        direction = direction.normalized;
        transform.Translate(direction * speed * Time.deltaTime, Space.World); 
        transform.LookAt(sphere.transform);
    }
}
