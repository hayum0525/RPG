using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Monster : MonoBehaviour
{

    [SerializeField]
    private float radius = 2f; 

    private Transform target;
    [SerializeField]
    private Vector3 returnPosition;


    private void Start()
    {
        
    }

    void Update()
    {
        checkPlayer(); 

        if (target != null)
        { 
            MoveTowardsTarget();
        }
    }

    void checkPlayer()
    {
        // 몬스터의 앞쪽 위치에서 일정 범위(radius) 내에 있는 충돌체들을 검사
        Collider[] hits = Physics.OverlapSphere(transform.position + transform.forward, radius);

        foreach (Collider hit in hits)
        {
            if (hit.CompareTag("Player"))
            {
                target = hit.transform; // 플레이어가 감지되면 타겟으로 설정
                Debug.Log("타겟감지");
                break; // 하나만 찾으면 바로 멈춤
            }
        }

        // 만약 플레이어가 범위 내에 없다면 target을 null로 설정 (추적을 멈추기 위해)
        if (hits.Length == 0)
        {
            target = null;
            ReturnPlace();
        }
    }

    void MoveTowardsTarget()
    {  
            //플레이어 추적 
           Vector3 direction = (target.position - transform.position).normalized;
            // 방향으로 이동
           transform.position += direction * 1f * Time.deltaTime;     
    }

    void ReturnPlace()
    {
        //원래 위치로 되돌아 가기 
        //transform.position = Vector3.MoveTowards(transform.position, returnPosition, 3 * Time.deltaTime);
    }

    
    private void OnDrawGizmos()
    {
        //Drawcast
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position + transform.forward, radius);
    }

}
