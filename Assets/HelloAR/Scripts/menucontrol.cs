using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class menucontrol : MonoBehaviour
{

    public void Quitgame()
    {
        // zorft ervoor dat je het spel kan eindigen
        Application.Quit();
    }

    public void loadscene(string level)
    {
        // dit laad de scenes als je dat oproept
        SceneManager.LoadScene(level);

    }

    public void LoadMenu()
    {
        // laat het startscherm op het pause scherm
        Time.timeScale = 1f;
        SceneManager.LoadScene("startscherm");
    }
}
