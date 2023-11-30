using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSceneStart : MonoBehaviour
{
    AudioSource ClearMusic;
    // Start is called before the first frame update
    
    //Scene이 시작되면
    void Start()
    {   
        //AudioSource를 가져와 재생한다.
        ClearMusic = GetComponent<AudioSource>();
        ClearMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
