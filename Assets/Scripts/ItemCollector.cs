using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    public int puffkins = 0;

    [SerializeField] private TMP_Text puffkinsText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string currentScene = SceneManager.GetActiveScene().name;

        if (collision.gameObject.CompareTag("Puffkin"))
        {
            if(currentScene == "Level 1" || currentScene == "Level 2")
            {
                Destroy(collision.gameObject);
                puffkins++;
                puffkinsText.text = "Puffkins: " + puffkins + " / 2";
            }

            else
            {
                Destroy(collision.gameObject);
                puffkins++;
                puffkinsText.text = "Puffkins: " + puffkins + " / 3";
            }
            
        }
    }
}
