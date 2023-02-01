using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScene : BaseScene
{
    protected override void Init()
    { 
        base.Init();

        SceneType = Define.Scene.Title;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Managers.Scene.LoadScene(Define.Scene.GameStage01);
        }
    }

    public override void Clear()
    {
        Debug.Log("TitleScene Clear!");
    }

    public void LoadSceneButton()
    {
        Managers.Scene.LoadScene(Define.Scene.GameStage01);
    }

}
