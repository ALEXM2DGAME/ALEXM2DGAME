using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpTracker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        gameObject.GetComponent<Text>().text = GameObject.Find("SillyKitten").GetComponent<Jump>().canJump ? "can jump" : "no jump";
    }
}
