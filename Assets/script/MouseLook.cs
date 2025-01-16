using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;

    private float xRotation = 0f;

    void Start()
    {
        // �J�[�\������ʒ����ɌŒ肵�A��\���ɂ���
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // �}�E�X�̈ړ��ʂ��擾
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // ���������̉�]�𐧌�����
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // �J�����̉�]��ݒ�
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        // �v���C���[�̑̂𐅕��ɉ�]������
        playerBody.Rotate(Vector3.up * mouseX);
    }
}