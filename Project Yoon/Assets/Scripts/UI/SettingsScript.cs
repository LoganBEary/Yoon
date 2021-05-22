using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.InputSystem;

public class SettingsScript : MonoBehaviour
{
    public AudioMixer musicMixer;
    public AudioMixer soundMixer;

    [SerializeField] private InputAction mouse;
    [SerializeField] private PlayerControls thePlayer;

    private void Awake()
    {
        mouse = thePlayer.Player.Look;
    }


    public void setVolume(float musicVolume)
    {
      musicMixer.SetFloat("MyVolume", musicVolume);
    }

    public void setSound(float soundVolume)
    {
      soundMixer.SetFloat("MySound", soundVolume);
    }
    public void setSensitivity(float sensitivity)
    {
      //
    }
}
