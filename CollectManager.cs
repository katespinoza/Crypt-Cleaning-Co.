using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectManager : MonoBehaviour
{
    public static CollectManager instance;

    public TextMeshProUGUI CollectibleText;
    
    
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        CollectibleText.text = GameControl.control.collectibles.ToString();
    }

    public void addCollectible()
    {
        GameControl.control.collectibles++;
        CollectibleText.text = GameControl.control.collectibles.ToString();
    }
}
