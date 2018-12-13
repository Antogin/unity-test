using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour {

    private Color mouseOverColor = Color.blue;
    private Color originalColor = Color.yellow;

    private Vector3 screenPoint;
    private Vector3 offset;

    //private Renderer renderColor;

    void Start()
    {
        //renderColor = GetComponent<Renderer>();
    }

    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }

    /*void OnMouseEnter()
    {
        renderColor.material.color = mouseOverColor;
    }

    void OnMouseExit()
    {
        renderColor.material.color = originalColor;
    }*/
}
