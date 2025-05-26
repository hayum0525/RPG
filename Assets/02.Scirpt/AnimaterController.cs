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
            Debug.LogError("Animator 컴포넌트를 찾지 못했습니다!");
        }

    }
    public void SetWalk(bool isWalk)
    {
        Debug.Log("애니메 호출");
        animator.SetBool("isWalk", isWalk);

    }
}
