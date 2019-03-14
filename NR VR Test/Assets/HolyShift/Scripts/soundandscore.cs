using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class soundandscore : MonoBehaviour
{
    
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        coinsettings.theScore += 50;
      
        Destroy(gameObject);
    }
}
