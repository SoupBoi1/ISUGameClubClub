using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemUIscript : MonoBehaviour
{

    public Selectable[] FactorySelectables;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void buy( int i )
    {

        Selectable theselectable = FactorySelectables[i];

        

        Money.subMoney(theselectable.cost);


        

    }

    void leaveUI()
    {

    }
}
