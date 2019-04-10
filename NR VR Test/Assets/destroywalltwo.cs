using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroywalltwo : MonoBehaviour
{

    public AudioSource BreakingWallone;


    void OnTriggerEnter(Collider other)
    {
        if (coinsettings.theScore == 1300)
        {
            BreakingWallone.Play();

            Destroy(gameObject);
        }

    }
}




