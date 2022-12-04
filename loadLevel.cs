using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//https://youtu.be/ckjUm6uUDO4

public class loadLevel : MonoBehaviour
{
    //public GameManage script;
    private bool enterAllowed;
    private string sceneToLoad;
    static public int enteredWitch = 0;
    static public int enteredVamp = 0;
    static public int enteredFairy = 0;
    static public bool atJob, atCave;
    static public bool enteredFall, enteredWinter, enteredCave;

    private int expectedAmount;
    private void Awake()
    {
        expectedAmount = GameControl.control.collectibles+3;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.GetComponent<FallForestLoader>())
        {
            if(!enteredFall)
            {
                
                sceneToLoad = "FallForest";
                enterAllowed = true;
                //enteredFall = true;
            }
            
            
        }
        else if(collision.GetComponent<StarterLoader>())
        {
            if ((GameControl.control.collectibles == expectedAmount) || ((SceneManager.GetActiveScene().name != "Witch's House Cleaned") || (SceneManager.GetActiveScene().name != "Witch's House") || (SceneManager.GetActiveScene().name != "Vampire") || (SceneManager.GetActiveScene().name != "Fairy") ||( SceneManager.GetActiveScene().name != "Boss")))
            {
                sceneToLoad = "Starter";
                enterAllowed = true;
            }

        }
        else if (collision.GetComponent<WinterForestLoader>())
        {
            if (!enteredWinter)
            {
                sceneToLoad = "Winter Forest";
                enterAllowed = true;
                //enteredWinter = true;
            }
        }
        else if (collision.GetComponent<WitchLoader>())
        {
            if (enteredWitch == 1)
            {
                sceneToLoad = "Witch's House Cleaned";
                enterAllowed = true;
            }
            else
            {
                sceneToLoad = "Witch's House";
                enterAllowed = true;
            }

        }
        else if (collision.GetComponent<JobLoader>())
        {
            atJob = true;
            if (enteredWitch == 1)
            {
                if (enteredVamp == 1)
                {
                    if (enteredFairy == 1)
                    {
                        if (GameControl.control.collectibles == 9)
                        {
                            sceneToLoad = "Boss";
                            enterAllowed = true;
                        }

                    }
                    else
                    {
                        sceneToLoad = "Fairy";
                        enterAllowed = true;
                    }
                    
                }
                else
                {
                    sceneToLoad = "Vampire";
                    enterAllowed = true;
                    
                }
            }

        }
        else if(collision.GetComponent<CaveLoader>())
        {
            atCave = true;
            if (!enteredCave)
            {
                sceneToLoad = "Cave";
                enterAllowed = true;
               // enteredCave = true;

            }
            
        }
 
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<FallForestLoader>())
        {
            
            enterAllowed = false;
        }
        if (collision.GetComponent<StarterLoader>())
        {
            
            enterAllowed = false;

        }
        if (collision.GetComponent<WinterForestLoader>())
        {
            
            enterAllowed = false;
        }
        if (collision.GetComponent<WitchLoader>())
        {
            enterAllowed = false;
        }
        if (collision.GetComponent<JobLoader>())
        {
            enterAllowed=false;
            
        }
        if (collision.GetComponent<CaveLoader>())
        {
            
            enterAllowed = false;

        }
    }

    private void Update()
    {
        /*if (sceneToLoad == "Starter" )
        {
            if ((SceneManager.GetActiveScene().name == "Witch's House Cleaned" || SceneManager.GetActiveScene().name == "Witch's House" || SceneManager.GetActiveScene().name == "Vampire" || SceneManager.GetActiveScene().name == "Fairy" || SceneManager.GetActiveScene().name == "Boss"))
            {
                enterAllowed = true;
            }
            else
            {
                enterAllowed = false;
            }
        }*/
        if(SceneManager.GetActiveScene().name != "Witch's House")
        {
            if (SceneManager.GetActiveScene().name != "Witch's House Cleaned")
            {
                if (SceneManager.GetActiveScene().name != "Vampire")
                {
                    if (SceneManager.GetActiveScene().name != "Fairy")
                    {
                        if (SceneManager.GetActiveScene().name != "Boss")
                        {
                            if (sceneToLoad == "Starter" && GameControl.control.collectibles != expectedAmount)
                            {
                                enterAllowed = false;
                            }
                        }
                    }
                }
            }
        }
        /*else if (SceneManager.GetActiveScene().name != "Witch's House Cleaned")
        {
            if (sceneToLoad == "Starter")
            {
                enterAllowed = false;
            }
        }
       /* if (SceneManager.GetActiveScene().name != "Vampire")
        {
            if (sceneToLoad == "Starter")
            {
                enterAllowed = false;
            }
        }
        if (SceneManager.GetActiveScene().name != "Fairy")
        {
            if (sceneToLoad == "Starter")
            {
                enterAllowed = false;
            }
        }
        if (SceneManager.GetActiveScene().name != "Boss")
        {
            if (sceneToLoad == "Starter")
            {
                enterAllowed = false;
            }
        }*/

        if (enterAllowed && Input.GetKey(KeyCode.RightShift))
        {
            if (sceneToLoad == "Witch's House")
            {
                enteredWitch = 1;
            }

            if (sceneToLoad == "Vampire")
            {
                enteredVamp = 1;
            }
            if (sceneToLoad == "Fairy")
            {
                enteredFairy = 1;
            }
            if (sceneToLoad == "FallForest")
            {
                enteredFall = true;
            }
            if (sceneToLoad == "Winter Forest")
            {
                enteredWinter = true;
            }
            if (sceneToLoad == "Cave")
            {
                enteredCave = true;
            }
            
            

            SceneManager.LoadScene(sceneToLoad); 

            
            
        }
    }
}
