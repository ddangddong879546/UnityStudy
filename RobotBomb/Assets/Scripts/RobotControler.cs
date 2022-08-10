using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotControler : MonoBehaviour
{
    public float walkSpeed = 10.0f;
    public float jumpSpeed = 10.0f;

    Animator animator;
 
    Rigidbody2D robotRd;
    BoxCollider2D robotCollider;
    bool isJumping = false;
    

   

    void Start()
    {
        animator = GetComponent<Animator>();
        robotRd = GetComponent<Rigidbody2D>();
        robotCollider = GetComponent<BoxCollider2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x >= -8.0f)
        {
            animator.SetBool("isWalking", true);

            //�̵�
            transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);

            //������ȯ
            transform.localScale = new Vector2(-1.0f, 1.0f);
        }

        else if (Input.GetKey(KeyCode.RightArrow) && transform.position.x <= 8.0f)
        {
            animator.SetBool("isWalking", true);

            //�̵�
            transform.Translate(Vector2.right * walkSpeed * Time.deltaTime);
            
            //������ȯ
            transform.localScale = new Vector2(1.0f, 1.0f);
        }

        else
        {
            animator.SetBool("isWalking", false);
        }

        if (!isJumping)
        {
            if (Input.GetKeyDown(KeyCode.Space))//&&!anim.GetBool("isJumping")) // ������� ���� �˷��ֽ� ���
            {
                isJumping = true;
                animator.SetTrigger("jumpTrigger");
                robotRd.AddForce(transform.up * jumpSpeed, ForceMode2D.Impulse);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "GROUND")
        {
            isJumping = false;
        }
        
    }

    
}


