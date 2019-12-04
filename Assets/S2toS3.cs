using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class S2toS3 : MonoBehaviour
{
    public Button button;
    //private GameObject codeEnvPanel;
    private GameObject stageTwoPanel;
    private GameObject stageFourPanel;

    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.interactable = true;
        btn.onClick.AddListener(NextScene);
        //codeEnvPanel = GameObject.Find("CodeEnvPanel");
        stageTwoPanel = GameObject.Find("StageTwoPanel");
        stageFourPanel = GameObject.Find("stageFourPanel");
        stageFourPanel.SetActive(false);
    }

    public void NextScene()
    {
        SceneManager.LoadScene("stageThree");
        stageFourPanel.gameObject.SetActive(true);
        stageTwoPanel.gameObject.SetActive(false);

    }
}
