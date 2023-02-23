using UnityEngine;

public class PetFollow : MonoBehaviour
{
    [Header("目標")]
    [SerializeField] Transform target;
    [Header("追蹤速度")]
    [SerializeField] float speed = 1.5f;

    private void LateUpdate()
    {
        Follow();
    }

    /// <summary>
    /// 跟隨系統
    /// </summary>
    private void Follow()
    {
        Vector3 posA = transform.position;      // 取得寵物的座標資訊
        Vector3 posB = target.position;         // 取得目標的座標資訊
        posA.z = posB.z - 5;

        Quaternion rotA = transform.rotation;
        Quaternion rotB = target.rotation;
        rotA.x = rotB.x;

        posA = Vector3.Lerp(posA, posB, 0.2f);  // 寵物座標 = 寵物與目標的插植座標
        rotA = Quaternion.Lerp(rotA, rotB, 0.2f);

        transform.position = posA;              // 寵物座標 = 插植後的新座標
        transform.rotation = rotA;
    }
}
