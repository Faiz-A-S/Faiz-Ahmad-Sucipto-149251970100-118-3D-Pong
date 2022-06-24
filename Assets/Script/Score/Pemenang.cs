using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pemenang : MonoBehaviour
{
    public Text pemenang;
    public GameObject yui;

    public void GameOver(string nama) 
    {
        yui.SetActive(true);
        Debug.Log(nama);
        pemenang.text = nama;
        Time.timeScale = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
