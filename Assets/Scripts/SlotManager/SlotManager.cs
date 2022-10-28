using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotManager : SlotManagerHeritage
{
	public List<Slot> slotList;
    List<Square> squareToPlaceList = new List<Square>();


    override public void Awake()
    {
        base.Awake();
    }

    void Start()
    {
        NewOrder();
    }

    void Update()
    {
        CheckDrawingOrder();
    }

    void NewOrder()
    {
        squareToPlaceList.AddRange(SquareManager.ist.squareList);

        foreach(Slot slot in slotList)
        {
            if (squareToPlaceList.Count == 0) return;

            slot.squareActual = squareToPlaceList[Random.Range(0, squareToPlaceList.Count)];
            squareToPlaceList.Remove(slot.squareActual);
            slot.squareActual.transform.position = slot.transform.position;
        }
    }

    void CheckDrawingOrder()
    {
        int iOffset = 0;
        for (int i = 0; i < slotList.Count; i++)
        {
            if (slotList[i].spriteR.sprite.name != i.ToString() + iOffset) return;
            if (i == 3) iOffset++;

            GameManager.ist.Victory();
        }
    }
}
