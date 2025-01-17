using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    // Start is called before the first frame update
    Health damage;
    public GameObject player;

    public float speed;
    public bool left = true;
    public float distance;

    void Start()
    {
        damage = player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.tag == "Spike" && left)
        {
            transform.position= new Vector2(transform.position.x - speed, transform.position.y);

        }

        else if(gameObject.tag == "Spike" && !left)
        {
            transform.position = new Vector2(transform.position.x+ speed, transform.position.y);
        }

        //if(gameObject.tag == Fly)
        //{
        //    distance= Vector2.Distance(transform.position, player.transform.position);
        //    Vector2 direction = player.transform.position-transform.position;
        //    transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position,speed*Time.deltaTime);
        
            
        //}
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.tag == "Player")
        {
            damage.TakeDamage(1);

        }

        if(coll.tag == "Wall" && left == true)
        {
            left = false;
        }

        else if (coll.tag == "Wall" && left == false)
        {
            left = true;
        }
    }
}
