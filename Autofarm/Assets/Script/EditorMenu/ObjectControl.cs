using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectControl : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public RectTransform[] codeSlots;
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
        foreach (var slot in codeSlots)
        {
            if (RectTransformUtility.RectangleContainsScreenPoint(slot, Input.mousePosition, null))
            {
                Debug.Log("Object is inside the target image area.");
                parentAfterDrag = slot;
                transform.SetParent(parentAfterDrag);
                insideSlot = true;

                BaseFunction function = GetComponent<BaseFunction>();
                if (function != null)
                {
                    Debug.Log("From ObjControl.cs: Function added");
                    compiler.AddFunction(function);
                }
                break;
            }
        }
        if (insideSlot == false)
        {
            Destroy(gameObject);
        }
        /*bool insideSlot = false;
        for (int i = 0; i < codeSlots.Length; i++)
        {
            if (RectTransformUtility.RectangleContainsScreenPoint(codeSlots[i], Input.mousePosition, null))
            {
                Debug.Log("Object is inside the target image area.");
                parentAfterDrag = codeSlots[i];
                transform.SetParent(parentAfterDrag, false); // Set the parent without changing the local position
                insideSlot = true;

                // Add the function to the CodeExecutor at the correct position
                BaseFunction function = GetComponent<BaseFunction>();
                if (function != null)
                {
                    compiler.functions.Insert(i, function);
                }
                break;
            }
        }

        if (!insideSlot)
        {
            Debug.Log("Object is outside the target image areas.");
            Destroy(gameObject);
        }*/
    }
}
