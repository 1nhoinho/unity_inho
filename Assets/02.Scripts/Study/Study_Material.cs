using UnityEngine;

public class StudyMaterial : MonoBehaviour
{
    public Material mat;

    public string hexCode;


    void Start()
    {
        //this.GetComponent<Material>() = mat; // Material�� �ٲٴ� ��� X

        //this.GetComponent<MeshRenderer>().material = mat; // MeshRenderer�� �����ؼ� �ٲٴ� ���

        //this.GetComponent<MeshRenderer>().sharedMaterial = mat; // MeshRenderer�� �����ؼ� �ٲٴ� ���

        //this.GetComponent<MeshRenderer>().material.color = Color.green; // �ν��Ͻ� ������ �� ���� �ٲٴ� ���

        //this.GetComponent<MeshRenderer>().sharedMaterial.color = Color.green; // �����ϰ� �ִ� �ٸ� ���� �ν��Ͻ� ��� ���� �ٲٴ� ���

        this.GetComponent<MeshRenderer>().material.color = new Color(20f/255f, 150f/255f, 100f/255f, 255f);   //�ν��Ͻ� ������ �� ���� �ٲٴ� ���



    }

}
