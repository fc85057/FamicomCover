using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private static GameManager instance;

    GameObject character;
    public int sanity = 100;

    // Start is called before the first frame update

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
        character = GameObject.Find("Character");
    }

    public void OnExtinguish(bool drain)
    {
        if (drain)
        {
            StartCoroutine("DrainSanity");
        }
        else if (!drain)
        {
            StopCoroutine("DrainSanity");
        }
    }

    IEnumerator DrainSanity()
    {
        while(true)
        {
            sanity -= 1;
            yield return new WaitForSeconds(.1f);
        }
        
    }


}
