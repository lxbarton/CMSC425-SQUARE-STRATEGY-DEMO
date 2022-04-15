using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSelection : MonoBehaviour
{
    public static (Vector2, Unit) selected;

    void Start() {
        selected = (new Vector2(0,0), null);
    }

    public static void setSelected((Vector2, Unit) toSelect)
    {
        if (selected.Item2 != null)
            selected.Item2.moveScript.enabled = false;
        
        selected = toSelect;
        selected.Item2.moveScript.enabled = true;
    }

    public static (Vector2, Unit) getSelected() 
    {
        return selected;
    }
}