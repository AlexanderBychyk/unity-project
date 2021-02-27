using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Debug.isDebugBuild) {
            Debug.Log("This is a dev mode!");
            // gameObject.AddComponent<DevConsole>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
