using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    // Start is called before the first frame update
    private Renderer myRenderer;
    private void Start()
    {
        myRenderer = GetComponent<Renderer>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && myRenderer.enabled == true)
        {
            myRenderer.enabled = false;
        }
        else if (Input.GetMouseButtonDown(0) && myRenderer.enabled == false)
        {
            myRenderer.enabled = true;
        }
    }
}
