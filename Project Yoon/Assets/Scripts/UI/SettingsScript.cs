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

    private float sen;
    [SerializeField] private PlayerControls thePlayer;

    private void Update()
    {
      //thePlayer.Player.Look.ReadValue<Vector2>() = sen;
    }

    public void setVolume(float musicVolume)
    {
      musicMixer.SetFloat("MyVolume",Mathf.Log10(musicVolume) * 20);
    }

    public void setSound(float soundVolume)
    {
      soundMixer.SetFloat("MySound", Mathf.Log10(soundVolume) * 20);
    }
    public void setSensitivity(float sensitivity)
    {
       //var action = new Input
    }
}
