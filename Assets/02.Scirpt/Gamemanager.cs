using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{

    private bool isAttack = false;
    



    void Playerstate()
    {

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
