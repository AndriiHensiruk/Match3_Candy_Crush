using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AppsFlyerSDK;
using UnityEngine.UI;

public class AFDataInicial : MonoBehaviour
{
    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        text = ToString().AppsFlyer.updateServerUninstallToken();
    }

   
//    public string getDeveloperToken()
//     {
//         string AppsFlyerToken = AppsFlyer.updateServerUninstallToken(string);
//         return AppsFlyerToken;
//     } 
}
