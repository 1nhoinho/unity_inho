using UnityEngine;

public class Dsetoryevent : MonoBehaviour
{
    public float destroyTime = 3f;

    void Start()
    {
        Destroy(this.gameObject, destroyTime);  // this �� 3�� �ڿ� �ı��ϴ� ���

    }

    private void OnDestroy()
    {
        Debug.Log($"{this.gameObject.name}�� �ı��Ǿ����ϴ�.");
    }

}
