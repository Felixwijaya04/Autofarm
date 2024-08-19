using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectControl : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public RectTransform[] codeSlot;
    Transform parentAfterDrag;
    private Compiler compiler;

    private void Start()
    {
        compiler = FindObjectOfType<Compiler>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
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
        foreach (var slot in codeSlot)
        {
            if (RectTransformUtility.RectangleContainsScreenPoint(slot, Input.mousePosition, null))
            {
                Debug.Log("Object is inside the target image area.");
                parentAfterDrag = slot;
                transform.SetParent(parentAfterDrag);
                insideSlot = true;

                BaseFunction function = GetComponent<BaseFunction>();
                if(function != null)
                {
                    compiler.AddFunction(function);
                }
                break;
            }
        }
        if (insideSlot == false)
        {
            Destroy(gameObject);
        }
        
    }
}
