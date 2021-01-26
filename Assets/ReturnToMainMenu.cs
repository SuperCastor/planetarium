using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToMainMenu : MonoBehaviour
{
    public Camera currentCamera;
    public Camera mainMenu;
    public void toMainMenu()
    {
        currentCamera.enabled = false;
        mainMenu.enabled = true;
    }
}
