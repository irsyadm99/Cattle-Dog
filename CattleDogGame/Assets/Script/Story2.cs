using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story2 : MonoBehaviour
{
    public void Next2()
    {
        FindObjectOfType<AudioManager2>().Play("Button");
        SceneManager.LoadScene(3);
    }
}
