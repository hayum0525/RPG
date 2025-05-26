using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimaterController : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        if (animator == null)
        {
            Debug.LogError("Animator ������Ʈ�� ã�� ���߽��ϴ�!");
        }

    }
    public void SetWalk(bool isWalk)
    {
        Debug.Log("�ִϸ� ȣ��");
        animator.SetBool("isWalk", isWalk);

    }
}
