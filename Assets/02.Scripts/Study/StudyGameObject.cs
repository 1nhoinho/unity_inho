using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;

    public GameObject destryObj;

    public Vector3 pos;

    public Quaternion rot;
    private void Awake()
    {
        CreateAmongus();  
    }

    void Start()
    {
        destryObj = GameObject.Find("Plane");
        Destroy(destryObj , 3f); // 매개 변수로 들어간 오브젝트를 파괴
    }
    public void CreateAmongus()
    {
        Debug.Log("생성되었습니다.");
        // Resources 파일에 있는 오브젝트 "Amongus" 를 불러오기
        GameObject prefab = Resources.Load<GameObject>("Amongus");
        GameObject obj = Instantiate(prefab, pos, rot); //GameObject를 생성하는 기능
                                   //생성데이터, 위치, 회전
        obj.name = "어몽어스 캐릭터";

        Transform objTf = obj.transform;
        int count = objTf.childCount;

        Debug.Log($"캐릭터의 자식 오브젝트의 수 : {objTf.childCount}");

        Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름 : {objTf.GetChild(0).name}");

        Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름 : {objTf.GetChild(count - 1).name}");
    }
    void OnDestroy()
    {
        Debug.Log("파괴되었습니다.");
    }

}
