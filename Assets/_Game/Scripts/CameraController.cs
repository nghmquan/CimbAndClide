using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [Header("Camera properties")]
    [SerializeField] private Camera cam;
    [SerializeField] private Vector3 position;

    [Header("Target")]
    [SerializeField] private GameObject target;

    void LateUpdate()
    {
        FollowTarget();
    }

    private void FollowTarget()
    {
        cam.transform.position = new Vector3(target.transform.position.x, target.transform.position.y, -10f);
    }
}
