using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class O2Script : MonoBehaviour
{

    public float maxOxy = 180.0f;
    private float CurrentOxy;


    // Start is called before the first frame update
    void Start()
    {
        CurrentOxy = maxOxy;
    }

    // Update is called once per frame
    void Update()
    {
        CurrentOxy -= Time.deltaTime;

        if (CurrentOxy == 0.0f)
        {
            UnityEngine.Debug.Log("Youre Dead");
        }
    }
}



