using UnityEngine;

public class DraggableTortilla : MonoBehaviour
{
    public PlanchaSlotManager planchaManager;

    private bool yaColocada = false;

    void OnMouseDown()
    {
        if (yaColocada) return;

        Transform slotLibre = planchaManager.ObtenerSlotLibre();

        if (slotLibre != null)
        {
            transform.position = slotLibre.position;
            planchaManager.OcuparSlot(slotLibre);
            yaColocada = true;
        }
    }
}