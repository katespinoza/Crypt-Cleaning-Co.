using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    public GameObject collectible;
    private bool collided;
    private bool pickedUP = false;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collided = true;

    }
    private void Update()
    {
        if (collided && !pickedUP && Input.GetKey(KeyCode.RightShift))
        {
            pickedUP = true;
            collectible.SetActive(false);
            CollectManager.instance.addCollectible();
        }
    }
}
