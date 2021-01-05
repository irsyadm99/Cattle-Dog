using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story4 : MonoBehaviour
{
    public void GoGame()
    {
        FindObjectOfType<AudioManager2>().Play("Button");
        SceneManager.LoadScene(5);
    }
}
