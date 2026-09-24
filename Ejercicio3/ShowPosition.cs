using UnityEngine;

public class ShowPosition : MonoBehaviour
{
    void OnGUI()
    {
        Vector3 position = transform.position;
        GUI.Label(new Rect(20, 20, 250, 50), $"Posición: {position}");
    }
}
