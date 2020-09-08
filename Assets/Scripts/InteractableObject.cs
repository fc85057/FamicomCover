using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableObject : MonoBehaviour
{

    Text inGameText;
    Transform character;
    Collider2D coll;
    GameObject canvas;

    public string textToDisplay;

    protected void Start()
    {
        canvas = GameObject.Find("CanvasInGameText");
        inGameText = canvas.GetComponentInChildren<Text>();
        character = GameObject.Find("Character").transform;
        coll = GetComponent<Collider2D>();
    }

    protected IEnumerator DisplayText()
    {
        Vector2 textPosition = new Vector2(character.position.x + 2f, character.position.y + 5f);
        canvas.transform.position = textPosition;
        inGameText.text = textToDisplay;
        yield return new WaitForSeconds(2f);
        inGameText.text = string.Empty;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        if ((collision.gameObject.tag == "Player") && Input.GetKeyDown(KeyCode.W))
        {
            StartCoroutine(DisplayText());
        }
    }

}
