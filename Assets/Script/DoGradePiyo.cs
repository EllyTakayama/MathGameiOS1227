using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
//gradePiyoを拡大縮小するDoTween設定

public class DoGradePiyo : MonoBehaviour
{
    [SerializeField] private Image gradePiyo;
    // Start is called before the first frame update
    void Start()
    {
        transform.DOPunchScale(new Vector3(1.5f, 1.5f,1f), 0.8f)
        .SetRelative()
        ;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
