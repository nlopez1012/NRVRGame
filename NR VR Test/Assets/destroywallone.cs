using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroywallone : MonoBehaviour
{

    
     

        void Update()
        {
            if (coinsettings.theScore == 650)
            {

                Destroy(gameObject);
            }

        }


       
        
  


}



