using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnMove(InputValue value)
    {
        Debug.Log("Ω√¿€"+value);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
