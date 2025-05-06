using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    Transform target;
    Vector3 offset;
    public Vector2 min;
    public Vector2 max;
    void Start()
    {
        target=FindObjectOfType<PlayerController>().transform; 
        if (target == null)
            return;
        offset=transform.position- target.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(target == null) return;
        Vector3 pos = offset+target.position;
        pos.x=Mathf.Clamp(pos.x, min.x, max.x);
        pos.y=Mathf.Clamp(pos.y, min.y, max.y);
        transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime * 5.0f);
    }
}
