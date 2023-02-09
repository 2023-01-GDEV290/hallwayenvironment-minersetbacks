using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    //public GameObject destroyedVersion;
    public GameObject [] walls;
    private Animator Swing_Animation;
    public bool inRange = false;
    private int currentWall = 0;
    public bool cooldown = false;
    public AudioClip rockCrumble;
    public ParticleSystem particle;
    public bool hasTriggered = false;
    

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            inRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        inRange = false;
    }


    void OnMouseDown()
    {
        Invoke("DestroyWall", 1.5f);
        //Invoke("Cooling", 1f);
    }

    void Cooling()
    {
        cooldown = true;
        Invoke("CoolOff", 1f);
    }

    void CoolOff()
    {
        cooldown = false;
    }


    public void DestroyWall()
    {
        Debug.Log("MouseDown");
        if (inRange == true && cooldown == false)
        {
            Destroy(walls[currentWall]);
            //AudioSource rock = GetComponent<AudioSource>();
            //rock.PlayOneShot(rockCrumble);
            currentWall++;
            if (currentWall < 3)
            {
                walls[currentWall].SetActive(true);
            }
            Invoke("Cooling", 1f);

            if (hasTriggered == false)
            {
                hasTriggered = true;
                Instantiate(particle, transform.position * 0.6f, Quaternion.identity);
                AudioSource rock = GetComponent<AudioSource>();
                rock.PlayOneShot(rockCrumble);
                hasTriggered = false;
               
            }
        }
    }
}