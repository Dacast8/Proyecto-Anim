using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPausa : MonoBehaviour
{
    bool active;
    Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            active = !active;
            canvas.enabled = active;
        }
        
    }


}