using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyobj : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        
    
        Destroy(gameObject);
    }
}
