using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRSwitcher : MonoBehaviour
{
    public static VRSwitcher instance;
    [Serializable]
    public enum VRMode
    {
        SIMULATOR,
        OPENXR
    }
    public VRMode currentVRMode;

    public GameObject simulator;
    public GameObject openXR;


    public void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        if (currentVRMode == VRMode.SIMULATOR)
        {
            simulator.SetActive(true);
            openXR.SetActive(false);
        }
        if (currentVRMode == VRMode.OPENXR)
        {
            simulator.SetActive(false);
            openXR.SetActive(true);
        }
    }

    public VRMode GetActiveVRMode()
    {
        return currentVRMode;
    }
}
