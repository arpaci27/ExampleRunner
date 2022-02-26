using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowController : MonoBehaviour
{
    public Vector3 offset;
    public float followSpeed = 5f;
    public Transform target;
    

    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset, followSpeed * Time.deltaTime);
    }
}
