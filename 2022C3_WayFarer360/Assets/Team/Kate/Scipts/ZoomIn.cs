using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class zoomtwo : MonoBehaviour
{
    public float tweenTime;
    public TextMeshProUGUI textMesh; 

    // Start is called before the first frame update
    void Start()
    {
        //Tween();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


public void Tween()
{
        LeanTween.cancel(gameObject);

        transform.localScale = Vector3.one;
        LeanTween.scale(gameObject, Vector3.one * 12, tweenTime).setEasePunch();

        LeanTween.value(gameObject, 0, 1, tweenTime)
            .setEasePunch();
      //      .setOnUpdate(setText);

}
   // public void setText(float value)
   // {
     //   textMesh.text = value.ToString("F1");
   

}