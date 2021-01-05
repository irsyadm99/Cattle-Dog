using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   public float moveSpeed = 5f;
   public Rigidbody2D rb;
   Vector2 movement;
   public Animator animator;
   //public GameObject domba;

   /*void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        SpawnAnimal();
        
    }*/

    // Update is called once per frame
    void Update()
    {       
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    /*void SpawnAnimal()
    {

        bool spawned = false;
        while(!spawned)
        {
            Vector3 pos = new Vector3(Random.Range(-7f,7f), Random.Range(-4f,4f), 0f);
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

    void OnTrigger(Collider2D collision)
    {
        Destroy(collision.gameObject);
        SpawnAnimal();
    }*/
}
