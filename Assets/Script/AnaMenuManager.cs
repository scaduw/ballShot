using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnaMenuManager : MonoBehaviour
{

    void Start()
    {

        if (PlayerPrefs.HasKey("Level"))
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("Level"));
        }
        else
        {
            PlayerPrefs.SetInt("Level", 1);
            PlayerPrefs.SetInt("Yildiz", 0);
            SceneManager.LoadScene(1);
        }
    }
}
