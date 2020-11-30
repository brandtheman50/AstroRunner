using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class BGMVolumeSlider : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider slider;

    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("bgVol", 1f);
    }

    public void SetLevel()
    {
        float sliderValue = slider.value;
        mixer.SetFloat("bgVolume", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("bgVol", sliderValue);
    }
}