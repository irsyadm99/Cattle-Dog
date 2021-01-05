using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story3 : MonoBehaviour
{
    public void Next3()
    {
        FindObjectOfType<AudioManager2>().Play("Button");
        SceneManager.LoadScene(4);
    }
}
