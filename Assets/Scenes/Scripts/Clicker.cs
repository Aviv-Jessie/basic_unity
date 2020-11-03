using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    // Start is called before the first frame update
    private Renderer myRenderer;
    private void Start()
    {
        myRenderer = GetComponent<Renderer>(); // get the status the renderer of my component in the start of the game
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && myRenderer.enabled == true) // if we klick the mouse and the car renderer is enabled on (true) the renferer to off (false).
        {                                             
            myRenderer.enabled = false;// disables renderer of object                        
        }
        else if (Input.GetMouseButtonDown(0) && myRenderer.enabled == false) // if we klick the mouse and the car renderer is enabled off (false) the renferer to on (true).
        {
            myRenderer.enabled = true;// enables renderer of object
        }
    }

    

}
