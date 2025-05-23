// 특정 namespace 기능 사용 코드 using namespace
using UnityEngine;
/// <summary>
/// 유티니 에디터에 있는 Console View에 Log를 테스트하기 위한 클래스
/// </summary>
public class StudyLog : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 일반적인 로그
        Debug.Log("Start 함수 실행");
        // 경고 로그
        Debug.LogWarning("Start 함수 실행");
        // 에러 로그
        Debug.LogError("Start 함수 실행");

    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Update 함수 실행");
    }
}
