using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Massive thanks to Professor Michael Klein for allowing me to
//Download a project of his for inspiration & understanding for a past project!
//Project's name: H'SUB DINNER
//Other Projects that used code: SSB Inspired Fighting Game

public class WinDie : MonoBehaviour
{
    //public GameObject WinText;
    //public GameObject LoseText;
    public float PauseTime = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        //SaveScript.TimeOut = false;
        //WinText.gameObject.SetActive(false);
        //LoseText.gameObject.SetActive(false);
        //StartCoroutine(WinSet());
    }

    IEnumerator WinSet()
    {
        yield return new WaitForSeconds(0.4f);

        //if (SaveScript.CurrentOxy >= 0.0f)
        {
            //SceneManager.LoadScene(0);
        }


        //if (SaveScript.CurrentOxy > 0.0f)
        {
            //WinText.gameObject.SetActive(true);
            //MyPlayer.Play();
            //SaveScript.YouWin++;
        }

        //else if (SaveScript.CurrentOxy == 0.0f)
        {
            //LoseText.gameObject.SetActive(true);
            //MyPlayer.Play();
            //SaveScript.YouDied++;
        }
    }
}