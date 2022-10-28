using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotHeritage : MonoBehaviour
{
    [HideInInspector] public Slot slot;
    [HideInInspector] public SlotInputs slotInputs;

    [HideInInspector] public SpriteRenderer spriteR;

    virtual public void Awake()
    {
        slot = GetComponent<Slot>();
        slotInputs = GetComponent<SlotInputs>();

        spriteR         = GetComponent<SpriteRenderer>();
    }
}
