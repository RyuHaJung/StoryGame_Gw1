using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public float floatSpeed = 1.0f; // 떠다니는 속도 조절을 위한 변수
    public float floatAmount = 0.5f; // 떠다니는 간격 조절을 위한 변수
    private Vector3 startPos; // 초기 위치 저장을 위한 변수

    void Start()
    {
        // 물체의 초기 위치를 저장
        startPos = transform.position;
    }

    void Update()
    {
        // 물체를 떠다니게 만들기 위해 sin 함수를 사용하여 Y축에 대한 위치를 계산
        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatAmount;

        // 계산된 Y축 위치로 물체의 위치를 업데이트
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}