using UnityEngine;
using UnityEngine.Audio;

public class VolumeControl : MonoBehaviour
{
    public AudioMixer mixer;

    public void SetMasterVolume(float sliderValue)
    {
        Debug.Log("Master Volume");
        mixer.SetFloat("Master", Mathf.Log10(sliderValue) * 20);
    }

    public void SetAudio1Volume(float sliderValue)
    {
        mixer.SetFloat("Music", Mathf.Log10(sliderValue) * 20);
    }

    public void SetAudio2Volume(float sliderValue)
    {
        mixer.SetFloat("Background", Mathf.Log10(sliderValue) * 20);
    }

    public void SetAudio3Volume(float sliderValue)
    {
        mixer.SetFloat("Shooting", Mathf.Log10(sliderValue) * 20);
    }
}