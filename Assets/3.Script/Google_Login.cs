using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using GooglePlayGames;

public class Google_Login : MonoBehaviour
{
    [SerializeField]private Text Logviewer_t;
    [SerializeField] private RawImage avatar_r;
    [SerializeField] private Text avatar_T;
    private void Start()
    {
        avatar_r.gameObject.SetActive(false);

        PlayGamesPlatform.DebugLogEnabled = true;
        PlayGamesPlatform.Activate();
        Logviewer_t.text=(PlayGamesPlatform.Instance.localUser.authenticated).ToString();
        //if(PlayGamesPlatform.Instance.localUser.authenticated)
        //{
        //    Logviewer_t.text = $"{Social.localUser.id}\n{Social.localUser.userName}";
            
        //}
    }
    private void Google_Login_Success()
    {
        avatar_r.gameObject.SetActive(true);
        Logviewer_t.text = $"{Social.localUser.id}\n{Social.localUser.userName}\n{Social.localUser.isFriend}";
        StartCoroutine(User_PictureLoad_co());
        transform.gameObject.GetComponent<Image>().enabled=false;
    }
    public void Google_login_click()
    {
        if(PlayGamesPlatform.Instance.localUser.authenticated==false)
        {
            Social.localUser.Authenticate
                (
                    (bool issuccess) =>
                    {
                        if(issuccess)
                        {
                            Google_Login_Success();
                        }
                        else
                        {
                            Logviewer_t.text = "Failed...";
                        }
                    }
                );
        }
    }

    private IEnumerator User_PictureLoad_co()
    {
        avatar_T.text = "Loading....";
        Texture2D pic = Social.localUser.image;
        while(pic==null)
        {
            pic = Social.localUser.image;
            yield return null;
        }

        avatar_T.gameObject.SetActive(false); ;
        avatar_r.gameObject.SetActive(true);
        avatar_r.texture = pic;
    }

    //public void Google_logout_Click()
    //{
    //    PlayGamesPlatform.Instance.
    //}

}
