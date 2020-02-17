using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadGameButton : MonoBehaviour
{
    Button btnLoadGame;

    void Awake()
    {
        btnLoadGame = GetComponent<Button>();
        btnLoadGame.onClick.AddListener(LoadGame);
    }

    public void LoadGame()
    {
        Debug.Log("Game loaded");
        SceneManager.LoadScene(1);
        btnLoadGame.gameObject.SetActive(false);
        Gamemanager.instance.Score.gameObject.SetActive(true);
    }
}
