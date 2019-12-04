using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class S3toS4 : MonoBehaviour
{
    public Button button;
    //private GameObject codeEnvPanel;
    private GameObject stageThreePanel;
    private GameObject stageFourPanel;

    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.interactable = true;
        btn.onClick.AddListener(NextScene);
        //codeEnvPanel = GameObject.Find("CodeEnvPanel");
        stageThreePanel = GameObject.Find("StageThreePanel");
        stageFourPanel = GameObject.Find("StageFourPanel");
        stageFourPanel.SetActive(false);
    }

    public void NextScene()
    {
        SceneManager.LoadScene("stageFour");
        stageFourPanel.gameObject.SetActive(true);
        stageThreePanel.gameObject.SetActive(false);

    }
}
