using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float moveSpeed;
    void Start()
    {       // 현재위치 = 현재 위치 + (0, 0, 1)
        //this.transform.position = this.transform.position + Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position = this.transform.position + Vector3.forward * moveSpeed;

        // Input System (Old - Legend)
        // 입력값에 대한 약속된 시스템


        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);
        Debug.Log($"현재 입력 : {dir}");

        transform.position += dir * moveSpeed * Time.deltaTime;

        //if (Input.GetKey(KeyCode.W))  // 앞으로 가는 기능
        //{
        //    transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.S))   // 뒤로 가는 기능
        //{
        //    transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.A))   // 왼쪽으로 가는 기능
        //{
        //    transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.D))   // 오른쪽으로 가는 기능
        //{
        //    transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        //}




    }
}
