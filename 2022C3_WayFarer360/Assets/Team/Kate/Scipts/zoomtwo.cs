using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ZoomIn : MonoBehaviour
{
    public float tweenTime1;
    public TextMeshProUGUI textMesh1;
    public float tweenSize = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        Tween1();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void Tween1()
    {
        LeanTween.cancel(gameObject);

        transform.localScale = Vector3.one;
        LeanTween.scale(gameObject, Vector3.one * tweenSize, tweenTime1).setEasePunch();

        LeanTween.value(gameObject, 0, 1, tweenTime1)
            .setEasePunch();
        //      .setOnUpdate(setText);

    }
    // public void setText(float value)
    // {
    //   textMesh.text = value.ToString("F1");


}