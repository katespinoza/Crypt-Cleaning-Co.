using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    static public int health = 100;
    //static public GameObject monster;
    public GameObject mon;
    public static GameObject monster;

    [SerializeField] GameObject _Winner;

    public static GameObject win;

    //public GameObject deathEffect;
    private void Awake()
    {
       monster = mon;
        health = 100;
        win = _Winner;
        _Winner.SetActive(false);


    }
    static public void Takedamage(int damage)
    {


        Debug.Log("health: " + health);
        health -= damage;
        if (health <= 0)
        {
            Debug.Log("died");
            Destroy(monster);
            showWin(win);
            
        }

    }

    private static void showWin(GameObject r)
    {
        r.SetActive(true);
    }
    
    
    
}

