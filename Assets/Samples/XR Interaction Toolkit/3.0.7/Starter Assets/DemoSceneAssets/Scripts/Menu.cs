using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnPlayButton ()
    {
        SceneManager.LoadScene("FirstLevel");

    }

    public void OnQuitButton ()
    {
        Application.Quit();
    }
}
