using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int number1 = 5; // ��� �Լ�
    public int number2 = 2;

    void Start()
    {
        int addResult = AddMethod();

        int minusResult = MinusMethod();

        Debug.Log(AddMethod());

        Debug.Log(MinusMethod());

        Debug.Log($"���� �� : {addResult} / �� �� : {minusResult}");
    }
 
    int AddMethod()
    {
        int result = number1 + number2;

        return result;
    }

    int MinusMethod()
    {
        int result = number1 - number2;

        return result;
    }


}
