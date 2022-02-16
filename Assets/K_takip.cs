using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class K_takip : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject targetObject;
    public Vector3 camera;
    public Vector3 targeted;
    private Vector3 velocity = Vector3.zero;


    public float smoothTime = 0.3f;


    void LateUpdate()
    {
        targeted = targetObject.transform.position + camera;
        transform.position = Vector3.SmoothDamp(transform.position, targeted, ref velocity, smoothTime);

    }
}
