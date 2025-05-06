using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject go;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            go.SetActive(true);
            collision.GetComponent<PlayerController>().nowMode = PlayerController.ModeP.game;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            go.SetActive(false);
            collision.GetComponent<PlayerController>().nowMode = PlayerController.ModeP.game;
        }
    }
}
