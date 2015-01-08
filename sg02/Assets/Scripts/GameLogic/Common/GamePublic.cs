using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class GamePublic : Singleton<GamePublic>
{
    /// <summary>
    /// 状态机管理
    /// </summary>
    private GameStatesManager m_gameStatesManager;
    public GameStatesManager GameStatesManager { get { return m_gameStatesManager; } }

    /// <summary>
    /// 场景摄像机
    /// </summary>
    private Camera m_sceneCamera;
    public Camera SceneCamera { get { return m_sceneCamera; } }

    /// <summary>
    /// 场景头节点
    /// </summary>
    private string m_sceneRootName = "Scene Root";
    private GameObject m_sceneRoot;
    public GameObject SceneRoot { get { return m_sceneRoot; } }

    /// <summary>
    /// UI 头节点
    /// </summary>
    private string m_uiRootName = "UI Root";
    private GameObject m_uiRoot;
    public GameObject UIRoot { get { return m_uiRoot; } }

    /// <summary>
    /// LUA管理器
    /// </summary>
    private LuaScriptMgr m_luaMgr;
    public LuaScriptMgr LuaManager { get { return m_luaMgr; } }

    /// <summary>
    /// 数据管理
    /// </summary>
    private DataManager m_datamanager;
    public DataManager DataManager { get { return m_datamanager; } }

    /// <summary>
    /// 历史时期列表
    /// </summary>
    private List<string> m_listTimes;
    public List<string> TimesList { get { return m_listTimes; } }

    /// <summary>
    /// 当前选择的历史时期
    /// </summary>
    public int CurrentTimes { get; set; }

    /// <summary>
    /// 当前的年份
    /// </summary>
    public int CurrentYear { get; set; }

    /// <summary>
    /// 玩家选择的君主
    /// </summary>
    public int CurrentKing { get; set; }

    /// <summary>
    /// 城市点的位置
    /// </summary>
    private Dictionary<int, Vector3> m_cityPoint;
    public Dictionary<int, Vector3> CityPoint {get {return m_cityPoint;}}

    // ------------------------------------------------------- 华丽的分割线 --------------------------------------------------

    /// <summary>
    /// 初始化函数
    /// </summary>
    public override void Initialize() 
    {
        m_gameStatesManager = new GameStatesManager();
        m_gameStatesManager.Initialize();

        m_sceneCamera = GameObject.FindGameObjectWithTag("SceneCamera").GetComponent<Camera>();
        m_uiRoot = GameObject.Find(m_uiRootName);
        m_sceneRoot = GameObject.Find(m_sceneRootName);

        m_datamanager = new DataManager();

        InitLuaManager();
        InitTimesList();
        InitCityPoints();
    }

    public override void UnInitialize() 
    {
        
    }

    /// <summary>
    /// 初始化LUA管理器
    /// </summary>
    private void InitLuaManager()
    {
        m_luaMgr = new LuaScriptMgr();
        m_luaMgr.Start();
    }

    /// <summary>
    /// 初始化历史时期列表
    /// </summary>
    private void InitTimesList()
    {
        m_listTimes = new List<string>();

        IEnumerator enumerator = XMLManager.Times.Data.Values.GetEnumerator();
        while (enumerator.MoveNext())
        {
            XMLDataTimes info = (XMLDataTimes)enumerator.Current;
            m_listTimes.Add(info.Name);
        }
    }

    /// <summary>
    /// 初始化城市的位置
    /// </summary>
    private void InitCityPoints()
    {
        m_cityPoint = new Dictionary<int, Vector3>();

        IEnumerator enumerator = XMLManager.CityPoints.Data.Values.GetEnumerator();
        while (enumerator.MoveNext())
        {
            XMLDataCityPoints data = (XMLDataCityPoints)enumerator.Current;
            
            if (m_cityPoint.ContainsKey(data.FromCity) == false)
            {
                string point = XMLManager.PathInfo.GetInfoById(data.FromPoint).Position;
                m_cityPoint.Add(data.FromCity, Utility.GetPoint(point));
            }

            if (m_cityPoint.ContainsKey(data.ToCity) == false)
            {
                string point = XMLManager.PathInfo.GetInfoById(data.ToPoint).Position;
                m_cityPoint.Add(data.ToCity, Utility.GetPoint(point));
            }
        }
    }
}
