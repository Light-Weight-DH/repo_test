using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{

    Rigidbody rb;
    Animator animator;


    GameObject obstacle;
    GameObject JumpObstacle;
    GameObject RotateObstacle;
    GameObject StartingPoint;

    public float speed = 5f;
    public float jumpPower = 5f;
    public float rotateSpeed = 10f;
    Vector3 movement;
    float Horizontal;
    float Vertical;
    bool isJump;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        //audioSource = GetComponent<AudioSource>(); 

        StartingPoint = GameObject.FindGameObjectWithTag("Starting_Point");
        JumpObstacle = GameObject.FindGameObjectWithTag("Jump_Obstacle");
        RotateObstacle = GameObject.FindGameObjectWithTag("Rotate_Obstacle");
    }
    
    //키 입력
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxisRaw("Vertical");

        if (Input.GetButtonDown("Jump"))
            isJump = true;

        AniUpdate();
    }
    
    // 물리적 처리
    void FixedUpdate()
    {
        //Input.GetAxis("Horizontal");
        Turn();
        Run();
        Jump();

        //거의 비슷하면 true
        //bool hasHorizontalInput = Mathf.Approximately(horizontal, 0f);
    }

    void AniUpdate()
    {
        if(Horizontal == 0 && Vertical==0){
            animator.SetBool("isFly", false);
        }
        else{
            animator.SetBool("isFly", true);
        }
    }
    
    void Run()
    {
        movement.Set(Horizontal, 0, Vertical);
        movement = movement.normalized * speed * Time.deltaTime;

        rb.MovePosition(transform.position + movement);
    }

    void Turn()
    {
        //MoveRotation을 쓸 수 도 있지만 부자연

        if (Horizontal == 0 && Vertical == 0)//움직임 없을때 회전 안하게
            return;
        //Slerp 함수는 목표 회전 값까지 회전 속도에 따라 천천히 회전시키는 함수
        Quaternion newRotation = Quaternion.LookRotation(movement);
        rb.rotation = Quaternion.Slerp(rb.rotation, newRotation, rotateSpeed * Time.deltaTime);
    }

    void Jump()
    {
        if (!isJump)
            return;
        //너무 부자연
        //rb.MovePosition(transform.position + Vector3.up);
        rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        isJump = false;
    }

    //-----Trigger---------------------------------

    
    
    

  

}
