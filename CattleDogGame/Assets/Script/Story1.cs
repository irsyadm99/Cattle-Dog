using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story1 : MonoBehaviour
{
    public void Next1()
    {
        FindObjectOfType<AudioManager2>().Play("Button");
        SceneManager.LoadScene(2);
    }
}
