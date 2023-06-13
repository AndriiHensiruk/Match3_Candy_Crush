using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using AppsFlyerSDK;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;



public class AFScript : MonoBehaviour
{
        public Text _text;
        //AppsFlyer object - the only communication with AppsFlyer
        [SerializeField] private AppsFlyerObjectScript appsFlyerObj;
        private static AFScript _instance;
        private static Dictionary<string, object> ConvertionData { get => _instance.appsFlyerObj.ConversionData; }
  
    // Start is called before the first frame update
    void Start()
    {
        
        AppsFlyer.setIsDebug(true);

         _text.text = getAppsFlyerId();
         Debug.Log("AppsFlyerUID");
         string AppsFlyerUID = AppsFlyer.getAppsFlyerId();
         Debug.Log(AppsFlyerUID);
        // These fields are set from the editor so do not modify!
        //******************************//
        AppsFlyer.setIsDebug(true);
 AppsFlyer.initSDK("devkey", "appID", this);
        //******************************/
 
        AppsFlyer.startSDK();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public string getAppsFlyerId()
    {
        string AppsFlyerUID = AppsFlyer.getAppsFlyerId();
        return AppsFlyerUID;
    } 
   

}
