using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public BoxCollider2D boxCollider;

    public Vector3 moveDelta;

    public Animator animator;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }


    private void FixedUpdate()
    {
        var x = Input.GetAxisRaw("Horizontal");
        var y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", moveDelta.x);
        animator.SetFloat("Vertical", moveDelta.y);
        animator.SetFloat("Speed", moveDelta.sqrMagnitude);

        // Reset moveDelta
        moveDelta = new Vector3(x, y, 0);

        //Makes Player move
        transform.Translate(moveDelta * Time.fixedDeltaTime);
    }

}
