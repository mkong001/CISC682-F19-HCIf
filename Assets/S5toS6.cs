using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class S5toS6 : MonoBehaviour
{
    public Button button;
    //private GameObject codeEnvPanel;
    private GameObject stageFivePanel;
    private GameObject stageSixPanel;

    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.interactable = true;
        btn.onClick.AddListener(NextScene);
        //codeEnvPanel = GameObject.Find("CodeEnvPanel");
        stageFivePanel = GameObject.Find("StageFivePanel");
        stageSixPanel = GameObject.Find("StageSixPanel");
        stageSixPanel.SetActive(false);
    }

    public void NextScene()
    {
        SceneManager.LoadScene("stageSix");
        stageSixPanel.gameObject.SetActive(true);
        stageFivePanel.gameObject.SetActive(false);

    }
}
