using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    // Start is called before the first frame update
    public float highPosY = 2.5f;
    public float LowPosY = -2.0f;
    public float widthPadding = 3f;
    public Vector3 SetRandomPlace(Vector3 lastPos,int count)
    {
        Vector3 placePos = lastPos+new Vector3(widthPadding,0);
        placePos.y=Random.Range(LowPosY,highPosY);
        transform.position = placePos;

        return placePos;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        Player player = other.GetComponent<Player>();
        if (player != null)
           BlockGameManager.Instance.AddScore(1);
    }
}
