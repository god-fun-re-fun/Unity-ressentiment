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
        // ���� ������Ʈ�� ���� ����
        Vector3 forwardDirection = transform.right;

        Vector3 pos = rb.position;

        // ��Ʈ�� �̵� ���� ��� (���� ���� ����)
        rb.position += forwardDirection * speed * Time.fixedDeltaTime;

        // �̵� ����
        rb.MovePosition(pos);
    }
}
