using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clean : MonoBehaviour
{
    public GameObject cleanItem;
    private bool collided;
    private bool cleanedUP = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collided = true;     
        
    }
    private void Update()
    {
        if (collided && !cleanedUP && Input.GetKey(KeyCode.RightShift))
        {
            cleanedUP = true;
            Destroy(cleanItem);
        }
    }
}

