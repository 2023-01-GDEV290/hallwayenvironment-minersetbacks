using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public WinDie winDieScript;

    private void OnTriggerEnter(Collider other)
    {
        winDieScript.WinLevel();
    }
}
