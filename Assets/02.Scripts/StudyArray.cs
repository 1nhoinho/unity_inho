using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class StudyArray : MonoBehaviour


{
    // 
    int number1 = 1;
    private int number2 = 2;
    
    public int number3 = 3;
    
    // serialize --> 직렬화  Deserialize --> 역직렬화
    [SerializeField]
    private int number4 = 4;
    [SerializeField]
    int number5 = 5;


    // 배열 생성
    public int[] arrayNumber = new int[5]{1 ,2 ,3 ,4 ,5 };
    // 리스트 생성
    public List<int> listNumber = new List<int>();
    void Start()
    {
        // 리스트 값 추가
        listNumber.Add(1);
        listNumber.Add(2);
        listNumber.Add(3);
        listNumber.Add(4);
        listNumber.Add(5);

        //Debug.Log($"Array의 첫번째 값 : {arrayNumber[0]}");
        //Debug.Log($"Array의 세번째 값 : {arrayNumber[2]}");
        //Debug.Log($"Array의 여섯번째 값 : {arrayNumber[5]}");

        //Debug.Log($"List에 있는 데이터 수 : {listNumber.Count}");
        //Debug.Log($"List에 있는 마지막 데이터 : {listNumber[listNumber.Count - 1]}");
    }


}
