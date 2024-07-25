using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class NativeShare_script : MonoBehaviour
{
    //https://www.kiweb.or.kr/?boot=game


    public void share_click()
    {
        
        new NativeShare().SetUrl("https://www.kiweb.or.kr/?boot=game").
            SetCallback((result, shareTarget) => Debug.Log("Share result: " + result + ", selected app: " + shareTarget))
        .Share();
    }

}
