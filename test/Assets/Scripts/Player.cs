using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public float MovementSpeed = 10f;

    [SerializeField] private LayerMask groundLayerMask;
    private Rigidbody2D rigidbody2d;
    private BoxCollider2D boxCollider2d;

    private void Awake()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        transform.Translate(Vector2.right * MovementSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            float jumpVelocity = 12;
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
        }
    }

    private bool IsGrounded()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.size, 0f, Vector2.down, .1f, groundLayerMask);
        return (raycastHit2d.collider != null);
    }

}
