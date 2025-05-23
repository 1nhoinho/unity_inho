using System.Threading;
using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    public Transform targetTf;
    public Transform turretHead;

    public GameObject bulletPrefab; // �Ѿ� ������
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

        timer += Time.deltaTime;   // Ÿ�̸� ���
        if (timer >= cooldownTime)  // ���� Ÿ�̸Ӱ� ��ٿ� �ð����� Ŀ���ٸ�
        {
            timer = 0f;
            // �����ϴ�. ( ���� ���, ��� ��ġ, ��� ȸ��)
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
            //             GameObject  , Vector3  ,    Quaternion
            Debug.DrawRay(firePos.position, firePos.forward * 3f, Color.red, 1f);

        }   
        

    }
}
