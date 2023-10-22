using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

public class showMoney : MonoBehaviour
{
    public Text text ;
    // Start is called before the first frame update
    void Start()
    {
        Text textmeshPro = GetComponent<Text>();
      
    }

    // Update is called once per frame
    void Update()
    {
        text.text = Money.Instance.getMoney()+ " clubs" ;
    }
}
