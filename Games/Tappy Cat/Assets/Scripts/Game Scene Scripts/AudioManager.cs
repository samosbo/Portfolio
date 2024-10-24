using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Purpose: Controls Background Music in Game
public class AudioManager : MonoBehaviour
{
    //declare variables
    public Button muteButton;
    private bool isMuted = false;

    [Header("----- Audio Source -------")]
    [SerializeField] AudioSource musicSource;
    //[SerializeField] AudioClip SFXSource;

    [Header("----- Audio Clips -------")]
    public AudioClip Background;

    private void Start()
    {
        UpdateButtonText();
        muteButton.onClick.AddListener(ToggleMute);
        musicSource.clip = Background;
        musicSource.loop = true;
        musicSource.Play();
    }

    /// <summary>
    /// Controls mute and unmute for background music
    /// </summary>
    public void ToggleMute()
    {
        isMuted = !isMuted;
        AudioListener.volume = isMuted ? 0 : 1; // Mute/unmute audio
        UpdateButtonText();
    }

    /// <summary>
    /// Controls the button changing text from unmute to mute based off toggle Mute
    /// </summary>
    public void UpdateButtonText()
    {
        muteButton.GetComponentInChildren<Text>().text = isMuted ? "Unmute" : "Mute";
    }
}
