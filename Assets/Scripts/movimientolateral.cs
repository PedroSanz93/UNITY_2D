using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientolateral : MonoBehaviour
{
    public float speed;
    Rigidbody2D rigidBody;
    private float inputMovement;
    public bool isLookingRight = true;
    public float jumpForce;
    public bool isLookingLeft = true, isOnFloor=false;
    BoxCollider2D boxCollider;
    public LayerMask surfaceLayer;
    public bool isRunning;
    Animator animator;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        boxCollider= GetComponent<BoxCollider2D>();
        animator= GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        ProcessingMovement();
        ProcessingJump();
        isOnFloor = CheckingFloor();
    }
    bool CheckingFloor()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(
                                        boxCollider.bounds.center, //Origen de la caja
                                        new Vector2(boxCollider.bounds.size.x, boxCollider.bounds.size.y), //Tamaño
                                        0f, //Ángulo
                                        Vector2.down, //Direccion hacia la que va la caja
                                        0.2f, //Distancia a la que aparece la caja
                                        surfaceLayer//Layer mask
                                        );
        return raycastHit.collider != null; //Devuelvo un valor siempre que no sea nulo
    }
    void ProcessingMovement()
    {
        //Movement logic
        inputMovement = Input.GetAxis("Horizontal");
        isRunning = inputMovement!=0 ? true : false;
        animator.SetBool("isRunning",isRunning);
        rigidBody.velocity = new Vector2(inputMovement * speed, rigidBody.velocity.y);
        CharacterOrientation(inputMovement);
    }
    void CharacterOrientation(float inputMovement)
    {
        if ((isLookingRight && inputMovement < 0) || (!isLookingRight && inputMovement > 0))
        {
            isLookingRight = !isLookingRight;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }
    void ProcessingJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnFloor)
        {
            rigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}