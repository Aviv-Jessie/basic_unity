using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [Tooltip("Please enter number between 0 and 1.57")]
    [SerializeField]
    float limit = 1.2f;
    private bool flag = true;
    private float xStart;
    private float yStart;
    // Start is called before the first frame update
    void Start()
    {
        if(limit > 1.57 || limit < 0)
        {
            print("Please enter a number betwwen 0 and 1.57");
        }
        xStart = transform.position.x;
        yStart = transform.position.y;
        print(transform.position.y); 
    }

    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x - xStart;
        transform.position = new Vector3(transform.position.x, yStart + x*x, 0);
        if (flag)
        {
            transform.position += new Vector3(Mathf.Cos(x) * Time.deltaTime, 0, 0); // move right speed * Time.deltaTime meters.
            if(x > limit)
            {
                print("We arrived ");
                flag = false;
            }
        }
        else
        {
            transform.position -= new Vector3(Mathf.Cos(x) * Time.deltaTime, 0, 0); // move right speed * Time.deltaTime meters.
            if(x < -limit)
            {
                print("We decreased");
                flag = true;
            }
        }
    }
}
