using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space1 : MonoBehaviour
{
    //���� ���� ����
    void Start()
    {
        
    }

    void Update()
    {

    }
    //���콺�� ������Ʈ�� Ŭ���ϰ� ���¼���
    void OnMouseDown()
    {
        if(transform.gameObject.name == "Space (1)")
        {
            print("Ŭ��");
        }
    }
}
