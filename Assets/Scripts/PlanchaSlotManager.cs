using UnityEngine;

public class PlanchaSlotManager : MonoBehaviour
{
    public Transform[] slots;
    private bool[] ocupados;

    void Start()
    {
        ocupados = new bool[slots.Length];
    }

    public Transform ObtenerSlotLibre()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (!ocupados[i])
            {
                return slots[i];
            }
        }

        return null;
    }

    public void OcuparSlot(Transform slot)
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i] == slot)
            {
                ocupados[i] = true;
                return;
            }
        }
    }
}