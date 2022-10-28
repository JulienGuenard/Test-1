using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareManagerHeritage : MonoBehaviour
{
    [HideInInspector] public static SquareManager ist;

    virtual public void Awake()
    {
        if (ist == null)ist = GetComponent<SquareManager>();
    }
}
