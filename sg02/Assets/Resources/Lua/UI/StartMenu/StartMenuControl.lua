module(..., package.seeall);

m_view = nil

--初始化函数
function Initialize(viewPanel)

    --Test(viewPanel)
    
    m_view = StartMenuView
    m_view.Initialize(viewPanel)

    InitButtonEvent()

end

--反初始化函数
function UnInitialize()
    
    UIManager.Instance:DestroyView(UINamesConfig.StartMenu)

end

--初始化按钮事件
function InitButtonEvent()

    InputManager.Instance:AddOnClickEvent(m_view.m_btnStartGame, OnStartGameButton)
    InputManager.Instance:AddOnClickEvent(m_view.m_btnLoadGame, OnLoadGameButton)
    InputManager.Instance:AddOnClickEvent(m_view.m_btnSetting, OnSettingsButton)
    InputManager.Instance:AddOnClickEvent(m_view.m_btnQuit, OnQuitButton)

    InputManager.Instance:AddOnClickEvent(m_view.m_btnTestLUA, TestLuaView)

end

--开始按钮
function OnStartGameButton(go)

    GamePublic.Instance.GameStatesManager:ChangeState(GamePublic.Instance.GameStatesManager.SelectTimesState)

end

--加载存档
function OnLoadGameButton(go)

    UnInitialize()
    UIManager.Instance:ShowView(UINamesConfig.LoadgameMenu)

end

--设置
function OnSettingsButton(go)

    print("OnSettingsButton")

end

--退出
function OnQuitButton(go)

    Application.Quit();

end

--测试
function Test(viewPanel)

    local func = function (gameObject)
		print("callback sucess!");
		return true;
	end
    test = TestLuaFunctionType.New(viewPanel)

    test.testDelegate = func
    test:LuaFunctionType("StartMenuView.Initialize", viewPanel)
    test:CallDelegate()

    test:CallDelegate(OnStartGameButton)
    
end

--测试LUA界面

m_viewPath = {}
m_viewName = {}
m_menuItem = {}

m_isInit = false

function TestLuaView()
    
    m_view.m_menuListRoot:SetActive(true)

    if m_isInit then return end
    m_isInit = true

    m_viewPath[1] = UINamesConfig.AdviserInstructions
    m_viewPath[2] = UINamesConfig.AllInstructions
    m_viewPath[3] = UINamesConfig.BattleFighting
    m_viewPath[4] = UINamesConfig.BattleReady
    m_viewPath[5] = UINamesConfig.BattleSelect
    m_viewPath[6] = UINamesConfig.CityInstructions
    m_viewPath[7] = UINamesConfig.DraftInstructions
    m_viewPath[8] = UINamesConfig.FightPrepareInstructions
    m_viewPath[9] = UINamesConfig.GeneralData
    m_viewPath[10] = UINamesConfig.MajorInstructions
    m_viewPath[11] = UINamesConfig.SelectGeneralData

    m_viewName[1] = "AdviserInstructions"
    m_viewName[2] = "AllInstructions"
    m_viewName[3] = "BattleFighting"
    m_viewName[4] = "BattleReady"
    m_viewName[5] = "BattleSelect"
    m_viewName[6] = "CityInstructions"
    m_viewName[7] = "DraftInstructions"
    m_viewName[8] = "FightPrepareInstructions"
    m_viewName[9] = "GeneralData"
    m_viewName[10] = "MajorInstructions"
    m_viewName[11] = "SelectGeneralData"

    for i = 1, 11 do 
    local name = m_viewName[i]
    local go = Utility.AddChildButton(m_view.m_menuListRoot, name)

    go.transform.localPosition = Vector3.New(0, 135 + GlobalConfig.FontButtonsVSpace * (i - 1))

    m_menuItem[go] = m_viewPath[i]
    InputManager.Instance:AddOnClickEvent(go, OnMenuItemClick)

    i = i + 1
    end

end

function OnMenuItemClick(go)
    
    local viewPath = m_menuItem[go]
    local  view = UIManager.Instance:ShowView(viewPath)
    TimerManager.Instance:AddTimer(3, 0, false, DestroyTestView, view)

    m_view.m_menuListRoot:SetActive(false)

end

function DestroyTestView(go)
    
    UIManager.Instance:DestroyView(go)

end