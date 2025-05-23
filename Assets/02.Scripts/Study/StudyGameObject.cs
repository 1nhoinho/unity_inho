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
        Destroy(destryObj , 3f); // �Ű� ������ �� ������Ʈ�� �ı�
    }
    public void CreateAmongus()
    {
        Debug.Log("�����Ǿ����ϴ�.");
        // Resources ���Ͽ� �ִ� ������Ʈ "Amongus" �� �ҷ�����
        GameObject prefab = Resources.Load<GameObject>("Amongus");
        GameObject obj = Instantiate(prefab, pos, rot); //GameObject�� �����ϴ� ���
                                   //����������, ��ġ, ȸ��
        obj.name = "���� ĳ����";

        Transform objTf = obj.transform;
        int count = objTf.childCount;

        Debug.Log($"ĳ������ �ڽ� ������Ʈ�� �� : {objTf.childCount}");

        Debug.Log($"ĳ������ ù��° �ڽ� ������Ʈ�� �̸� : {objTf.GetChild(0).name}");

        Debug.Log($"ĳ������ ������ �ڽ� ������Ʈ�� �̸� : {objTf.GetChild(count - 1).name}");
    }
    void OnDestroy()
    {
        Debug.Log("�ı��Ǿ����ϴ�.");
    }

}
