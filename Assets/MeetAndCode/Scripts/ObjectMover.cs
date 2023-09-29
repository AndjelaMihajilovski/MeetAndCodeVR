using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    Vector3 mousePositionOffset;
    private Vector3 GetMouseWorldPosition()
    {
        var mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mouseScreenPos);
    }
    private void OnMouseDown()
    {
        mousePositionOffset = transform.position - GetMouseWorldPosition();
    }
    private void OnMouseDrag()
    {
        Vector3 dragTransform = GetMouseWorldPosition() + mousePositionOffset;
        transform.position = new Vector3(dragTransform.x, dragTransform.y, dragTransform.x);
    }
}
