using UnityEngine;

public class OpenLink : MonoBehaviour
{
    public void AbrirURL(string url)
    {
        Application.OpenURL(url);
    }
}
