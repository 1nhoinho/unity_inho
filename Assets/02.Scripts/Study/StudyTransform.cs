using UnityEngine;

public class StudyTransform : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 70f;
    

    void Update()
    {
        // ĳ���� ������ �̵� ��� (���� ���� ���� ������ �̵� 
        //transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

        // ���� �������� �̵��ϴ� ���
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
       
        //float angle = transform.rotation.eulerAngles.y + rotateSpeed * Time.deltaTime;
        //float localX = transform.localEulerAngles.x;
        //float localZ = transform.localEulerAngles.z;

        // ���� �������� ȸ��
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime); // Space.Self ����

        // ���� �������� ȸ��
        //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);
        //transform.rotation = Quaternion.Euler(0f, transform.eulerAngles.y + rotateSpeed * Time.deltaTime, 0f);

        // Ư�� ��ġ�� �ֺ��� ȸ�� zero =  (0, 0, 0)
        transform.RotateAround(Vector3.zero, Vector3.up, rotateSpeed * Time.deltaTime);
        // Vector3.zero == new Vector3(0f, 0f, 0f)
    
    
    }
}
