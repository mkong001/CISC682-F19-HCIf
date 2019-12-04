using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class S1toS2 : MonoBehaviour
{
    public Button button;
    //private GameObject codeEnvPanel;
    private GameObject stageOnePanel;
    private GameObject stageTwoPanel;

    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.interactable = true;
        btn.onClick.AddListener(NextScene);
        //codeEnvPanel = GameObject.Find("CodeEnvPanel");
        stageOnePanel = GameObject.Find("StageOnePanel");
        stageTwoPanel = GameObject.Find("StageTwoPanel");
        stageTwoPanel.SetActive(false);
    }

    public void NextScene()
    {
        SceneManager.LoadScene("stageTwo");
        stageTwoPanel.gameObject.SetActive(true);
        stageOnePanel.gameObject.SetActive(false);

    }
}
