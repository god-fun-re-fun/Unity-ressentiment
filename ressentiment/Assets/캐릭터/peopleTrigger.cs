using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peopleTrigger : MonoBehaviour
{
    public Transform billboard;
    public float triggerDistance = 3f;

    private Animator peopleAnimator;

    void Start()
    {
        // ĳ������ Animator ������Ʈ ��������
        peopleAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        // ĳ���Ϳ� Ÿ�� ť�� ���� �Ÿ� ���
        float distance = Vector3.Distance(transform.position, billboard.position);

        // �Ÿ��� activationDistance���� ������ ù ��° �ִϸ��̼� ���
        if (distance < triggerDistance)
        {
            peopleAnimator.SetBool("isLookingBoard", true);
        }
        else
        {
            // �Ÿ��� activationDistance �̻��̸� �� ��° �ִϸ��̼� ���
            peopleAnimator.SetBool("isLookingBoard", false);
        }
    }
}
