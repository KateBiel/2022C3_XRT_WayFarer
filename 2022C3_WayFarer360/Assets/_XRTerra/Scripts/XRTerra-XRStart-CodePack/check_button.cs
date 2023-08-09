using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class check_button : MonoBehaviour
{

    public Button drugButtonHere;

    // Start is called before the first frame update
    public void Start()
    {
        drugButtonHere.onClick.AddListener(drugButtonHereWork);
    }
    public void drugButtonHereWork()
    {
        Debug.Log("button Works");
    }

}
