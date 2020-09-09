using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private static GameManager instance;

    Character character;
    Match match;
    int health;
    int sanity;
    int lamp;

    public UIManager uiManager;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject go = new GameObject("GameManager");
                go.AddComponent<GameManager>();
            }
            return instance;
        }
    }

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        character = GameObject.Find("Character").GetComponent<Character>();
        match = GameObject.Find("Match").GetComponent<Match>();
        sanity = character.maxSanity;
        health = character.maxHealth;
        lamp = match.maxLight;

        StartCoroutine("DrainLight");
    }

    public void OnExtinguish(bool extinguished)
    {
        if (extinguished)
        {
            StartCoroutine("DrainSanity");
            StopCoroutine("DrainLight");
        }
        else if (!extinguished)
        {
            StopCoroutine("DrainSanity");
            StartCoroutine("DrainLight");
        }
    }

    IEnumerator DrainSanity()
    {
        while(true)
        {
            sanity -= 1;
            uiManager.SetSanity(sanity);
            yield return new WaitForSeconds(.25f);
        }
        
    }

    IEnumerator DrainLight()
    {
        while(true)
        {
            lamp -= 1;
            uiManager.SetLight(lamp);
            yield return new WaitForSeconds(2f);
        }
    }

    void GameOver()
    {

    }


}
