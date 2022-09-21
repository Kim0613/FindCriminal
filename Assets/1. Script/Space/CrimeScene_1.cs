using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrimeScene_1 : MonoBehaviour
{
    //���ֺ� �ܼ�â
    public GameObject bearInfo;
    //Ȯ�� ��ư
    public Button okButton;
  

    private void Awake()
    {
        okButton.onClick.AddListener(Ok);
    }
    //���� ��ư ������
    void Ok()
    {
        //�Ͻ����� ����
        Time.timeScale = 1;
        //�ܼ� ����â �ݱ�
        bearInfo.SetActive(false);

        print("����â �ݱ�");
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
                Time.timeScale = 1;
                break;

        }


    }
}
