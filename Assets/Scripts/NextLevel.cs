using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public Fader Fader;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        if (collision.gameObject.CompareTag("NextLevel"))
        {
                Destroy(collision.gameObject);
                Fader.FadeToLevel(currentScene + 1);
        }
    }
}
