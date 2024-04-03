using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lighting : MonoBehaviour
{
    // Start is called before the first frame update
   
    public Transform target;

    public float smoothspeed = 0.125f;

    public Vector3 offset;

    void LateUpdate()
    {
        Debug.Log("it worked");
        Vector3 desiredPosition = transform.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
        transform.position = smoothedPosition;

        transform.LookAt(target);
    }
}
