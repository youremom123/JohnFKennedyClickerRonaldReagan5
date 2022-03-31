using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class clickerbutton : MonoBehaviour
{
    public float amountOfMoney;
    public float addMoney;
    public Text moneyText;



    // asoink bob, oleg lugter

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = amountOfMoney.ToString("F0");
    }

    public void anders()
    {
        amountOfMoney += addMoney;
    }
    public void  moneyAddition(float moneyToAdd)
    {
        amountOfMoney += moneyToAdd;

    }
}
