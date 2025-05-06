using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimaationHandler : MonoBehaviour
{
    // Start is called before the first frame update
    protected Animator animator;
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }
    public void Move(Vector2 obj)
    {
        animator.SetBool("IsRun", obj.magnitude > .5f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
