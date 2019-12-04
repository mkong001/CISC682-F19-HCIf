using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AAFtoBCS1 : MonoBehaviour
{
    public Button button;
    private GameObject welcomePanel;
    private GameObject stageOnePanel;
    private GameObject stageTwoPanel;
    private GameObject stageThreePanel;
    private GameObject stageFourPanel;
    private GameObject stageFivePanel;
    private GameObject stageSixPanel;
    private GameObject stageSevenPanel;
    private GameObject stageEightPanel;
    //private GameObject blockLibPanel;

    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(NextScene);
        welcomePanel = GameObject.Find("WelcomePanel");
        stageOnePanel = GameObject.Find("StageOnePanel");
        stageOnePanel.SetActive(false);
        stageTwoPanel = GameObject.Find("StageTwoPanel");
        stageTwoPanel.SetActive(false);
        stageThreePanel = GameObject.Find("StageThreePanel");
        stageThreePanel.SetActive(false);
        stageFourPanel = GameObject.Find("StageFourPanel");
        stageFourPanel.SetActive(false);
        stageFivePanel = GameObject.Find("StageFivePanel");
        stageFivePanel.SetActive(false);
        stageSixPanel = GameObject.Find("StageSixPanel");
        stageSixPanel.SetActive(false);
        stageSevenPanel = GameObject.Find("StageSevenPanel");
        stageSevenPanel.SetActive(false);
        stageEightPanel = GameObject.Find("StageEightPanel");
        stageEightPanel.SetActive(false);
        //codeEnvPanel = GameObject.Find("CodeEnvPanel");
        //codeEnvPanel.SetActive(false);
        //blockLibPanel = GameObject.Find("BlockLibPanel");
        //blockLibPanel.SetActive(false);
    }

    public void NextScene()
    {
        SceneManager.LoadScene("stageOne");
        welcomePanel.gameObject.SetActive(false);
        stageOnePanel.gameObject.SetActive(true);
        //stageOneDisplayPanel.gameObject.SetActive
        //codeEnvPanel.SetActive(true);
        //blockLibPanel.SetActive(true);

    }
}
