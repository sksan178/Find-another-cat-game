using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BackgroundSound : MonoBehaviour
{
    private static bool isPlay = false;     //�⺻���� ������� ����

    private void Awake()    //Start() �Լ��� ����Ǳ� ���� Awake() �Լ��� ���� �����
    {   
        //������� ������� ������ 
        if(!isPlay)
        {
            //������� ����ϰ� ���� Scene���� �Ѿ���� ���ŵ��� �ʵ��� ����
            DontDestroyOnLoad(this.gameObject);
            isPlay = true;
        }
        //������� ������̸�
        else
        {
            //������� ������� �����Ѵ�.
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
