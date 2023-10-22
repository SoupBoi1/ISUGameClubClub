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
        if (GameManager.Instance.step == 1)
        {
            GameManager.Instance.buyMessage.SetActive(false);
            GameManager.Instance.insideShopMessage.SetActive(true);
            GameManager.Instance.step = 2;
        }
        if (!down)
        {
            transform.position = buttonDownPos.position;
            theShopPanel.SetActive(true);
            down = true;
        }
        GameManager.Instance.Pause();
    }
    public void moveUp() {

        if (down)
        {
            if (GameManager.Instance.step == 2)
            {
                GameManager.Instance.insideShopMessage.SetActive(false);
                GameManager.Instance.outsideShopMessage.SetActive(true);
                GameManager.Instance.step = 3;
            }
            opss.position = buttonUpPos.position;

            theShopPanel.SetActive(false);
            down = false;
        }
        GameManager.Instance.Resume();
    }
}
