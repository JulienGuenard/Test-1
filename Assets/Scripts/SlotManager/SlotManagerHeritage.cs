using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotManagerHeritage : MonoBehaviour
{
    [HideInInspector] public static SlotManager ist;

    virtual public void Awake()
    {
        if (ist == null)ist = GetComponent<SlotManager>();
    }
}
