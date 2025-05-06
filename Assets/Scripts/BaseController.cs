using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    // Start is called before the first frame update
    protected Rigidbody2D _rigidbody;
    [SerializeField] private SpriteRenderer characterRender;
    protected Vector2 moveDir = Vector2.zero;
    public Vector2 MoveDir { get { return moveDir; } }
    
    protected virtual void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        
    }
    protected virtual void FixedUpdate()
    {
        Movement(moveDir);

    }
    private void Rotate(Vector2 dir)
    {
        
    }
    protected virtual void Movement(Vector2 direction)
    {
        direction = direction * 5;
        _rigidbody.velocity = direction;
    }
    void move(Vector2 vec)
    {
        
    }
}
