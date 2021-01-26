using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public Camera menuCamera;
    public Camera gameCamera;
    // Start is called before the first frame update
    void Start()
    {
        gameCamera.enabled = false;
        menuCamera.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
