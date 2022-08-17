using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;//DoTweenを使用する記述

public class KukuModeMenuManager : MonoBehaviour
{
    public Button thisButton;
    // Start is called before the first frame update
    
    public void KukuHomeback(){
        SceneManager.LoadScene("Menu");
    }
}
