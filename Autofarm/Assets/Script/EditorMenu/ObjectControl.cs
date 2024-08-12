using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectControl : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public RectTransform codeSlot;
    
    public void OnBeginDrag(PointerEventData eventData)
    {
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (RectTransformUtility.RectangleContainsScreenPoint(codeSlot, Input.mousePosition, null))
        {
            Debug.Log("Object is inside the target image area.");
        }
        else
        {
            Debug.Log("Object is outside the target image area.");
            Destroy(gameObject);
        }
    }
}
