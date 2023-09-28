using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MouseButtonInteraction : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                //TODO: promeniti u XRGrabInteractable
                if (hit.transform.GetComponent<XRGrabInteractable>())
                {
                    SelectEnterEventArgs arg = new SelectEnterEventArgs();
                    hit.transform.GetComponent<XRGrabInteractable>().selectEntered.Invoke(arg);
                    Debug.Log("Mouse click");
                }
            }
        }
    }
}
