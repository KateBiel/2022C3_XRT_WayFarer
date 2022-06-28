// using.XRT
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class KB_XRTerra_UIObjectActivate : MonoBehaviour, IPointerClickHandler
{
    [Header("GameObject to Set Active")]
    public GameObject objectToActivate;
    public GameObject objectToActivate2;
    public GameObject objectToActivate3;
    public GameObject objectToActivate4;

    [Header("Tag for Object Trigger Interaction")]
    public string objectTag;

    [Header("Time to Activate Object")]
    public float seconds;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void ObjectToActivate(GameObject objectToActivate)
    {
        objectToActivate.SetActive(true);
    }

    IEnumerator ObjectToActivateWaitTime()
    {
        yield return new WaitForSecondsRealtime(seconds);
        ObjectToActivate(objectToActivate);
        ObjectToActivate(objectToActivate2);
        ObjectToActivate(objectToActivate3);
        ObjectToActivate(objectToActivate4);
    }

    public void OnPointerClick(PointerEventData data)
    {
        StartCoroutine(ObjectToActivateWaitTime());
    }

}
