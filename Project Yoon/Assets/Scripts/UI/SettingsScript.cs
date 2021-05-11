using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsScript : MonoBehaviour
{
    public AudioMixer musicMixer;
    public AudioMixer soundMixer;

    public void setVolume(float musicVolume)
    {
      musicMixer.SetFloat("MyVolume", musicVolume);
    }

    public void setSound(float soundVolume)
    {
      soundMixer.SetFloat("MySound", soundVolume);
    }
}
