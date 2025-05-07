using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniCamera : MonoBehaviour
{
    Transform target;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<Player>().transform;
        offset = transform.position-target.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 pos= transform.position;
        pos.x=target.position.x+offset.x;
        transform.position=pos;
        
    }
}
