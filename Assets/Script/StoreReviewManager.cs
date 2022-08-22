using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreReviewManager : MonoBehaviour
{
    void Start()
    {
        if(GameManager.singleton.SceneCount > 1){
            RequestReview();
        }
     
     Debug.Log("レビュー表示");
     /*
     if(GameManager.singleton.SceneCount==5||GameManager.singleton.SceneCount==30||
        GameManager.singleton.SceneCount==800||GameManager.singleton.SceneCount==150){
            StoreReviewManager.instance.RequestReview();
        }*/
    }

    public void RequestReview()
    {
#if UNITY_IOS && !UNITY_EDITOR
        UnityEngine.iOS.Device.RequestStoreReview();
#elif UNITY_ANDROID && !UNITY_EDITOR
        StartCoroutine(RequestReviewAndroid());
#else
        Debug.LogWarning("This platform is not support RequestReview.");
#endif
    }

#if UNITY_ANDROID
    private IEnumerator RequestReviewAndroid()
    {
        var reviewManager = new Google.Play.Review.ReviewManager();
        var requestFlowOperation = reviewManager.RequestReviewFlow();
        yield return requestFlowOperation;
        if (requestFlowOperation.Error != Google.Play.Review.ReviewErrorCode.NoError)
        {
            // Log error. For example, using requestFlowOperation.Error.ToString().
            yield break;
        }
        var playReviewInfo = requestFlowOperation.GetResult();
        var launchFlowOperation = reviewManager.LaunchReviewFlow(playReviewInfo);
        yield return launchFlowOperation;
        playReviewInfo = null; // Reset the object
        if (launchFlowOperation.Error != Google.Play.Review.ReviewErrorCode.NoError)
        {
            // Log error. For example, using requestFlowOperation.Error.ToString().
            yield break;
        }
    }
#endif
}
