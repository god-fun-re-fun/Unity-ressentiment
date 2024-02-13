using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beltMove : MonoBehaviour
{
    float speed;
    Rigidbody rb;
    Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        //현재 실행중인 애니메이션의 속도를 가져옴
        speed = animator.GetCurrentAnimatorClipInfo(0)[0].clip.length / animator.GetCurrentAnimatorStateInfo(0).length * 1.1F;
    }

    void FixedUpdate()
    {
        // 현재 오브젝트의 전방 방향
        Vector3 forwardDirection = transform.right;

        Vector3 pos = rb.position;

        // 벨트의 이동 벡터 계산 (전방 방향 기준)
        rb.position += forwardDirection * speed * Time.fixedDeltaTime;

        // 이동 적용
        rb.MovePosition(pos);
    }
}
