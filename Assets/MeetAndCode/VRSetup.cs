//using Oculus.Interaction;
//using Oculus.Interaction.Input;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRSetup : MonoBehaviour
{
    [Header("Camera")]
    public Transform neckTracking;

    [Header("Controllers")]
    public Transform leftControllerTracking;
    public Transform rightControllerTracking;

    [Header("HandsTracking")]
    public Transform leftHandTracking;
    public Transform rightHandTracking;

    [Header("OVRHands")]
    //[SerializeField, Interface(typeof(IHand))]
    private GameObject _leftHand;
    //[SerializeField, Interface(typeof(IHand))]
    private GameObject _rightHand;

    [Header("If loader have hand tracking")]
    public bool handtrackingActive;

    public enum VRMode
    {
        SIMULATOR,
        OCULUS,
        OPENXR
    }

  

}
