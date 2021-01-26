using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setVolume : MonoBehaviour
{
    public AudioSource song;
    public Slider slider;

    public void SetVolume()
    {
        song.volume = slider.value;
    }
}
