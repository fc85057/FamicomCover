using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public int maxHealth = 100;
    public int maxSanity = 100;
    public int currentHealth;
    public int currentSanity;

    float movement;
    public float movementSpeed = 4f;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = transform.Find("CharacterGraphic").gameObject.GetComponent<Animator>();
        currentHealth = maxHealth;
        currentSanity = maxSanity;
    }


    private void FixedUpdate()
    {
        movement = Input.GetAxisRaw("Horizontal");
        if (movement != 0)
        {
            Move();
        }
        animator.SetFloat("movement", Mathf.Abs(movement));
    }

    void Move()
    {
        if (movement > 0)
        {
            transform.eulerAngles = new Vector2(0f, 0f);
        }
        else if (movement < 0)
        {
            transform.eulerAngles = new Vector2(0f, 180f);
        }

        transform.position += new Vector3(movement, 0f) * Time.deltaTime * movementSpeed;
    }


}
