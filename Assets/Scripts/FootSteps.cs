using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour
{

    AudioSource animationSoundPlayer;



    private void Start()
    {
        animationSoundPlayer = GetComponent<AudioSource>();
    }

    private void Step()
    {
        animationSoundPlayer.Play();
    }

    

}
