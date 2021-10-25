using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaInter : MonoBehaviour
{
    public ControlCursor controlcursor;

    private void OnMouseEnter()
    {
        controlcursor.CambiarCursor("mano"); 
    }
    private void OnMouseExit()
    {
        controlcursor.CambiarCursor("normal");

    }

    private void OnTriggerEnter(Collider other)
    {
        controlcursor.CambiarCursor("mano");
    }
    private void OnTriggerExit(Collider other)
    {
        controlcursor.CambiarCursor("normal");
    }

}
