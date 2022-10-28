using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : ScoreManagerHeritage
{
    float score = 0;

    override public void Awake()
    {
        base.Awake();
    }

    public void AddScore(float value)
    {
        score += value;
    }
	
	public float GetScore()
    {
        return score;
    }
}
