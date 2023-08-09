using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftAndRight : MonoBehaviour
{
    // Start is called before the first frame update
    public float distanceX = 0.0f;
    public float speedLR = 0.0f;



    // Start is called before the first frame update
    void OnEnable()
    {
        LeanTween.moveZ(gameObject, distanceX, speedLR).setLoopPingPong();
    }
}