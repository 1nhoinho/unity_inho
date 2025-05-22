using UnityEngine;

public class Dsetoryevent : MonoBehaviour
{
    public float destroyTime = 3f;

    void Start()
    {
        Destroy(this.gameObject, destroyTime);  // this 를 3초 뒤에 파괴하는 기능

    }

    private void OnDestroy()
    {
        Debug.Log($"{this.gameObject.name}이 파괴되었습니다.");
    }

}
