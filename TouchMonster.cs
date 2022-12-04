using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMonster : MonoBehaviour
{
    [SerializeField] GameObject _Canvas;
    
    private void Awake()
    {
        _Canvas.SetActive(false);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Monster"))
        {
            Debug.Log("collided");
            
            Destroy(gameObject);
            _Canvas.SetActive(true);
        }

      

    }
    
}
