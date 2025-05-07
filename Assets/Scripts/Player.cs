using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public float moveSpeed=5.0f;
    public float jumpSpeed = 3.0f;
    Rigidbody2D _rigidbody;
    Animator animator = null;
    bool isDead;
    bool isflap;
    public bool godMode;
    float setTime = 0.2f;
    float deatcCooldown = 1;
    bool isStart;
    int life = 3;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody2D>();
        BlockGameManager.Instance.Demaged(life);
    }
    private void OnJump()
    {
        if (isDead) return;
        if(!isflap) 
            isflap = true;
    }
    private bool end = false;
    private void Update()
    {
        if(end) return;
        setTime-= Time.deltaTime;
        if (setTime < 0)
            isStart = true;
        if (isDead)
        {
            if (deatcCooldown <= 0)
            {
                end = true;
                BlockGameManager.Instance.GameOver();
            }
            else
            {
                deatcCooldown -= Time.deltaTime;
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isDead)
            return;
        Vector3 a = _rigidbody.velocity;
        a.x = moveSpeed;
        if (isflap)
        {
            a.y += jumpSpeed;
            isflap = false;
        }
       
       
        _rigidbody.velocity = a;
        float angle = Mathf.Clamp((_rigidbody.velocity.y * 10f), -90, 90);
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isStart)
        {
            if(transform.position.y>0)
            transform.position -= new Vector3(0, 1.5f);
            else
                transform.position += new Vector3(0, 1.5f);

            return;
        }
        if (godMode)
            return;
        if (isDead) return;
        if (life > 1)
        {
            life--;
            setTime = 0.5f;
            isStart=false;
            BlockGameManager.Instance.Demaged(life);
           }
        else
        {
            isDead = true;
            animator.SetBool("isDead", true);
        }
        
    }
}
