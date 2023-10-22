using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonDropDown : MonoBehaviour
{

    public Transform buttonDownPos;
    public Transform buttonUpPos;

    public Transform opss;


    public GameObject theShopPanel;

    static bool down = false;

    public float scaleTo = 456;

    // Start is called before the first frame update
    void Start()
    {
        
    }



    public void moveDown()
    {
        if (!down)
        {
            transform.position = buttonDownPos.position;
            theShopPanel.SetActive(true);
            down = true;
        }
        
        

    }
    public void moveUp() {

        if (down)
        {
            opss.position = buttonUpPos.position;

            theShopPanel.SetActive(false);
            down = false;
        }
        

    }


}
