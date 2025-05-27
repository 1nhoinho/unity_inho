using UnityEngine;

public class Transform_LoopMap : MonoBehaviour
{
    public float moveSpeed = 3f;

    // 배경 이미지의 길이가 30 이기 때문에 x = 30f
    public Vector3 returnPos = new Vector3(30f, 1.5f, 0f);


    void Update()
    {
        // 배경 왼쪽으로 이동하는 기능 // fixedDeltaTime - 고정적인 델타타입
        transform.position += Vector3.left * moveSpeed * Time.fixedDeltaTime;
    
        if(transform.position.x <= -30f) // 이미지 축 값이 -30 보다 작다면
        {
            transform.position = returnPos; // returnPos 값으로 초기화
        }
    
    
    }

}
