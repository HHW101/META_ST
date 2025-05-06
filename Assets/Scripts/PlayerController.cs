using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : BaseController
{
    private Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        base.Start();
        camera = Camera.main;
    }
    private void OnMove(InputValue value)
    {
        moveDir = value.Get<Vector2>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
