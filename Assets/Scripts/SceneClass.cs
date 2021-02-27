using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneClass : MonoBehaviour
{
    public GameObject devCommandPanel;
    
    void Update() {
        if (Debug.isDebugBuild && Input.GetKeyDown(KeyCode.BackQuote)) {
            if (!GameObject.Find("devCommandPanel")){
                GameObject instance = Instantiate(devCommandPanel, new Vector3(0,0,0), Quaternion.identity);
                instance.name = devCommandPanel.name;
                instance.transform.SetParent(GameObject.Find("Canvas").transform, false);
            } else {
                Destroy(GameObject.Find("devCommandPanel"));
            }
        }
    }
}
