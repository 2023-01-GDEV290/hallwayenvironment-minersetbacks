using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour
{
      public bool isFLickering = false;
    public float timeDelay;

    
    void Update()
    {
        if (isFLickering == false)
        {
            StartCoroutine(FlickeringLightDelay());
        }
           
    }

    IEnumerator FlickeringLightDelay()
    {
        isFLickering = true;

        this.gameObject.GetComponent<Light>().enabled = false;
        timeDelay = UnityEngine.Random.Range(0.5f, 1.0f);
        yield return new WaitForSeconds(timeDelay);
        this.gameObject.GetComponent<Light>().enabled = true;
        timeDelay = UnityEngine.Random.Range(0.1f, 0.5f);
        yield return new WaitForSeconds(timeDelay);
        isFLickering = false;
    }
}
