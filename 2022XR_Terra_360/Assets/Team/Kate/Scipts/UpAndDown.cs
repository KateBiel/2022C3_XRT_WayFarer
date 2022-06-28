using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpAndDown : MonoBehaviour
{

    public AnimationCurve myCurve;
    public float distanceY = 0.0f ;
    public float speed = 0.0f;



    // yoy can do thssi
    void OnEnable()
    {
        LeanTween.moveY(gameObject, distanceY, speed).setLoopPingPong();
    }  
}

    
