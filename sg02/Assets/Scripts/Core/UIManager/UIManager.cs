﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// UI管理器, 用于管理所有的游戏ui的加载,显示,查找.
/// </summary>
public class UIManager : Singleton<UIManager>
{

    /// <summary>
    /// 视图保存字典
    /// </summary>
    public Dictionary<string, GameObject> m_dicUIView = new Dictionary<string, GameObject>();

    // UI摄像机物体
    private string m_uiRootName = "UI Root";
    private GameObject m_uiRoot;
    public GameObject UIRoot
    {
        get
        {
            if (m_uiRoot == null)
            {
                m_uiRoot = GameObject.Find(m_uiRootName);
            }

            return m_uiRoot;
        }
    }

    /// <summary>
    /// 显示一个界面，如果不在字典中就创建一个
    /// </summary>
    public GameObject ShowView(string name)
    {
        if (m_dicUIView.ContainsKey(name))
        {
            m_dicUIView[name].SetActive(true);
            return m_dicUIView[name];
        }

        GameObject go = ResourcesManager.Instance.LoadUIView(name, UIRoot);
        if (go == null)
        {
            Debugging.LogError("The view is not exist! name = " + name);
            return null;
        }

        go.SetActive(true);

        string[] split = name.Split('/');
        if (split.Length > 0)
            go.name = split[split.Length - 1];

        //LUA
        if (XMLManager.LuaControlView.Data.ContainsKey(go.name))
        {
            if (go.GetComponent<LuaControlView>() == null)
            {
                go.AddComponent<LuaControlView>();
            }
        }

        m_dicUIView.Add(name, go);

        return go;
    }

    /// <summary>
    /// 隐藏但不销毁
    /// </summary>
    public void HideView(string name)
    {
        if (!m_dicUIView.ContainsKey(name))
        {
            return;
        }

        m_dicUIView[name].SetActive(false);
    }

    /// <summary>
    /// 销毁一个对象
    /// </summary>
    public void DestroyView(string name)
    {
        if (!m_dicUIView.ContainsKey(name))
        {
            return;
        }

        GameObject go = m_dicUIView[name];
        m_dicUIView.Remove(name);
        Destroy(go);

        Resources.UnloadUnusedAssets();
    }

    public void DestroyView(GameObject view)
    {
        bool flag = false;

        IEnumerator<string> keyEnumerator = m_dicUIView.Keys.GetEnumerator();
        while (keyEnumerator.MoveNext())
        {
            if (view == m_dicUIView[keyEnumerator.Current])
            {
                flag = true;
                break;
            }
        }

        if (flag == false)
        {
            Debugging.LogError("The view is not exist! name = " + view.name);
            return;
        }

        m_dicUIView.Remove(keyEnumerator.Current);
        Destroy(view);
    }

    /// <summary>
    /// 销毁所有UI
    /// </summary>
    public void DestroyAllView()
    {
        IEnumerator<string> keyEnumerator = m_dicUIView.Keys.GetEnumerator();
        while (keyEnumerator.MoveNext())
        {
            GameObject go = m_dicUIView[keyEnumerator.Current];
            Destroy(go);
        }

        m_dicUIView.Clear();
    }

    void Destroy(GameObject view)
    {
        XMLDataLuaControlView info = XMLManager.LuaControlView.GetInfoByName(view.name);

        if (info != null)
        {
            GamePublic.Instance.LuaManager.CallLuaFunction("LuaFunctionHelper.CallFunction", info.LuaName, "UnInitialize", view);
        }
        else
        {
            Debugging.LogError("Function: LuaControlView. LuaModule is not Find! name = " + view.name);
        }

        GameObject.Destroy(view);
    }
}