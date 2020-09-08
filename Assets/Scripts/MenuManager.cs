using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    
    public void LoadGame()
    {
        SceneManager.LoadScene("IntroCutscene");
    }

    public void LoadTutorial()
    {
        Debug.Log("Load Tutorial");
    }

    public void LoadOptions()
    {
        Debug.Log("Load Options");
    }

    public void Quit()
    {
        Application.Quit();
    }

}
