using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManagerHeritage : MonoBehaviour
{
    [HideInInspector] public static ScoreManager ist;

    virtual public void Awake()
    {
        if (ist == null)ist = GetComponent<ScoreManager>();
    }
}
