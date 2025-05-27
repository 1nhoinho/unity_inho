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
        // z축을 기준으로 회전하는 기능
        transform.Rotate(Vector3.forward * rotSpeed);

        // 마우스 왼쪽 버튼을 눌렀을 때 회전하는 기능
        if (Input.GetMouseButton(0))
        {
            rotSpeed = -10f;
        }
        // 스페이스바를 눌렀을 때 정지하는 기능
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isStop = true;
        }
        // 현재 속도에서 값만 큼 곱해서 속도를 낮추는 기능
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
