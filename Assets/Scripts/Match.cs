using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Match : MonoBehaviour
{
    bool extinguished;
    Animator animator;
    SpriteMask spriteMask;

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        spriteMask = GetComponentInChildren<SpriteMask>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Extinguish();
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            LightMatch();
        }
            
    }

    void Extinguish()
    {
        extinguished = true;
        animator.SetBool("extinguished", extinguished);
        spriteMask.enabled = false;
        GameManager.Instance.OnExtinguish(extinguished);
    }

    void LightMatch()
    {
        extinguished = false;
        animator.SetBool("extinguished", extinguished);
        spriteMask.enabled = true;
        GameManager.Instance.OnExtinguish(extinguished);
    }
}
