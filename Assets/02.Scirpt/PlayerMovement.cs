using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float movespeed;

    private Animator animator;

   

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {

        playerMovement();
        

        
    }

    void playerMovement()
    {

        float hAxis = Input.GetAxisRaw("Horizontal");
        float vAxis = Input.GetAxisRaw("Vertical");

        Vector3 inputDir = new Vector3(hAxis, 0, vAxis).normalized;


        transform.position += inputDir * movespeed * Time.deltaTime;

        if (inputDir != Vector3.zero)
        {
            transform.LookAt(transform.position + inputDir);
            animator.SetBool("isWalk", true);  // 걷는 중
        }
        else
        {
            animator.SetBool("isWalk", false);
        }

    }
}
