using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class S7toS8 : MonoBehaviour
{
    public Button button;
    //private GameObject codeEnvPanel;
    private GameObject stageSevenPanel;
    private GameObject stageEightPanel;

    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.interactable = true;
        btn.onClick.AddListener(NextScene);
        //codeEnvPanel = GameObject.Find("CodeEnvPanel");
        stageSevenPanel = GameObject.Find("StageSevenPanel");
        stageEightPanel = GameObject.Find("StageEightPanel");
        stageEightPanel.SetActive(false);
    }

    public void NextScene()
    {
        SceneManager.LoadScene("stageEight");
        stageEightPanel.gameObject.SetActive(true);
        stageSevenPanel.gameObject.SetActive(false);

    }
}
