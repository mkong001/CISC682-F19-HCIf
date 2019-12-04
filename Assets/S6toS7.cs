using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class S6toS7 : MonoBehaviour
{
    public Button button;
    //private GameObject codeEnvPanel;
    private GameObject stageSixPanel;
    private GameObject stageSevenPanel;

    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.interactable = true;
        btn.onClick.AddListener(NextScene);
        //codeEnvPanel = GameObject.Find("CodeEnvPanel");
        stageSixPanel = GameObject.Find("StageSixPanel");
        stageSevenPanel = GameObject.Find("StageSevenPanel");
        stageSevenPanel.SetActive(false);
    }

    public void NextScene()
    {
        SceneManager.LoadScene("stageSeven");
        stageSevenPanel.gameObject.SetActive(true);
        stageSixPanel.gameObject.SetActive(false);

    }
}
