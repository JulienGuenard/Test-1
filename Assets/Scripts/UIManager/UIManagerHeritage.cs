using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManagerHeritage : MonoBehaviour
{
    [HideInInspector] public static UIManager ist;

    [HideInInspector] public TextMeshProUGUI uiTxt;
    [HideInInspector] public Image image;

    virtual public void Awake()
    {
        if (ist == null)ist = GetComponent<UIManager>();

         uiTxt            = GetComponent<TextMeshProUGUI>();
         image            = GetComponent<Image>();
    }
}
