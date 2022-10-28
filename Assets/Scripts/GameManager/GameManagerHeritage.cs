using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerHeritage : MonoBehaviour
{
    [HideInInspector] public static GameManager ist;
    [HideInInspector] public GameManagerInputs gameM_inputs;
    [HideInInspector] public GameManagerTimer gameM_timer;

    virtual public void Awake()
    {
        if (ist == null)ist = GetComponent<GameManager>();

        gameM_inputs        = GetComponent<GameManagerInputs>();
        gameM_timer         = GetComponent<GameManagerTimer>();
    }
}
