using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
//gradeImageを拡大縮小するDoTween設定0614

public class DoGradeImage : MonoBehaviour
{
    public Image gradeImage;
     public GameObject gameOverPanel;

     
    
    // Start is called before the first frame update
    void Start()
    {
      
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DoImageChange(){
         transform.DOScale(new Vector3(1.1f, 1.1f, 1f), 0.6f)
        .SetRelative()
        ;
    }
    


}
