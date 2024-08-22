using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectControl : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public RectTransform[] codeSlots;
    Transform parentAfterDrag;
    private Vector3 originalScale;

    public void OnBeginDrag(PointerEventData eventData)
    {
        originalScale = transform.localScale;
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        bool insideSlot = false;
        foreach (var slot in codeSlots)
        {
            if (RectTransformUtility.RectangleContainsScreenPoint(slot, Input.mousePosition, null))
            {
                Debug.Log("Object is inside the target image area.");
                parentAfterDrag = slot;
                transform.SetParent(parentAfterDrag,false);
                transform.localScale = originalScale;
                insideSlot = true;
                break;
            }
        }
        if (insideSlot == false)
        {
            Destroy(gameObject);
        }
    }
}
