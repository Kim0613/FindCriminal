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
            //���ֺ�
            case "BearBottle":
                print("���ֺ�");
                //����â ����
                bearInfo.SetActive(true);
                //�Ͻ�����
                Time.timeScale = 0;
                break;

        }


    }
}
