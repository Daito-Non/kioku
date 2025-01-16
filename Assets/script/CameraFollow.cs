using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // 追尾する目標（キャラクター）
    public Vector3 offset; // カメラとキャラクターの間のオフセット
    public float smoothSpeed = 0.125f; // カメラの平滑化速度

    void LateUpdate()
    {
        // キャラクターの位置にオフセットを加える
        Vector3 desiredPosition = target.position + offset;

        // スムーズにカメラを移動させる
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        // カメラがキャラクターの向いている方向を追尾
        transform.rotation = Quaternion.LookRotation(target.forward, Vector3.up);
    }
}