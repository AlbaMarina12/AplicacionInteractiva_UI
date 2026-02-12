using UnityEngine;

public class ToggleMenu : MonoBehaviour
{
    public GameObject menuPanel;

    public void Toggle()
    {
        menuPanel.SetActive(!menuPanel.activeSelf);
    }
}
