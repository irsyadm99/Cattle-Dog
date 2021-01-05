using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeSystem : MonoBehaviour
{
    public GameObject[] heart;
    public int life;
    //private bool dead = false;
    public GameObject gopanel;
    // Start is called before the first frame update
    void Start()
    {
        gopanel.SetActive(false);
        //life = heart.Length;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage()
    {
        if(life >= 1)
        {
            life -=1;
            Destroy(heart[life].gameObject);
            FindObjectOfType<AudioManager>().Play("LoseLife");

            if(life == 0)
            {
                //dead = true;
                Destroy(gameObject);
                gopanel.SetActive(true);
                FindObjectOfType<AudioManager>().Play("GameOver");
            }
            
        }
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        
        if(col.gameObject.CompareTag("enemy"))
        {
            TakeDamage();
        }
    }

    public void Restart()
    {
        Score.score = 0;
        FindObjectOfType<AudioManager>().Play("Button");
        SceneManager.LoadScene(5);
    }

    public void Quit()
    {
        FindObjectOfType<AudioManager>().Play("Button");
        SceneManager.LoadScene(0);
    }

    public void tesButton()
    {
        Debug.Log("NYALA KOK!");
    }

    /*public void gameOver()
    {
        if(life == 0)
        {
            gopanel.SetActive(true);
        }
    }*/
}
