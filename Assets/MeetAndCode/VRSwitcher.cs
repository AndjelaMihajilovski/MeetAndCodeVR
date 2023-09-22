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
    [HideInInspector]
    public VRSetup activeVRAvatarSetup;

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
            activeVRAvatarSetup = simulator.GetComponent<VRSetup>();
        }
        if (currentVRMode == VRMode.OPENXR)
        {
            simulator.SetActive(false);
            openXR.SetActive(true);
        }
    }

    public VRSetup GetActiveVRSetup()
    {
        return activeVRAvatarSetup;
    }

    public VRMode GetActiveVRMode()
    {
        return currentVRMode;
    }
}
