using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    public GameObject destroyedVersion;
    //private Animator hit;

    void onMouseDown()
    {
        Instantiate(destroyedVersion, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    //Code above is duplicated to provide ideal code outline for when an animation for the pickaxe swing is executed.
    //DO NOT uncomment code, unless we are ready to test it!
    //if(hit)
    //{
        //Instantiate(destroyedVersion, transform.position, transform.rotation);
        //Destroy(gameObject);
    //}
}