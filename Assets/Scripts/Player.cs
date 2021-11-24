using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CircleCollider2D circleCollider;
    public Vector3 moveDelta;
    public Animator animator;
    public RaycastHit2D hit;

    private void Start()
    {
        circleCollider = GetComponent<CircleCollider2D>();
    }


    private void FixedUpdate()
    {
        var x = Input.GetAxisRaw("Horizontal");
        var y = Input.GetAxisRaw("Vertical");

        // Reset moveDelta
        moveDelta = new Vector3(x, y, 0);

        // Connects movement animation
        animator.SetFloat("Horizontal", moveDelta.x);
        animator.SetFloat("Vertical", moveDelta.y);
        animator.SetFloat("Speed", moveDelta.sqrMagnitude);

        //Makes Player move
        transform.Translate(moveDelta* Time.deltaTime);

        //// Make sure we can move vertically by casting a box ahead first, if box == null, we are able to move
        //hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(0, moveDelta.y), Mathf.Abs(moveDelta.y * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));
        //if(hit.collider == null)
        //{
        //    //Makes Player move
        //    transform.Translate(0, moveDelta.y * Time.deltaTime, 0);
        //}

        //// Make sure we can move horizontally by casting a box ahead first, if box == null, we are able to move
        //hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(0, moveDelta.x), Mathf.Abs(moveDelta.x * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));
        //if (hit.collider == null)
        //{
        //    //Makes Player move
        //    transform.Translate(moveDelta.x * Time.deltaTime, 0, 0);
        //}


    }

}
