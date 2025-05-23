using UnityEngine; 


//���������� class Ŭ������ : ����Ƽ�� ����� ����� ����ִ� ��
public class StudyComponent : MonoBehaviour


{
    // �ۺ����� ������� ������ ����Ƽ���� ���� ���� ����
    public GameObject obj; // ���ӿ�����Ʈ�� ��������

    public Transform objTf;

     public string changeName;
    private void Start()
    {   //  Cube ��� ������Ʈ�� ã�Ƽ� �Ҵ��ϴ� �ڵ�
        //obj = GameObject.Find("Cube");


        // Tag : ���� ������Ʈ�� ���� Layer : ���ӿ�����Ʈ�� �Ҽ�
        obj = GameObject.FindGameObjectWithTag("Player");

        objTf = GameObject.FindGameObjectWithTag("Player").transform;

        // objTf ���� ����� ������ ������ transfrom �����̱� ������ gameObject ���·� �����ؾ��Ѵ�.
        objTf.gameObject.SetActive(false); 

        // ���ӿ�����Ʈ �̸� ����
        obj.name = changeName;

        //// ���ӿ�����Ʈ�� �̸� �±�, ��ġ ȸ�� ũ�� ����
        //Debug.Log($"�̸� : {obj.name}");
        //Debug.Log($"�±� : {obj.tag}");
        //Debug.Log($"��ġ : {obj.transform.position}");
        //Debug.Log($"ȸ�� : {obj.transform.rotation}");
        //Debug.Log($"ũ�� : {obj.transform.localScale}");

        //// MeshFilter ������Ʈ�� �����ؼ� mesh�� Log �޼����� ����ϴ� ���
        //Debug.Log($"Mesh ������ : {obj.GetComponent<MeshFilter>().mesh}");
        //// MeshRenderer ������Ʈ�� �����ؼ� material�� Log �޼����� ����ϴ� ���
        //Debug.Log($"Material ������ : {obj.GetComponent<MeshRenderer>().material}");
    
        // obj �� ������Ʈ �� ������ ��� off
        obj.GetComponent<MeshRenderer>().enabled = true; 
        // ������Ʈ ��� off
        obj.SetActive(false);
    }
}
