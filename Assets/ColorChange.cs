using UnityEngine;

public class ParedColor : MonoBehaviour
{
    public Color nuevoColor = Color.yellow;

    private void OnCollisionEnter(Collision collision)
    {
        // Verifica si el objeto que chocó tiene el Tag "Player"
        if (collision.gameObject.CompareTag("Player"))
        {
            Renderer rendererPared = GetComponent<Renderer>();

            // En Unity 6 (URP) se usa SetColor con la propiedad "_BaseColor"
            if (rendererPared.material.HasProperty("_BaseColor"))
            {
                rendererPared.material.SetColor("_BaseColor", nuevoColor);
            }
            else
            {
                // Respaldo por si usás el shader estándar antiguo
                rendererPared.material.color = nuevoColor;
            }
        }
    }
}