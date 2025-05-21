using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    // 퍼블릭으로 만들었기 때문에 유니티에서 직접 적용 가능
    public GameObject obj; // 큐브 게임오브젝트를 가져오기

    string changeName;
    private void Start()
    {   //  Cube 라는 오브젝트를 찾아서 할당하는 코드
        obj = GameObject.Find("Cube");

        // 게임오브젝트 이름 변경
        obj.name = changeName;
    }
}
