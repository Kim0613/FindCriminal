using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMovement : MonoBehaviour
{
    private Camera camera;
    private Animator anim;
    public float moveSpeed;

    //ĳ���� �̵� �Ǵ� ����
    private bool isMove;
    //ĳ���Ͱ� �̵��ؾ��� ������
    private Vector3 destination;

    int mask = (1 << 6); //6�� ���̾�; �ٴ�

    private void Awake()
    {
        camera = Camera.main;
        anim = GetComponentInChildren<Animator>();
    }

    void Start()
    {
        
    }


    void Update()
    {
        //���콺 Ŭ��������
        //���콺 Ŀ�� ��ġ�� ã��
        if (Input.GetMouseButtonDown(0))
        {

            //���̿� ���� ��ü�� ������ ����
            RaycastHit hit;
            //Screen ��ǥ��� ǥ�õ� ���콺 Ŀ�� ��ġ ��ǥ�� viewpoint ��ǥ��, �� 0 ~ 1 ������ ���� ��ǥ��� ��ȯ
            //���콺 Ŭ�� ��ǥ�� hit ������ ���� 
            if(Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition),out hit))
            {
                //�ٴڿ� ��������� �����̵��� ���� 

                //Ŭ���� ��ǥ�� �������� ����
                SetDestination(hit.point);
            }

        }

        Move();
    }

    private void SetDestination(Vector3 dest)
    {
        destination = dest;
        isMove = true;
        //�ȴ� �ִϸ��̼� ��ȯ
        anim.SetBool("isMove", true);
    }
    //ĳ���͸� ���������� �̵���Ű�� �Լ�
    private void Move()
    {
        if (isMove)
        {
            var dir = destination - transform.position;
            //�̵��ϴ� �������� �ٶ󺸰� �ϱ�
            anim.transform.forward = dir;
            transform.position += dir.normalized * Time.deltaTime * moveSpeed;
        }
        if(Vector3.Distance(transform.position,destination) <= 0.1f)
        {
            isMove = false;
            anim.SetBool("isMove", false);
        }
    }
}
