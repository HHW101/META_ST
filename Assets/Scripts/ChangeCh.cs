using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCh : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Sprite> newSpite;
    private SpriteRenderer spriteRenderer;
    private PlayerController playerController;
    int index=0;
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerController= GetComponentInParent<PlayerController>();
    }
    void OnMenu()
    {
        index++;
        if(index>newSpite.Count) 
            index = 0;
        if (index == newSpite.Count)
        {
            playerController.moveSpeed = 5.0f;
            spriteRenderer.sprite = null;
            return;
        }
        spriteRenderer.sprite = newSpite[index];
        if (index == 1)
            playerController.moveSpeed = 10.0f;
        else
            playerController.moveSpeed = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
