using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** class that manages money of the player basically a wallet **/
public class Money : MonoBehaviour
{
    /**the amin value*/
    public float money; // debug public for now may change to priavte in future.
    

    // Start is called before the first frame update
    void Start()
    {
        LoadMoneyFromSave(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /**
     * this saves money to save
     */
    public void saveMoneyToSave() {
        //TODO
    }

    /**
     * it loads the money value  from the save to this money value 
     * 
     * */
    public void LoadMoneyFromSave() {
        //TODO
        money = 0;
    }

    /**
     * return the amount of money
     */
    public float getMoney()
    {
        return money;
    }

    /**
     * add money to the money
     * retruns money 
     */
    public float addMoney(float moneyadded)
    {
        money = moneyadded;
        return money; 
    }
    /**
     * subractes money to the money
     * retruns money 
     */
    public float subMoney(float m)
    {
        money -= m;
        return money;
    }

}
