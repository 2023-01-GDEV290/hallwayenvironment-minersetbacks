using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public ParticleSystem dust_puff;

    // Start is called before the first frame update
    void Start()
    {
        dust_puff = GetComponent<ParticleSystem>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Breakable")
        {
            dust_puff.Play();
        }
    }
}
