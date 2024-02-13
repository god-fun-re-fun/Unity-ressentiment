using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beltMoveNoAnim : MonoBehaviour
{
    public float speed;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
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
