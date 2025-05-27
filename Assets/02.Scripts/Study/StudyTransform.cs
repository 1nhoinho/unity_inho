using UnityEngine;

public class StudyTransform : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 70f;
    

    void Update()
    {
        // 캐릭터 앞으로 이동 기능 (월드 방향 기준 앞으로 이동 
        //transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

        // 로컬 방향으로 이동하는 기능
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
       
        //float angle = transform.rotation.eulerAngles.y + rotateSpeed * Time.deltaTime;
        //float localX = transform.localEulerAngles.x;
        //float localZ = transform.localEulerAngles.z;

        // 로컬 방향으로 회전
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime); // Space.Self 생략

        // 월드 방향으로 회전
        //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);
        //transform.rotation = Quaternion.Euler(0f, transform.eulerAngles.y + rotateSpeed * Time.deltaTime, 0f);

        // 특정 위치의 주변을 회전 zero =  (0, 0, 0)
        transform.RotateAround(Vector3.zero, Vector3.up, rotateSpeed * Time.deltaTime);
        // Vector3.zero == new Vector3(0f, 0f, 0f)
    
    
    }
}
