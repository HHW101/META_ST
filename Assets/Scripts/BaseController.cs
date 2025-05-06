using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    // Start is called before the first frame update
    protected Rigidbody2D _rigidbody;
    [SerializeField] private SpriteRenderer characterRender;
    protected Vector2 moveDir = Vector2.zero;
    protected AnimaationHandler animationHandler;
    public Vector2 MoveDir { get { return moveDir; } }
    protected virtual void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        animationHandler = GetComponent<AnimaationHandler>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        Rotate(moveDir);
    }
    protected virtual void FixedUpdate()
    {
        Movement(moveDir);

    }
    private void Rotate(Vector2 dir)
    {
        
        bool isLeft = dir.x<0;
        if (dir.x!=0) 
        characterRender.flipX = isLeft;
    }
    protected virtual void Movement(Vector2 direction)
    {
        direction = direction * 5;
        _rigidbody.velocity = direction;
        animationHandler.Move(direction);
    }
   
}
