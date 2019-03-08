using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class watermovemen : MonoBehaviour
{
    public float height;
    public float time;// the duration of each cycle of the animation 

    // Start is called before the first frame update
    void Start()
    {
        // this line of code moves the water up and down
        iTween.MoveBy(this.gameObject, iTween.Hash("y", height, "time", time, "looptype", "pingpong", "easetype", iTween.EaseType.easeInOutSine));
    }

    // Update is called once per frame
    void Update()
    {
    }
}
