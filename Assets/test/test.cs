using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public float floatSpeed = 1.0f; // ���ٴϴ� �ӵ� ������ ���� ����
    public float floatAmount = 0.5f; // ���ٴϴ� ���� ������ ���� ����
    private Vector3 startPos; // �ʱ� ��ġ ������ ���� ����

    void Start()
    {
        // ��ü�� �ʱ� ��ġ�� ����
        startPos = transform.position;
    }

    void Update()
    {
        // ��ü�� ���ٴϰ� ����� ���� sin �Լ��� ����Ͽ� Y�࿡ ���� ��ġ�� ���
        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatAmount;

        // ���� Y�� ��ġ�� ��ü�� ��ġ�� ������Ʈ
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}