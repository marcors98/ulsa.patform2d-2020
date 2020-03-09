using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Platform2DUtils.MemorySystem;

public class NewGame : MonoBehaviour
{
    [SerializeField]
    InputField fileName;
    [SerializeField]
    Button btnNewGame;

    void Awake()
    {
        btnNewGame.onClick.AddListener(Save);
    }

    void Save()
    {
        if(string.IsNullOrEmpty(fileName.text)) return;
        MemorySystem.SaveData(Gamemanager.instance.gameData, fileName.text);
        gameObject.SetActive(false);
    }
    
}
