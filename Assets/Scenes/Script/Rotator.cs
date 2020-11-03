using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Update is called once per frame
    float smooth = 5.0f;
    private float count = 0;
    void Update()
    {
        
        float tiltAroundZ = count;
        count++;

        
        Quaternion target = Quaternion.Euler(0, 0, tiltAroundZ);

        
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
    }
}
