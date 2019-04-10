using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroywallthree : MonoBehaviour
{
    public AudioSource BreakingWallone;


    void OnTriggerEnter(Collider other)
    {
        if (coinsettings.theScore == 1950)
        {
            BreakingWallone.Play();

            Destroy(gameObject);
        }

    }
}
