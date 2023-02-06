using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour
{
    public light;
    public float MinTime;
    public float MaxTime;
    public float Timer;

    void Start()
    {
        Timer = Random.Range(MinTime, MaxTime);
    }


    void Update()
    {
        FlickerLight();

    }

    void FlickerLight()
    {
        if (Timer > 0)
            Timer -= Time.deltaTime;

        if (Timer < 0)
        {
            light.enabled = !light.enabled;
            Timer = Random.Range(MinTime, MaxTime);
        }
    }
}
