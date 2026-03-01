using UnityEngine;

public class TortillaCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Plancha"))
        {
            Debug.Log("La tortilla tocó la plancha");

            // Ejemplo: mover un poquito al centro
            transform.position = new Vector3(0, -1, 0);
        }
    }
}