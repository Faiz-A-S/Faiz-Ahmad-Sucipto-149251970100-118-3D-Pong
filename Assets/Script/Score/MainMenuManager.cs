using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenuManager : MonoBehaviour
{
    private void Update()
    {
        Listener();
    }

    public void Listener()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }

    public void PlayGame() 
    { 
        SceneManager.LoadScene("Ingame");
    }

    public void BackMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void HowPlay()
    {
        SceneManager.LoadScene("HowPlay");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
