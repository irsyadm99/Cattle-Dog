using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("animal"))
        {
            Score.score +=1;
            Destroy(col.gameObject);

            FindObjectOfType<AudioManager>().Play("GrabAnimal");
        }
        /*if(col.gameObject.CompareTag("Player"))
        {
            LifeSystem.TakeDamage(1);
        }*/
    }
}
