using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    float movement;
    public float movementSpeed = 4f;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = transform.Find("CharacterGraphic").gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
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
