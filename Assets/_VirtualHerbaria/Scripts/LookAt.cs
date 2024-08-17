using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    private Transform target;
    
    // Start is called before the first frame update
    void Start()
    {
        target = Camera.main.transform;
    }

    void Update()
    {
        transform.LookAt(target, Vector3.up);

    }
}
