// using.XRT
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class KB_XRTerra_UIObjectDeactivate : MonoBehaviour, IPointerClickHandler

{
    [Header("GameObject to Set Inactive")]
    public GameObject objectToDeactivate;
    public GameObject objectToDeactivate2;
    public GameObject objectToDeactivate3;
    public GameObject objectToDeactivate4;
    public GameObject objectToDeactivate5;

    [Header("Tag for Object Trigger Interaction")]
    public string objectTag;

    [Header("Time to Deactivate Object")]
    public float seconds;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void ObjectToDeactivate(GameObject objectToDeactivate)
    {
        objectToDeactivate.SetActive(false);
    }

    IEnumerator ObjectToDeactivateWaitTime()
    {
        yield return new WaitForSecondsRealtime(seconds);
        ObjectToDeactivate(objectToDeactivate);
        ObjectToDeactivate(objectToDeactivate2);
        ObjectToDeactivate(objectToDeactivate3);
        ObjectToDeactivate(objectToDeactivate4);
        ObjectToDeactivate(objectToDeactivate5);


    }

    public void OnPointerClick(PointerEventData data)
    {
        StartCoroutine(ObjectToDeactivateWaitTime());
    }

}
