using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Although this script is named Player, DO NOT mistaken it for the Third-person Controller Script!
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            OxygenStamina.instance.UseStamina(10);
    }
}
