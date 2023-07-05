using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public string nomeCena;
    public GameObject menuPanel;
    // Start is called before the first frame update
    void Start()
    {
        //ativando painel do menu
        menuPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene(nomeCena);
    }
    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
