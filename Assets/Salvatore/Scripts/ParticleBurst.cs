using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleBurst : MonoBehaviour
{

    public ParticleSystem collisionParticleSystem;
    public bool once = true;

    private void OnTriggerEnter3D(Collider other)
    {
        if(other.gameObject.CompareTag("Player") && once)
        {
            var em = collisionParticleSystem.emission;
            var dur = collisionParticleSystem.main.duration;

            em.enabled = true;
            collisionParticleSystem.Play();

            once = false;
            Invoke(nameof(DestroyObj), dur);
        }
    }

    void DestroyObj()
    {
        Destroy(gameObject);
    }
}