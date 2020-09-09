using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Match : MonoBehaviour
{
    public int maxLight = 100;
    public int currentLight;
    public SpriteRenderer shadow;

    public bool extinguished;
    Animator animator;
    SpriteMask spriteMask;
    

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        spriteMask = GetComponentInChildren<SpriteMask>();
        currentLight = maxLight;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
            SetLamp();
        }
    
    }

    void SetLamp()
    {
        extinguished = !extinguished;
        animator.SetBool("extinguished", extinguished);
        spriteMask.enabled = !extinguished;
        shadow.enabled = !extinguished;
        GameManager.Instance.OnExtinguish(extinguished);
    }
}
