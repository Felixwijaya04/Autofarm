using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableObj : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public GameObject TypeOfCmd; // Prefab to be cloned
    public RectTransform codeSlot;
    private GameObject duplicatedObj;
    private Canvas parentCanvas;

    private void Start()
    {
        parentCanvas = GetComponentInParent<Canvas>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
        duplicatedObj = Instantiate(TypeOfCmd, transform.position, Quaternion.identity, parentCanvas.transform);
        if (duplicatedObj != null)
        {
            duplicatedObj.SetActive(true);
            Debug.Log("Duplicated Object Position: " + duplicatedObj.transform.position);
        }
        else
        {
            Debug.LogError("Failed to instantiate duplicated object!");
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging");
        if (duplicatedObj != null)
        {
            RectTransformUtility.ScreenPointToLocalPointInRectangle(parentCanvas.transform as RectTransform, Input.mousePosition, parentCanvas.worldCamera, out Vector2 localPoint);
            duplicatedObj.GetComponent<RectTransform>().localPosition = localPoint;
            Debug.Log("Dragging Position: " + duplicatedObj.transform.localPosition);
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");
        if (RectTransformUtility.RectangleContainsScreenPoint(codeSlot, Input.mousePosition, null))
        {
            Debug.Log("Object is inside the target image area.");
        }
        else
        {
            Debug.Log("Object is outside the target image area.");
            Destroy(duplicatedObj);
        }
    }
}
