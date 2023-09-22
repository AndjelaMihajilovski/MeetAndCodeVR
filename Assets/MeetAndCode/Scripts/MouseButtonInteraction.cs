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
                if (hit.transform.GetComponent<XRSimpleInteractable>())
                {
                    SelectEnterEventArgs arg = new SelectEnterEventArgs();
                    hit.transform.GetComponent<XRSimpleInteractable>().selectEntered.Invoke(arg);
                }
            }
        }
    }
}
