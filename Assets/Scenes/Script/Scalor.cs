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
    private bool flag = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (flag)
        {
            transform.localScale += new Vector3(speed * Time.deltaTime, speed * Time.deltaTime, 0);
            if(transform.localScale.y > BigLimit)
            {
                flag = false;
            }
        }
        else
        {
            transform.localScale -= new Vector3(speed * Time.deltaTime, speed * Time.deltaTime, 0);
            if (transform.localScale.y < LittleLimit)
            {
                flag = true;
            }

        }
    }
}
