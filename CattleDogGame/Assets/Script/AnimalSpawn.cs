using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawn : MonoBehaviour
{
    public Rigidbody2D rb;

    [SerializeField]
    public GameObject domba;

    public float waitingForNextSpawn = 3;
    public float theCountdown = 3;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        SpawnAnimal();
    }

    // Update is called once per frame
    void Update()
    {
        theCountdown -= Time.deltaTime;
         if(theCountdown <= 0)
         {
             SpawnAnimal ();
             theCountdown = waitingForNextSpawn;
         }
    }

    void SpawnAnimal()
    {

        bool spawned = false;
        while(!spawned)
        {
            Vector3 pos = new Vector3(Random.Range(-4f,4f), Random.Range(-4f,4f), 0f);
            if((pos - transform.position).magnitude < 3)
            {
                continue;
            }
            else
            {
                Instantiate(domba, pos, Quaternion.identity);
                spawned = true;
            }
        }

    }

   
}
