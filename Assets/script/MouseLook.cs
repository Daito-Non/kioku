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
        // カーソルを画面中央に固定し、非表示にする
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // マウスの移動量を取得
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // 垂直方向の回転を制限する
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // カメラの回転を設定
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        // プレイヤーの体を水平に回転させる
        playerBody.Rotate(Vector3.up * mouseX);
    }
}