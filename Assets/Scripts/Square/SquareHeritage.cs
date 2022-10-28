using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareHeritage : MonoBehaviour
{
    [HideInInspector] public Square square;
    [HideInInspector] public SquareDragAndDrop squareDragAndDrop;

    [HideInInspector] public Rigidbody2D rb;
    [HideInInspector] public SpriteRenderer spriteR;

    virtual public void Awake()
    {
        square = GetComponent<Square>();
        squareDragAndDrop = GetComponent<SquareDragAndDrop>();

        rb              = GetComponent<Rigidbody2D>();
        spriteR         = GetComponent<SpriteRenderer>();
    }
}
