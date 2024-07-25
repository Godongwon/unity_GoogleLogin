using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Selecter : MonoBehaviour
{
    private void Start()
    {
        //StartCoroutine(loaded_scene());
    }

    //IEnumerator LaodAdding()
    //{
    //    for (int i = 1; i < SceneManager.sceneCountInBuildSettings; i++)
    //    {
    //        SceneManager.LoadScene(i, LoadSceneMode.Additive);
    //    }
    //    yield return null;
    //}

    IEnumerator loaded_scene_co(int index)
    {
        yield return StartCoroutine(unload_Scene_co());
        yield return null;
        SceneManager.LoadScene(index, LoadSceneMode.Additive);
    }

    IEnumerator unload_Scene_co()
    {
        if(SceneManager.sceneCount>1)
        {
            for (int i = 1; i < SceneManager.sceneCount; i++)
            {
                SceneManager.UnloadSceneAsync(SceneManager.GetSceneAt(i));
            }
        }
        yield return null;

    }
    public void Scene_Load_adding_click(int index)
    {

        StartCoroutine(loaded_scene_co(index));
       
    }

}
