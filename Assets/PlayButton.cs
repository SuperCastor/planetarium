using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    public Camera menuCamera;
    public Camera gameCamera;

    public void swapCamera()
    {
        menuCamera.enabled = false;
        gameCamera.enabled = true;
    }
}
