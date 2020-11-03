using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [Tooltip("Please enter number between 0 and 1.57")]
    [SerializeField]
    float limit = 1.2f;
    private bool flag = true; // to help us swutch the swing to the other side 
    private float xStart; // to save where te objext starts on x 
    private float yStart; // to save where the object starts on y
    // Start is called before the first frame update
    void Start()
    {
        if(limit > 1.57 || limit < 0) // because we are using cos(x) the limit is between -1.57 and 1.57 
        {
            print("Please enter a number betwwen 0 and 1.57");
        }
        xStart = transform.position.x;// saves the start position x
        yStart = transform.position.y;// saves the start position y
    }

    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x - xStart; // takes the difference of the position x and where it starts 
        transform.position = new Vector3(transform.position.x, yStart + x*x, 0);// we used the the function x^2 to move the y 
        if (flag)
        {
            transform.position += new Vector3(Mathf.Cos(x) * Time.deltaTime, 0, 0); // move right using cos(x) * Time.deltaTime meters. 
            if(x > limit) // when reaching 1.57 we switch the desending if
            {
                flag = false;
            }
        }
        else
        {
            transform.position -= new Vector3(Mathf.Cos(x) * Time.deltaTime, 0, 0); // move left using cos(x) * Time.deltaTime meters.
            if(x < -limit) // when reaching -1.57 we switch the increasing if
            {
                flag = true;
            }
        }
    }
}
