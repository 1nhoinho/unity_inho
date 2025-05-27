using UnityEngine;

public class StudyMaterial : MonoBehaviour
{
    public Material mat;

    public string hexCode;


    void Start()
    {
        //this.GetComponent<Material>() = mat; // Material을 바꾸는 방식 X

        //this.GetComponent<MeshRenderer>().material = mat; // MeshRenderer에 접근해서 바꾸는 방식

        //this.GetComponent<MeshRenderer>().sharedMaterial = mat; // MeshRenderer에 접근해서 바꾸는 방식

        //this.GetComponent<MeshRenderer>().material.color = Color.green; // 인스턴스 생성을 해 색을 바꾸는 방식

        //this.GetComponent<MeshRenderer>().sharedMaterial.color = Color.green; // 공유하고 있는 다른 같은 인스턴스 모두 같이 바꾸는 방식

        this.GetComponent<MeshRenderer>().material.color = new Color(20f/255f, 150f/255f, 100f/255f, 255f);   //인스턴스 생성을 해 색을 바꾸는 방식



    }

}
