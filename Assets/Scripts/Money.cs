using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
/** class that manages money of the player basically a wallet **/
public class Money : MonoBehaviour
{
    /**the amin value*/
    public static float money; // debug public for now may change to priavte in future.
    public TextMeshProUGUI displayText;

    public float incomeRate; // rate of money

    public static Money Instance;

    private static int time;

    private void Awake()
    {
        if (Instance)
            Debug.LogError("More than one Money in the scene!");
        Instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        LoadMoneyFromSave(); 
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMoney();
        if(time < Time.timeSinceLevelLoad)
        {
            time++;
            money += incomeRate;
        }
    }


    public  string getMonenyInString() {
        return money + " clubs";
    }

    private void UpdateMoney()
    {
        displayText.text = getMonenyInString();
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
    public static float getMoney()
    {
        return money;
    }

    public static float setMoney(float m) {
        money = m;
        return money;
    }
    /**
     * add money to the money
     * retruns money 
     */
    public static float addMoney(float moneyadded)
    {
        money += moneyadded;
        return money; 
    }



    /**
     * subractes money to the money
     * retruns money 
     */
    public static  float subMoney(float m)
    {
        money -= m;
        return money;
    }

}
