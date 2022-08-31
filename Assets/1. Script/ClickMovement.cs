using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickMovement : MonoBehaviour
{
    private Camera _camera;
    private Animator anim;
    public float moveSpeed;

    //캐릭터 이동 판단 여부
    private bool isMove;
    //캐릭터가 이동해야할 목적지
    private Vector3 destination;

    

    private void Awake()
    {
        _camera = Camera.main;
        anim = GetComponentInChildren<Animator>();
    }

    void Start()
    {
        
    }


    void Update()
    {
        //마우스 클릭했을때
        //마우스 커서 위치를 찾기
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {

            //레이에 맞은 물체를 저장할 공간
            RaycastHit hit;
            //Screen 좌표계로 표시된 마우스 커서 위치 좌표를 viewpoint 좌표계, 즉 0 ~ 1 사이의 비율 좌표계로 변환
            //마우스 클릭 좌표를 hit 변수에 저장 
            if(Physics.Raycast(_camera.ScreenPointToRay(Input.mousePosition),out hit))
            {
                //조건 : 바닥을 클릭했을 때만 움직이도록  
                if(hit.collider.tag == "Floor")
                {
                    //클릭한 좌표를 목적지로 설정
                    SetDestination(hit.point);
                }


            }

        }

        Move();
    }

    private void SetDestination(Vector3 dest)
    {
        destination = dest;
        isMove = true;
        //걷는 애니메이션 전환
        anim.SetBool("isMove", true);
    }
    //캐릭터를 목적지까지 이동시키는 함수
    private void Move()
    {
        if (isMove)
        {
            var dir = destination - transform.position;
            //이동하는 방향으로 바라보게 하기
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
