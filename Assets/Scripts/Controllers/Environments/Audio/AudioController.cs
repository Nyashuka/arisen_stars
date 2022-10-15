using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{

    [Header("Sound")]  
    [SerializeField] private AudioSource[] _audio;
    [SerializeField] private Slider _audioVolumeSlider;

    private void Start()
    {
        _audioVolumeSlider.onValueChanged.AddListener(delegate { ChangeAudioVolume(); });
        _audioVolumeSlider.value = PlayerPrefs.GetFloat("MusicVolume");
    }

    public void ChangeAudioVolume()
    {
        foreach (var audio in _audio)
        {
            audio.volume = _audioVolumeSlider.value;
        }

        PlayerPrefs.SetFloat("MusicVolume", _audioVolumeSlider.value);
    }  
}
