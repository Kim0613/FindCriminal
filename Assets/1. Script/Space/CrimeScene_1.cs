using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrimeScene_1 : MonoBehaviour
{
    //맥주병 단서창
    public GameObject bearInfo;
    //확인 버튼
    public Button okButton;
  

    private void Awake()
    {
        okButton.onClick.AddListener(Ok);
    }
    //닫힘 버튼 누를시
    void Ok()
    {
        //일시정지 해제
        Time.timeScale = 1;
        //단서 정보창 닫기
        bearInfo.SetActive(false);

        print("정보창 닫기");
    }

    void OnMouseDown()
    {
        switch (transform.gameObject.name)
        {
            //소주병
            case "BearBottle":
                print("소주병");
                //정보창 등장
                bearInfo.SetActive(true);
                //일시정지
                Time.timeScale = 1;
                break;

        }


    }
}
