using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    Vector3 camera;
    void Start()
    {
        camera = target.position;
        camera.z = -10;

    }

    // Update is called once per frame
    void Update()
    {
        camera = target.position;
        camera.z = -10;
        transform.position = camera;
    }
}
