using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BackgroundSound : MonoBehaviour
{
    private static bool isPlay = false;     //기본값이 재생되지 않음

    private void Awake()    //Start() 함수가 실행되기 전에 Awake() 함수가 먼저 실행됨
    {   
        //배경음이 재생되지 않으면 
        if(!isPlay)
        {
            //배경음을 재생하고 다음 Scene으로 넘어가더라도 제거되지 않도록 설정
            DontDestroyOnLoad(this.gameObject);
            isPlay = true;
        }
        //배경음이 재생중이면
        else
        {
            //재생중인 배경음을 삭제한다.
            Destroy(this.gameObject);
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
