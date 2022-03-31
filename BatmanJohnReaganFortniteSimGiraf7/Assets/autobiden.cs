using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autobiden : MonoBehaviour
{
    public int moneySecond;
    int itemAmount;

    public float autoPrice;
    float cooldownTimer = 1;
    float currentTime;
   
    clickerbutton sørenScript;


    // Start is called before the first frame update
    void Start()
    {
        sørenScript = FindObjectOfType<clickerbutton>();
    }

    // Update is called once per frame lolololololololol
    void Update()
    {
        currentTime -= Time.deltaTime;
        if (currentTime <= 0)
        {
            currentTime = cooldownTimer;
            sørenScript.moneyAddition(moneySecond * itemAmount);
        } 
        
    }
    public void Karl()
    {
   
    }
    public void Svend()
    {
        if (sørenScript.amountOfMoney >= autoPrice)
        {
            sørenScript.amountOfMoney -= autoPrice;
            itemAmount += 1;
        }
       
    }
}
