using System.Threading;
using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    public Transform targetTf;
    public Transform turretHead;

    public GameObject bulletPrefab; // 총알 프리팹
    public Transform firePos;

    public float timer;
    public float cooldownTime;
    void Start()
    {
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;
        turretHead = GameObject.Find("Head").transform;
        firePos = GameObject.Find("firePos").transform;
    }


    void Update()
    {
        turretHead.LookAt(targetTf);

        timer += Time.deltaTime;   // 타이머 기능
        if (timer >= cooldownTime)  // 현재 타이머가 쿨다운 시간보다 커졌다면
        {
            timer = 0f;
            // 생성하다. ( 생성 대상, 대상 위치, 대상 회전)
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
            //             GameObject  , Vector3  ,    Quaternion
            Debug.DrawRay(firePos.position, firePos.forward * 3f, Color.red, 1f);

        }   
        

    }
}
