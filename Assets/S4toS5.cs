using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class S4toS5 : MonoBehaviour
{
    public Button button;
    //private GameObject codeEnvPanel;
    private GameObject stageFourPanel;
    private GameObject stageFivePanel;

    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.interactable = true;
        btn.onClick.AddListener(NextScene);
        //codeEnvPanel = GameObject.Find("CodeEnvPanel");
        stageFourPanel = GameObject.Find("StageFourPanel");
        stageFivePanel = GameObject.Find("StageFivePanel");
        stageFivePanel.SetActive(false);
    }

    public void NextScene()
    {
        SceneManager.LoadScene("stageFive");
        stageFivePanel.gameObject.SetActive(true);
        stageFourPanel.gameObject.SetActive(false);

    }
}
