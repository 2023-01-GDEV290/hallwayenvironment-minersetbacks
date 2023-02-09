using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WinDie : MonoBehaviour
{
    private bool gameEnded;
    public double O2BarValue;
    
    public void WinLevel()
    {
        //if (gameEnded && O2BarValue != 0.0)
        //{
            Debug.Log("You Win!");
            gameEnded = true;
        //}
    }

    //public void LoseLevel()
    //{
        //if (!gameEnded && O2BarValue == 0.0)
        //{
            //Debug.Log("You Die!");
            //gameEnded = true;
        //}
    //}
}