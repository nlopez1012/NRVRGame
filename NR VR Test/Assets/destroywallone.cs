﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



    public class destroywallone : MonoBehaviour
    {

    public AudioSource BreakingWallone;


            void OnTriggerEnter(Collider other)
            {
                if (coinsettings.theScore == 650)
                {
                      BreakingWallone.Play();

                    Destroy(gameObject);
                }

            }
        


    }












