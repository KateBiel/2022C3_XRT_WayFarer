using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxChanger : MonoBehaviour
{
    [SerializeField] private Material SkyBoxMat;

    public void SetSkyBoxMat()
    {
        RenderSettings.skybox = SkyBoxMat;
    }
}
