using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class StudyArray : MonoBehaviour


{
    // 
    int number1 = 1;
    private int number2 = 2;
    
    public int number3 = 3;
    
    // serialize --> ����ȭ  Deserialize --> ������ȭ
    [SerializeField]
    private int number4 = 4;
    [SerializeField]
    int number5 = 5;


    // �迭 ����
    public int[] arrayNumber = new int[5]{1 ,2 ,3 ,4 ,5 };
    // ����Ʈ ����
    public List<int> listNumber = new List<int>();
    void Start()
    {
        // ����Ʈ �� �߰�
        listNumber.Add(1);
        listNumber.Add(2);
        listNumber.Add(3);
        listNumber.Add(4);
        listNumber.Add(5);

        //Debug.Log($"Array�� ù��° �� : {arrayNumber[0]}");
        //Debug.Log($"Array�� ����° �� : {arrayNumber[2]}");
        //Debug.Log($"Array�� ������° �� : {arrayNumber[5]}");

        //Debug.Log($"List�� �ִ� ������ �� : {listNumber.Count}");
        //Debug.Log($"List�� �ִ� ������ ������ : {listNumber[listNumber.Count - 1]}");
    }


}
