using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    // �ۺ����� ������� ������ ����Ƽ���� ���� ���� ����
    public GameObject obj; // ť�� ���ӿ�����Ʈ�� ��������

    string changeName;
    private void Start()
    {   //  Cube ��� ������Ʈ�� ã�Ƽ� �Ҵ��ϴ� �ڵ�
        obj = GameObject.Find("Cube");

        // ���ӿ�����Ʈ �̸� ����
        obj.name = changeName;
    }
}
