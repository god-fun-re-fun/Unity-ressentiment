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
        // 캐릭터의 Animator 컴포넌트 가져오기
        peopleAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        // 캐릭터와 타겟 큐브 간의 거리 계산
        float distance = Vector3.Distance(transform.position, billboard.position);

        // 거리가 activationDistance보다 가까우면 첫 번째 애니메이션 재생
        if (distance < triggerDistance)
        {
            peopleAnimator.SetBool("isLookingBoard", true);
        }
        else
        {
            // 거리가 activationDistance 이상이면 두 번째 애니메이션 재생
            peopleAnimator.SetBool("isLookingBoard", false);
        }
    }
}
