using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionButton : MonoBehaviour
{
    public Camera menuCamera;
    public Camera optionCamera;

    public void swapCamera()
    {
        menuCamera.enabled = false;
        optionCamera.enabled = true;
    }
}
