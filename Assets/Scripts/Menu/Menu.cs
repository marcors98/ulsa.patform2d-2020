using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Platform2DUtils.MemorySystem;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField]
    Button btnNewGame;
    [SerializeField]
    Button btnLoadGame;
    [SerializeField]
    Button btnQuitGame;

    [SerializeField]
    GameObject panelNewGame;
    [SerializeField]
    GameObject panelOptions;

    void Awake()
    {
        btnNewGame.onClick.AddListener(NewGame);
        btnLoadGame.onClick.AddListener(LoadGame);
        btnQuitGame.onClick.AddListener(QuitGame);
    }

    void Start()
    {
        btnLoadGame.gameObject.SetActive(MemorySystem.DataExist);
    }

    public void LoadGame()
    {
        Gamemanager.instance.gameData = MemorySystem.LoadData();
        LoadScene();
    }

    public void NewGame()
    {
        panelOptions.SetActive(false);
        panelNewGame.SetActive(true);
        /*Gamemanager.instance.gameData = new GameData();
        MemorySystem.SaveData(Gamemanager.instance.gameData);
        LoadScene();*/
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    void LoadScene()
    {
        SceneManager.LoadScene(1);
        btnLoadGame.gameObject.SetActive(false);
        Gamemanager.instance.Score.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }
}
