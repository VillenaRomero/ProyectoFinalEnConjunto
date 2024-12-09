using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class ControlDeaudio : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider musicaSlider;
    void Awake()
    {
        musicaSlider.onValueChanged.AddListener(ControlMusicaVolumen);
    }

    // Update is called once per frame
    void Start()
    {
        Cargar();
    }
    private void ControlMusicaVolumen(float valor) {
        mixer.SetFloat("volumenMusica", Mathf.Log10(valor)*20);
        PlayerPrefs.SetFloat("volumenMusica", musicaSlider.value);
    }
    private void Cargar() {
        musicaSlider.value = PlayerPrefs.GetFloat("volumenMusica",0.75f);
        ControlMusicaVolumen(musicaSlider.value);
    }
}
