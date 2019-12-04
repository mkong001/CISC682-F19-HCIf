using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class S8toFace : MonoBehaviour
{
    public Button button;
    //private GameObject codeEnvPanel;
    private GameObject stageEightPanel;
    private GameObject augFace;

    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.interactable = true;
        btn.onClick.AddListener(NextScene);
        //codeEnvPanel = GameObject.Find("CodeEnvPanel");
        stageEightPanel = GameObject.Find("StageEightPanel");
        //augFace = GameObject.Find("AugmentedF")
        //stageEightPanel.SetActive(false);
    }

    public void NextScene()
    {
        SceneManager.LoadScene("AugmentedFaces");
        //stageEightPanel.gameObject.SetActive(true);
        stageEightPanel.gameObject.SetActive(false);

    }
}
