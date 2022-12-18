using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Play Button
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Github Button
    public void GithubButton()
    {
        Application.OpenURL("www.github.com/ravarroTUD/Kangahop-main");
    }

    // Quit Button
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
