using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSceneStart : MonoBehaviour
{
    AudioSource ClearMusic;
    // Start is called before the first frame update
    
    //Scene�� ���۵Ǹ�
    void Start()
    {   
        //AudioSource�� ������ ����Ѵ�.
        ClearMusic = GetComponent<AudioSource>();
        ClearMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
