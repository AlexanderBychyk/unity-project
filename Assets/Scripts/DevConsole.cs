using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevConsole : MonoBehaviour
{
    private int count = 0;
    private TMPro.TMP_Text logText;
    void Start()
    {
        logText = GameObject.Find("logText").GetComponent<TMPro.TMP_Text>();
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.BackQuote)){
            ShowLine();
        }
    }
    private void OnEnable() {
        Application.logMessageReceived += LogCallBack;
    }
    private void OnDisable() {
        Application.logMessageReceived -= LogCallBack;
    } 
    void LogCallBack(string logString, string stackTree, LogType type){
        logText.text = $"{logText.text} [{stackTree}]  {logString} \n"; 
    }
    void ShowLine(){
        count++;
        Debug.Log($"Pressed {count}");
        Cursor.visible = true;
    }
}
