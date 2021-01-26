using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateRotation : MonoBehaviour
{
    public GameObject planet;
    public Toggle mytoggle;

    public void changeValue()
    {
        GameObject.Find(planet.name).GetComponent<Rotation_orbit>().setRotation(mytoggle.isOn);
    }
}
