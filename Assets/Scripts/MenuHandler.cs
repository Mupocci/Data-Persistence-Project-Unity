using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuHandler : MonoBehaviour
{
    private TMP_InputField playerNameText;
    public string playerName;
    public MenuManager menuManager;

    // Start is called before the first frame update
    void Start()
    {
        playerNameText = GameObject.Find("InputPlayer").GetComponent<TMP_InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        playerName = playerNameText.text.ToString();
        menuManager.playerName = playerName;
        SceneManager.LoadScene(1);
    }

}
