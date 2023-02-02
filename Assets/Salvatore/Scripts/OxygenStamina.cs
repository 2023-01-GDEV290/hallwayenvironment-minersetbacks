using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenStamina : MonoBehaviour
{
    public Slider oxygenBar;

    private int maxStamina = 100;
    private int currentStamina;

    public static OxygenStamina instance;

    private void Awake()
    {
        instance = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        currentStamina = maxStamina;
        oxygenBar.maxValue = maxStamina;
        oxygenBar.value = maxStamina;
    }

    public void UseStamina(int amount)
    {
        if(currentStamina - amount >= 0)
        {
            currentStamina = amount;
            oxygenBar.value = currentStamina;
        }

        else
        {
            Debug.Log("You have 30 seconds left before you pass out.");
        }
    }
}