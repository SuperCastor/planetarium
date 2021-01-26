using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteUnmute : MonoBehaviour
{
    public SpriteRenderer buttonSprite;
    public Sprite mute;
    public Sprite unmute;
    public AudioSource song;
    bool muted = false;

    public void MuteUnmuteFnc()
    {
        if (muted == false) {
            buttonSprite.sprite = mute;
            song.mute = true;
            muted = true;
            return;
        }

        if (muted == true) {
            buttonSprite.sprite = unmute;
            song.mute = false;
            muted = false;
            return;
        }
    }

}
