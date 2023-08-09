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
    if (objectToActivate3 != null)
    {
        Debug.Log("object 3 is activated");
    }
    if (objectToActivate3 == null)
    {
        Debug.Log("object 3 is NOT activated");

    }
    ObjectToActivate(objectToActivate4);
    if (objectToActivate4 != null)
    {
        Debug.Log("object 4 is activated");
    }
    if (objectToActivate4 == null)
    {
        Debug.Log("object 4 is NOT activated");

    } 
}


    // objectToActivate2
    public void OnPointerClick(PointerEventData data)
    {
        StartCoroutine(ObjectToActivateWaitTime());
    }


}
