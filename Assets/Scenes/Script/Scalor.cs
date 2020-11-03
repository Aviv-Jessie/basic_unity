using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scalor : MonoBehaviour
{
    [SerializeField]
    float speed = 1; 
    [SerializeField]
    float BigLimit = 5;
    [SerializeField]
    float LittleLimit = 1;
    private bool flag = true; // will help us reverse when reaching the big and small limit
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (flag) 
        {
            transform.localScale += new Vector3(speed * Time.deltaTime, speed * Time.deltaTime, 0);// inlarge x, y of local scale of this object 
            if(transform.localScale.y > BigLimit) // if it reaches the limit of the largest size change flag to false to enter decrease if
            {
                flag = false;
            }
        }
        else
        {
            transform.localScale -= new Vector3(speed * Time.deltaTime, speed * Time.deltaTime, 0);// make x, y decrease of the local scale of this object
            if (transform.localScale.y < LittleLimit)// if we reach the limit of the smallest size change the object to true to enter increase if
            {
                flag = true;
            }

        }
    }
}
