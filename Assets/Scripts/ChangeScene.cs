using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public Fader fader;

    void OnEnable()
    {
        string currentScene = SceneManager.GetActiveScene().name;

        if (currentScene == "Opening")
        {
            fader.FadeToLevel(2);
        }
        if (currentScene == "Puffkin Cutscene")
        {
            fader.FadeToLevel(3);
        }
        if (currentScene == "Ending")
        {
            fader.FadeToLevel(0);
        }
    }
}
