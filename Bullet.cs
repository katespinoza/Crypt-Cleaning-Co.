using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    int damage = 10;

    // Start is called before the first frame update
    void Start()
    {

        rb.velocity = transform.right * speed;
    }


    /*void OnCollisionEnter2d(Collision2D hitInfo)
    {
        Debug.Log("hit");
        *//*Enemy enemy = hitInfo.GetComponent<Enemy>();
        if(enemy != null)
        {
            enemy.Takedamage(damage);
        }
        Destroy(gameObject);*//*
        
            Destroy(hitInfo.gameObject);
            Destroy(gameObject);
        
        

    }*/
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hit");
        if (collision.gameObject.tag.Equals("Monster"))
        {
            Debug.Log("collided");
            Enemy.Takedamage(damage);
            Destroy(gameObject);
        }

    }



}
