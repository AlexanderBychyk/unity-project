using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DevConsole : MonoBehaviour
{
    private TMP_InputField inputField;
    private TMP_Text logContent;
    
    void Start()
    {
        logContent = GameObject.Find("logContent").GetComponent<TMP_Text>();
        inputField = GameObject.Find("inputCommand").GetComponent<TMP_InputField>();
        inputField.onSubmit.AddListener(CommandSubmited);
    }
    void Update() {
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
    public void CommandSubmited(string text){
        if (text.Length > 0) {
            Debug.Log($"{text}");
        }
    }
}
