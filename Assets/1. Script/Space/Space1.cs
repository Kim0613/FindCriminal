using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Space1 : MonoBehaviour
{
    //범죄 살인 현장

    //public GameObject clue;
    //public GameObject tutorial;
    //public GameObject player;
    //float Dist;

    public GameObject bearInfo;

    void Start()
    {
        
    }

    void Update()
    {
        //플레이어와의 거리
        //Dist = Vector3.Distance(transform.position, player.transform.position);

        ////플레이어와의 거리가 10일때
        //if(Vector3.Distance(transform.position,player.transform.position) < 13)
        //{
        //    //튜토리얼 팝업창 등장
        //    tutorial.SetActive(true);
        //    //일시정지
        //    Time.timeScale = 0;
        //}

    }
    //private void LateUpdate()
    //{
    //            print("거리 : " + Dist);
    //}

    //마우스로 오브젝트를 클릭하고 떼는순간
    void OnMouseDown()
    {
        switch (transform.gameObject.name)
        {
            case "Space (1)":
                //범죄현장씬 전환
                SceneManager.LoadScene(3);
                break;
                //소주병
            case "BearBottle":
                print("소주병");
                //정보창 등장
                bearInfo.SetActive(true);
                //일시정지
                Time.timeScale = 0;
                break;

        }
        

    }
}
