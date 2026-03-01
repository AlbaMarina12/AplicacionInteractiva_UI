using UnityEngine;

public class TortillaSourceClick : MonoBehaviour
{
    [Header("Referencias")]
    public PlanchaSlotManager planchaManager;   // Arrastra aquí tu PlanchaManager (donde está PlanchaSlotManager)
    public GameObject tortillaPrefab;          // Arrastra aquí tu Prefab Tortillas_0

    [Header("Spawn settings (opcional)")]
    public Transform spawnPoint;               // Si lo dejas vacío, usa este mismo objeto

    private void OnMouseDown()
    {
        // Si no asignaste spawnPoint, usamos el mismo objeto
        if (spawnPoint == null) spawnPoint = transform;

        // Validación básica
        if (planchaManager == null || tortillaPrefab == null)
        {
            Debug.LogWarning("Faltan referencias en TortillaSourceClick (planchaManager o tortillaPrefab).");
            return;
        }

        // 1) Buscar slot libre
        Transform slotLibre = planchaManager.ObtenerSlotLibre();

        // 2) Si no hay, ya no spawnea
        if (slotLibre == null)
        {
            Debug.Log("Ya no hay espacio en la plancha.");
            return;
        }

        // 3) Crear tortilla nueva
        GameObject nuevaTortilla = Instantiate(tortillaPrefab, spawnPoint.position, Quaternion.identity);

        // 4) Ponerla en el slot libre
        nuevaTortilla.transform.position = slotLibre.position;

        // 5) Marcar slot como ocupado
        planchaManager.OcuparSlot(slotLibre);
    }
}