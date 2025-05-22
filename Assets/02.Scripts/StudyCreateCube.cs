using UnityEditor;
using UnityEngine;

public class StudyCreateCube : MonoBehaviour
{
    public GameObject obj;

    public Mesh msh;
    public Material mat;
    void Start()
    {
        obj = GameObject.CreatePrimitive(PrimitiveType.Cube);

        CreateCube();
        CreateCube("Hallo World");
    }

    public void CreateCube(string name = "Cube") // 입력값이 없으면 기본값인 Cube로 적용 
    {
        obj = new GameObject(name);

        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = msh;

        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mat;

        obj.AddComponent<BoxCollider>();


    }
}
