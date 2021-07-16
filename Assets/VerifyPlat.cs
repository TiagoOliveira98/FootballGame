using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerifyPlat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Application.platform == RuntimePlatform.OSXPlayer)
            Debug.Log("Running on the Windows Player");
        else
            Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)==true)
        {
            Application.Quit();
        }
    }
}
