using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManage : MonoBehaviour
{
    [SerializeField] GameObject _JobError;
    [SerializeField] GameObject _joberrortext;
    [SerializeField] GameObject _CollectibleError;
    [SerializeField] GameObject _collectibleerrortext;

    private bool gaveError,gaveCaveError,gavebosserror;
    


    // Start is called before the first frame update
    void Start()
    {
        _JobError.SetActive(false);
        _joberrortext.SetActive(false);
        _CollectibleError.SetActive(false);
        _collectibleerrortext.SetActive(false);
        gaveError = false;
        gavebosserror = false;
    }

    // Update is called once per frame
    void Update()
    {
        

        if ((loadLevel.enteredWitch < 1) && loadLevel.atJob && !gaveError)
        {
           _JobError.SetActive(true);
           _joberrortext.SetActive(true);
           gaveError = true;
           
        }
        
        if(loadLevel.enteredFairy == 1 && GameControl.control.collectibles != 7 && loadLevel.atJob && !gavebosserror)
        {
            _CollectibleError.SetActive(true);
            _collectibleerrortext.SetActive(true);
            gavebosserror = true;
        }
        if (Input.GetKey(KeyCode.RightShift))
        {
            _JobError.SetActive(false);
            _joberrortext.SetActive(false);
            _CollectibleError.SetActive(false);
            _collectibleerrortext.SetActive(false);


        }

        
    }
}
