using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

public class showMoney : MonoBehaviour
{

    public TMP_Text textmeshPro ;
    // Start is called before the first frame update
    void Start()
    {
        TMP_Text textmeshPro = GetComponent<TMP_Text>();
      
    }

    // Update is called once per frame
    void Update()
    {
        textmeshPro.text = Money.Instance.getMoney()+ " clubs" ;
    }
}
