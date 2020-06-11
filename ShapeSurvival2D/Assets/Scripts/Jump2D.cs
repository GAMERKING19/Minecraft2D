using UnityEngine;

public class Jump2D : MonoBehaviour
{
    [SerializeField] private LayerMask platform;
    private Rigidbody2D rigidbody2d;
    private BoxCollider2D boxCollider2d;
   

    private void Awake()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            
            float jumpVelocity = 6f;
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
        }


    }

    private bool IsGrounded()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, .1f, platform);
        Debug.Log(raycastHit2d.collider);
        return raycastHit2d.collider != null;
    }


}