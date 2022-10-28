using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareManager : SquareManagerHeritage
{
	[HideInInspector] public List<GameObject> squareList;
	
    override public void Awake()
    {
        base.Awake();
    }

    void Update()
    {
        
    }
}
