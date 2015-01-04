using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour 
{
	// Use this for initialization
	void Awake () 
    {
        DontDestroyOnLoad(gameObject);

        GlobalConfig.LoadConfig();
        XMLManager.LoadConfigs();

        GamePublic.Instance.Initialize();
        TimerManager.Instance.Initialize();

        ScreenControl.Instance.Initialize(GlobalConfig.DesignScreenWidth, GlobalConfig.DesignScreenHeight);

        InputManager.Instance.Initialize();
        InputManager.Instance.SetSceneCamera(GamePublic.Instance.SceneCamera);

        EnterState();
	}
	
	
	void LateUpdate () 
    {
        GamePublic.Instance.GameStatesManager.Update();

        InputManager.Instance.Update();
	}

    void OnDestroy ()
    {
        GamePublic.Instance.GameStatesManager.UnInitialize();
        TimerManager.Instance.UnInitialize();
    }

    private void EnterState()
    {
        if (GlobalConfig.IsMapEditorMode == false)
        {
            GamePublic.Instance.GameStatesManager.ChangeState(typeof(StartMenuState).Name);
        }
    }
}
