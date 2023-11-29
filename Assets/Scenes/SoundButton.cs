using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    private static int count = 0;
    public AudioSource audioSource;
    public Button Sound_Off_On;
    public Text ButtonText;
    public Sprite ButtonImage1;
    public Sprite ButtonImage2;
    public Sprite ButtonImage3;

    // Start is called before the first frame update
    void Start()
    {
        //Sound_Off_On.onClick.AddListener(SoundButton_Click);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SoundButton_Click()
    {
        GameObject soundObject = GameObject.Find("Audio Source");       //Main 안의 GameObject 검색

        if (soundObject != null)
        {
            audioSource = soundObject.GetComponent<AudioSource>();
        }
        count++;
        if (count % 2 == 0)
        {
            audioSource.Play();
            Sound_Off_On.image.sprite = ButtonImage1;
            ButtonText.text = "사운드 끄기";
        }
        else
        {
            audioSource.Stop();
            Sound_Off_On.image.sprite = ButtonImage2;
            ButtonText.text = "사운드 켜기";
        }
    }
}
