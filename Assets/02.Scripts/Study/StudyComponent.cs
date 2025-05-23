using UnityEngine; 


//접근제한자 class 클래스명 : 유니티의 요용한 기능이 들어있는 곳
public class StudyComponent : MonoBehaviour


{
    // 퍼블릭으로 만들었기 때문에 유니티에서 직접 적용 가능
    public GameObject obj; // 게임오브젝트를 가져오기

    public Transform objTf;

     public string changeName;
    private void Start()
    {   //  Cube 라는 오브젝트를 찾아서 할당하는 코드
        //obj = GameObject.Find("Cube");


        // Tag : 게임 오브젝트의 별명 Layer : 게임오브젝트의 소속
        obj = GameObject.FindGameObjectWithTag("Player");

        objTf = GameObject.FindGameObjectWithTag("Player").transform;

        // objTf 에서 기능을 끄려면 지금은 transfrom 상태이기 때문에 gameObject 상태로 변경해야한다.
        objTf.gameObject.SetActive(false); 

        // 게임오브젝트 이름 변경
        obj.name = changeName;

        //// 게임오브젝트의 이름 태그, 위치 회전 크기 정보
        //Debug.Log($"이름 : {obj.name}");
        //Debug.Log($"태그 : {obj.tag}");
        //Debug.Log($"위치 : {obj.transform.position}");
        //Debug.Log($"회전 : {obj.transform.rotation}");
        //Debug.Log($"크기 : {obj.transform.localScale}");

        //// MeshFilter 컴포넌트에 접근해서 mesh를 Log 메세지로 출력하는 기능
        //Debug.Log($"Mesh 데이터 : {obj.GetComponent<MeshFilter>().mesh}");
        //// MeshRenderer 컴포넌트에 접근해서 material을 Log 메세지로 출력하는 기능
        //Debug.Log($"Material 데이터 : {obj.GetComponent<MeshRenderer>().material}");
    
        // obj 의 컴포넌트 중 렌더러 기능 off
        obj.GetComponent<MeshRenderer>().enabled = true; 
        // 오브젝트 기능 off
        obj.SetActive(false);
    }
}
