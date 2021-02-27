using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevConsole : MonoBehaviour
{
    private int count = 0;
    private TMPro.TMP_Text logContent;
    void Start()
    {
        logContent = GameObject.Find("logContent").GetComponent<TMPro.TMP_Text>();
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
        logContent.text = $"{logContent.text} {logString} \n"; 
    }
    void ShowLine(){
        count++;
        Debug.Log($"Pressed {count}");
        Cursor.visible = true;
    }
    public static void AcceptCommand(){
        // if (Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("Accepted!");
        // }
    }
}
