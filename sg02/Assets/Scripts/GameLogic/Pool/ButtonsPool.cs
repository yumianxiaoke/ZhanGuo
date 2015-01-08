using UnityEngine;
using System.Collections;

public class ButtonsPool : Singleton<ButtonsPool> 
{

    /// <summary>
    /// 字体预设
    /// </summary>
    private const string m_fontButtonExample = "Prefabs/UI/ButtonExample/FontButtonExample";
    private const string m_fontToggleExample = "Prefabs/UI/ButtonExample/FontToggleExample";
    //private const string m_imageButtonExample = "Prefabs/UI/ButtonExample/ImageButtonExample";

    /// <summary>
    /// 按钮的对象池
    /// </summary>
    private string m_poolRootName = "UI Root/Pool";
    private GameObject m_poolRoot;

    private ObjectPool m_poolButton;
    private int m_poolButtonSize = 30;
    public ObjectPool ButtonPool { get { return m_poolButton; } }

    private ObjectPool m_poolToggle;
    private int m_poolToggleSize = 30;
    public ObjectPool TogglePool { get { return m_poolToggle; } }

    public override void Initialize()
    {
        InitPool();
    }

    public override void UnInitialize()
    {
        ButtonPool.DestroyAll();
        TogglePool.DestroyAll();
    }

    /// <summary>
    /// 初始化对象池
    /// </summary>
    private void InitPool()
    {
        m_poolRoot = GameObject.Find(m_poolRootName);

        m_poolButton = new ObjectPool();
        m_poolButton.Initialize(m_poolButtonSize, 1000, CreateOneButton);

        m_poolToggle = new ObjectPool();
        m_poolToggle.Initialize(m_poolToggleSize, 1000, CreateOnToggle);
    }

    private GameObject CreateOneButton()
    {
        GameObject temp = ResourcesManager.Instance.Load<GameObject>(m_fontButtonExample);
        GameObject go = Object.Instantiate(temp) as GameObject;
        Utility.SetObjectChild(m_poolRoot, go);
        return go;
    }

    private GameObject CreateOnToggle()
    {
        GameObject temp = ResourcesManager.Instance.Load<GameObject>(m_fontToggleExample);
        GameObject go = Object.Instantiate(temp) as GameObject;
        Utility.SetObjectChild(m_poolRoot, go);
        return go;
    }

    public void GiveBackButton(GameObject go)
    {
        if (go == null) return;

        m_poolButton.GiveBackObject(go);

        Utility.SetObjectChild(m_poolRoot, go);
    }

    public void GiveBackToggle(GameObject go)
    {
        if (go == null) return;

        m_poolToggle.GiveBackObject(go);

        Utility.SetObjectChild(m_poolRoot, go);
    }
}
