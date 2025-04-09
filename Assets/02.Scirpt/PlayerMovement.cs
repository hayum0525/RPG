using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float movespeed;

    private Animator anim;
    private bool isWalk = false;
    private bool isAttack = false;


    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {

        playerMovement();
        Animation();

        
    }

    void playerMovement()
    {
        float hAxis = Input.GetAxisRaw("Horizontal");
        float vAxis = Input.GetAxisRaw("Vertical");

        Vector3 inputDir = new Vector3(hAxis, 0, vAxis).normalized;


        transform.position += inputDir * movespeed * Time.deltaTime;

        transform.LookAt(transform.position + inputDir);
        
    }

    void Animation()
    {
        if(isWalk)
        {
            anim.SetBool("isWalk", true);
        }
        if(isAttack)
        {
            anim.SetBool("isAttack", true);
        }
        
    }
}
