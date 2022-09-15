using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrimeScene_1 : MonoBehaviour
{

    public GameObject bearInfo;

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
                Time.timeScale = 0;
                break;

        }


    }
}
