using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BackgroundSound : MonoBehaviour
{
    private static bool isPlay = false;

    private void Awake()
    {
        if(!isPlay)
        {
            DontDestroyOnLoad(this.gameObject);
            isPlay = true;
        }
        else
        {
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
