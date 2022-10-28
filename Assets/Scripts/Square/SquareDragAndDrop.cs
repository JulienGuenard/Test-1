using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareDragAndDrop : SquareHeritage
{
    bool isDragged = false;

    override public void Awake()
    {
        base.Awake();
    }

    private void Update()
    {
        OnHandOver();
    }

    void Drag()
    {
        if (!isDragged) return;

        spriteR.color = ColorManager.ist.colorSquareSelected;
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0, 0, 10);
    }

    void Undrag()
    {
        spriteR.color = ColorManager.ist.colorSquareNeutral;
    }

    void OnHandOver()
    {
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit;

        if (Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity))
        {
            hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
        }
        else return;

        Debug.Log("ray obj : " + hit.transform.gameObject);

            if (hit.transform.gameObject != this.gameObject)
            {
                Undrag();
                return;
            }

            isDragged = true;
            Drag();
        
    }
}
