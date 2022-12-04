using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LostGame : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Boss");
    }

    public void StartOver()
    {
        SceneManager.LoadScene("Main Menu");
    }
    
}
