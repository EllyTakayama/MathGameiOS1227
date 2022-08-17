
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;//DoTweenを使用する記述
//stydyPanel内の BackButtonでメニュー画面に戻るスクリプト


public class backButton : MonoBehaviour
{
    [SerializeField] private GameObject studyPanel;
   [SerializeField] private GameObject settingPanel;
      [SerializeField] private GameObject playExPanel;
    //public Button homeBackButton;
    public Button thisButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackButton()
    {
        SoundManager.instance.PlaySEButton();//SoundManagerからSEButtonを実行
        if(settingPanel == true){
            settingPanel.SetActive(false);
        }
        if(playExPanel == true){
            playExPanel.SetActive(false);
        }
        if(studyPanel == true){
            studyPanel.SetActive(false);
        }
            //Invoke("TableBackMove",0.5f);
     
    }

}