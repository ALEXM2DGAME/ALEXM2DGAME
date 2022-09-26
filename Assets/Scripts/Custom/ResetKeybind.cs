using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetKeybind : MonoBehaviour
{
    public KeyCode keybind = KeyCode.R;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keybind)) {
            SceneManager.LoadScene(0);
        }
    }
}
