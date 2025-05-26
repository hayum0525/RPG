using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private bool isAttack = false;
    private bool isWalk = false;

    [SerializeField] private AnimaterController playerAnimator;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }
    public void IsWalk()
    {
        if (playerAnimator == null)
        {
            Debug.LogWarning("playerAnimator 연결 안 됨!");
            return;
        }
        isWalk = true;
        playerAnimator.SetWalk(isWalk);
    }


    private void isAttackMonster()
    {
        //몬스터를 공격
        isAttack = !isAttack;
    }
    
    private void isAttackPlayer()
    {
        //플레이어를 공격
        isAttack = !isAttack;
    }
}
