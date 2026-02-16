using UnityEngine;
using UnityEngine.InputSystem;

public class DragSprite2D : MonoBehaviour
{
    private Camera cam;
    private bool dragging;
    private Vector3 offset;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        if (Mouse.current == null || cam == null) return;

        Vector2 mouseScreen = Mouse.current.position.ReadValue();
        Vector3 mouseWorld = cam.ScreenToWorldPoint(new Vector3(mouseScreen.x, mouseScreen.y, -cam.transform.position.z));

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            RaycastHit2D hit = Physics2D.Raycast(mouseWorld, Vector2.zero);
            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                dragging = true;
                offset = transform.position - mouseWorld;
            }
        }

        if (Mouse.current.leftButton.wasReleasedThisFrame)
        {
            dragging = false;
        }

        if (dragging && Mouse.current.leftButton.isPressed)
        {
            transform.position = new Vector3(mouseWorld.x, mouseWorld.y, transform.position.z) + offset;
        }
    }
}

