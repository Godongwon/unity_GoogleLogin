using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class Localization_event : MonoBehaviour
{
    private bool isChanging=false;
    

    public void chage_Locale(int index)
    {
        if(isChanging)
        {
            Debug.Log("변경중입니다....");
            return;
        }
        StartCoroutine(Locale_chage_co(index));

    }
    IEnumerator Locale_chage_co(int index)
    {
        isChanging = true;

        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[index];

        isChanging = false;
    }
}
