using UnityEngine;

public class RouletteContral : MonoBehaviour
{
    public float rotSpeed;

    public bool isStop; // false

    private void Start()
    {
        rotSpeed = 0f;

    }

    void Update()
    {
        // z���� �������� ȸ���ϴ� ���
        transform.Rotate(Vector3.forward * rotSpeed);

        // ���콺 ���� ��ư�� ������ �� ȸ���ϴ� ���
        if (Input.GetMouseButton(0))
        {
            rotSpeed = -10f;
        }
        // �����̽��ٸ� ������ �� �����ϴ� ���
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isStop = true;
        }
        // ���� �ӵ����� ���� ŭ ���ؼ� �ӵ��� ���ߴ� ���
        if (isStop == true)
        {
        rotSpeed *= 0.98f;
            if (rotSpeed < 0.01f)
            {
                rotSpeed = 0f;
                isStop = false;
            }
        }
    }

}
