using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    
    public void playButton(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void exitButton()
    {
        Application.Quit();
    }

    public void optionsButton()
    {

    }
}
