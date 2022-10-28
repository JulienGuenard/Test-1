using UnityEngine;

public class ColorManagerHeritage : MonoBehaviour
{
    [HideInInspector] public static ColorManager ist;

    virtual public void Awake()
    {
        if (ist == null)ist = GetComponent<ColorManager>();
    }
}
