using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public static GameControl control;
    public  int collectibles = 0;
    // Start is called before the first frame update
    private void Awake()
    {
        if(control == null)
        {
            control = this;
            DontDestroyOnLoad(gameObject);
        }
        else if(control != this)
        {
            Destroy(gameObject);
        }
    }

}
