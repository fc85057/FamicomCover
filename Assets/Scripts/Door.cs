using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : InteractableObject
{

    private void OnTriggerStay2D(Collider2D collision)
    {

        if ((collision.gameObject.tag == "Player") && Input.GetKeyDown(KeyCode.W))
        {
            StartCoroutine(DisplayText());
        }
    }

}
