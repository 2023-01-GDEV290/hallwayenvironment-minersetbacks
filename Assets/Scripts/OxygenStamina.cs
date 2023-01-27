using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenStamina : MonoBehaviour
{
    public Slider oxygenStamina;

    private int maxStamina;
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
        oxygenStamina.maxValue = maxStamina;
        oxygenStamina.value = maxStamina;
    }

    public void UseStamina(int amount)
    {
        if(currentStamina - amount >= 0)
        {
            oxygenStamina.value = currentStamina;
        }

        else
        {
            Debug.Log("You have 30 seconds left before you pass out.");
        }
    }
}
