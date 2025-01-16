using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // �ǔ�����ڕW�i�L�����N�^�[�j
    public Vector3 offset; // �J�����ƃL�����N�^�[�̊Ԃ̃I�t�Z�b�g
    public float smoothSpeed = 0.125f; // �J�����̕��������x

    void LateUpdate()
    {
        // �L�����N�^�[�̈ʒu�ɃI�t�Z�b�g��������
        Vector3 desiredPosition = target.position + offset;

        // �X���[�Y�ɃJ�������ړ�������
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        // �J�������L�����N�^�[�̌����Ă��������ǔ�
        transform.rotation = Quaternion.LookRotation(target.forward, Vector3.up);
    }
}