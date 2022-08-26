using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space1 : MonoBehaviour
{
    //범죄 살인 현장
    void Start()
    {
        
    }

    void Update()
    {

    }
    //마우스로 오브젝트를 클릭하고 떼는순간
    void OnMouseDown()
    {
        if(transform.gameObject.name == "Space (1)")
        {
            print("클릭");
        }
    }
}
