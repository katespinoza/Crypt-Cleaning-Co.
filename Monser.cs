using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Monser : MonoBehaviour
{
    public GameObject player;
    public float moveSpeed;
    public Transform playerTransform;
    private bool collided;

    

    public bool isChasing;
    public float chaseDistance;

    
    void Update()
    {
         
         if (isChasing)
         {
             if(transform.position.x > playerTransform.position.x)
             {

                 transform.position += Vector3.left * moveSpeed * Time.deltaTime;
             }

         }
         else
         {
             if(Vector2.Distance(transform.position, playerTransform.position) < chaseDistance)
             {
                 isChasing = true;
             }
         }

     }
     

     

    }

