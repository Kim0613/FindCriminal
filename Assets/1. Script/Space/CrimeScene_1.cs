using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrimeScene_1 : MonoBehaviour
{

    public GameObject bearInfo;

    public Button okButton;
  

    private void Awake()
    {
        okButton.onClick.AddListener(Ok);
    }

    void Ok()
    {
        Time.timeScale = 1;

        bearInfo.SetActive(false);
    }

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
                //Time.timeScale = 0;
                break;

        }


    }
}
