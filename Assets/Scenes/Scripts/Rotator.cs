using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField]
    float speed = 0.5f;
    private float smooth = 5.0f;
    private float tiltAroundZ = 0;
    
    void Update()
    {   
        //Change z axis.
        tiltAroundZ += speed;
        
        //convert vector3 to Quaternion.
        Quaternion target = Quaternion.Euler(0, 0, tiltAroundZ);

        //Slerp from current rotation to new rotation.
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
    }
}
