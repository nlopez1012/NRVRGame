using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroywallfour : MonoBehaviour
{
    public AudioSource BreakingWallone;


    void OnTriggerEnter(Collider other)
    {
        if (coinsettings.theScore == 2600)
        {
            BreakingWallone.Play();

            Destroy(gameObject);
        }

    }
}

