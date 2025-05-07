using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BGLooper : MonoBehaviour
{ public int bGCount = 5;
    public int blockCount = 3;
    public Vector3 blockLastPos = Vector3.zero;
    // Start is called before the first frame update
    
    void Start()
    {
        Block[] blocks = GameObject.FindObjectsOfType<Block>();
        blockLastPos = blocks[0].transform.position;
        blockCount = blocks.Length;
        for (int i = 1; i < blockCount; i++) { 
        blockLastPos=blocks[i].SetRandomPlace(blockLastPos,blockCount);
        }

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("BackGround")){
            float widthBg = 7f;
            Vector3 pos = collision.transform.position;
            pos.x += widthBg*bGCount;
            collision.transform.position = pos;
            return;

        }
        Block block = collision.GetComponent<Block>();
        if (block)
        {
            blockLastPos = block.SetRandomPlace(blockLastPos, blockCount);
        }
    }
    // Update is called once per frame

}
