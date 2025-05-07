using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : BaseController
{
    private Camera camera;

    public ModeP nowMode= ModeP.idle;
    public enum ModeP {idle,npc,game,board }

    // Start is called before the first frame update
    protected override void  Awake()
    {
        base.Awake();
        camera = Camera.main;
    }
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }
    protected void OnPush()
    {
        switch (nowMode) { 
            case ModeP.idle:
                break;
            case ModeP.board:
                UIManager.Instance.OpenBoard();
                break;
            case ModeP.npc:
                UIManager.Instance.Opentalk("talk Test");
                break;
            case ModeP.game:
                SceneManager.LoadScene("BlockScene");
                break;
        }
    }
    private void OnMove(InputValue value)
    {
        moveDir = value.Get<Vector2>();
    }
    // Update is called once per frame
    
}
