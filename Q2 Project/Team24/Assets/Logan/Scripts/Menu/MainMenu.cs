using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Main Level");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void BackButton2()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Programmers()
    {
        SceneManager.LoadScene("CreditsProgrammers");
    }

    public void SophiaButton()
    {
        SceneManager.LoadScene("CreditsSophia");
    }

    public void CarinButton()
    {
        SceneManager.LoadScene("CreditsCarin");
    }

    public void FinchButton()
    {
        SceneManager.LoadScene("CreditsFinch");
    }

    public void RansomButton()
    {
        SceneManager.LoadScene("CreditsRansom");
    }

    public void KatButton()
    {
        SceneManager.LoadScene("CreditsKat");
    }

    public void ContinueL1()
    {
        SceneManager.LoadScene("Duplicate1");
    }

    public void ContinueL2()
    {
        SceneManager.LoadScene("WinScene");
    }

    public void LevelLose()
    {
        SceneManager.LoadScene("Main Level");
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
