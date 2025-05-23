using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float moveSpeed = 5f;
    void Start()
    {       // ������ġ = ���� ��ġ + (0, 0, 1)
        //this.transform.position = this.transform.position + Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position = this.transform.position + Vector3.forward * moveSpeed;

        // Input System (Old - Legend)
        // �Է°��� ���� ��ӵ� �ý���

        //// �ε巴�� �����ϴ� ��
        //float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");

        // �� �������� ��
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(h, 0, v);

        Vector3 normalDir = dir.normalized; // ����ȭ ���� (0~1)

        Debug.Log($"���� �Է� : {normalDir}");

        transform.position += normalDir * moveSpeed * Time.deltaTime;
               //�ٶ󺸴� ���  (0, 0, 0)  + (1, 0, 1)
        transform.LookAt(transform.position + normalDir);

        //if (Input.GetKey(KeyCode.W))  // ������ ���� ���
        //{
        //    transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.S))   // �ڷ� ���� ���
        //{
        //    transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.A))   // �������� ���� ���
        //{
        //    transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.D))   // ���������� ���� ���
        //{
        //    transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        //}




    }
}
