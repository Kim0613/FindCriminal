using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickControl : MonoBehaviour
{
    //���콺�� Ű������ �Է��� �޾� ĳ���Ϳ��� ����� ������ ��ũ��Ʈ

    private Behavior behavior; //ĳ������ �ൿ ��ũ��Ʈ
    public Camera mainCamera; //���� ī�޶�
    private Vector3 targetPos; //ĳ������ �̵� Ÿ�� ��ġ

    void Start()
    {
        behavior = GetComponent<Behavior>();
    }

    void Update()
    {
        //���콺 �Է��� �޾� �� ��
        if (Input.GetMouseButtonUp(0))
        {
            //���콺�� ���� ��ġ�� ��ǥ ���� �����´�
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit, 1000f))
            {
                targetPos = hit.point;
            }
        }

        //ĳ���Ͱ� �����̰� �ִٸ�
        if (behavior.Run(targetPos))
        {
            //ȸ���� ���� �����ش�
            behavior.Turn(targetPos);
        }
        //else
        //{
        //    //ĳ���� �ִϸ��̼�(���� ����)
        //    // behavior.SetA
        //}
    }
}
