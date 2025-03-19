using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diChuyen : MonoBehaviour
{
    [SerializeField] float speed;
    private Animator animator;
    private Rigidbody2D rb;
    private float moveInput;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        UpdateAnimation();
        Attack();
    }
    private void Move()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput*speed,rb.velocity.y);
        if (moveInput > 0) transform.localScale = new Vector2(1, 1);
        if (moveInput < 0) transform.localScale = new Vector2(-1, 1);
        //animation
        //animator.SetFloat("diChuyen",Mathf.Abs(moveInput));
    }
    private void UpdateAnimation()
    {
        animator.SetFloat("dichuyen", Mathf.Abs(moveInput));
    }
    private void Attack()
    {
        animator.SetFloat("dichuyen", Mathf.Abs(moveInput));
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("TanCong");
        }
    }
}

