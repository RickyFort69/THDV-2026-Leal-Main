using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // Referencia al Transform del jugador
    public Vector3 offset = new Vector3(0, 10, -5); // Distancia y altura de la cámara

    void Update()
    {
        if (target != null)
        {
            // La cámara sigue la posición del jugador conservando el offset
            transform.position = target.position + offset;
        }
    }
}