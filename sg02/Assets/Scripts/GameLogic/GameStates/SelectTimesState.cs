using UnityEngine;
using System.Collections;

public class SelectTimesState : IState
{

    public string Name
    {
        get
        {
            return this.GetType().Name;
        }
    }
    public void OnEnter()
    {
        GamePublic.Instance.LuaManager.CallLuaFunction("LuaFunctionHelper.CallFunction", "SelectTimesState", "OnEnter");
    }

    public void OnExit()
    {
        GamePublic.Instance.LuaManager.CallLuaFunction("LuaFunctionHelper.CallFunction", "SelectTimesState", "OnExit");
    }

    public void Update()
    {

    }

    public bool IfCanChangeToState(IState state)
    {
        return true;
    }
}
