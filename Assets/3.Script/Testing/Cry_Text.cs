using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;
using UnityEngine.Localization.Settings;

public class Cry_Text : MonoBehaviour
{
    private bool isClick = false;
    [SerializeField] private Text cry;
    public void btn_click()
    {
        if (isClick)
            return;

        StartCoroutine(cry_TextActive_co());

    }
    IEnumerator cry_TextActive_co()
    {
        isClick = true;
        Locale current_locale = LocalizationSettings.SelectedLocale;
        cry.text = 
            LocalizationSettings.StringDatabase.GetLocalizedString("MyTable", "Cry", current_locale);
        yield return new WaitForSeconds(1f);
        cry.text = string.Empty;
       isClick = false;
    }

}
