using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("MainLevel");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Programmers()
    {
        SceneManager.LoadScene("CreditsProgrammers");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }


}
