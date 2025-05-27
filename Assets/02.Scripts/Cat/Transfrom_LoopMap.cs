using UnityEngine;

public class Transform_LoopMap : MonoBehaviour
{
    public float moveSpeed = 3f;

    // ��� �̹����� ���̰� 30 �̱� ������ x = 30f
    public Vector3 returnPos = new Vector3(30f, 1.5f, 0f);


    void Update()
    {
        // ��� �������� �̵��ϴ� ��� // fixedDeltaTime - �������� ��ŸŸ��
        transform.position += Vector3.left * moveSpeed * Time.fixedDeltaTime;
    
        if(transform.position.x <= -30f) // �̹��� �� ���� -30 ���� �۴ٸ�
        {
            transform.position = returnPos; // returnPos ������ �ʱ�ȭ
        }
    
    
    }

}
