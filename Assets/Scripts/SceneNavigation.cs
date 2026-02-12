using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigation : MonoBehaviour
{
    public void GoToGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void GoToInstrucciones()
    {
        SceneManager.LoadScene("Instrucciones");
    }

    public void GoToCreditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

