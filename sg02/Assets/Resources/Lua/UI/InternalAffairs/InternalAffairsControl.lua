module(..., package.seeall);

m_view = nil
m_menuItem = {}

m_isMenuEnable = true

--初始化函数
function Initialize(viewPanel)

    m_view = InternalAffairsView
    m_view.Initialize(viewPanel)
    m_view.InitView()

    m_menuItem = {}
    m_isMenuEnable = true

    InitButtonEvent()

end

--反初始化函数
function UnInitialize()

    for key, value in pairs(m_menuItem) do      
        Utility.RemoveButton(key)
    end

    m_menuItem = {}

end

--[[
function InitMenuList()

    local i = 0
    local enumerator = XMLManager.MenuItem.Data.Values:GetEnumerator()
    while enumerator:MoveNext() do
        local menuItemInfo = enumerator.Current
        if menuItemInfo.Type == Define.MenuItemType.InternalAffairs then
            local name = menuItemInfo.Name
            local go = Utility.AddChildButton(m_view.m_menuListRoot, name)

            go.transform.localPosition = Vector3.New(0, GlobalConfig.FontButtonsVSpace * i)

            m_menuItem[go] = menuItemInfo.ID
            InputManager.Instance:AddOnClickEvent(go, OnMenuItemClick)

            i = i + 1
        end
        
    end

end
]]--

--初始化按钮事件
function InitButtonEvent()

    InputManager.Instance:AddOnClickEvent(m_view.m_btInformation,btInformation)
    InputManager.Instance:AddOnClickEvent(m_view.m_btOver,btOver)
    InputManager.Instance:AddOnClickEvent(m_view.m_buttonConfirmOK, OverOnButtonOK)
    InputManager.Instance:AddOnClickEvent(m_view.m_buttonConfirmCancel, OverOnButtonCancel)

end

--点击武将信息
function btInformation()

    m_view.m_Left:SetActive(false)
    m_view.m_Right:SetActive(false)
    UIManager.Instance:ShowView(UINamesConfig.SelectGeneralData)

end

--点击内政终了
function btOver()

    m_menuListRoot = false
    m_view.m_confirmBox:SetActive(true)

end

--确认内政终了
function OverOnButtonOK()

    m_menuListRoot = true
    GamePublic.Instance.GameStatesManager:ChangeState(GamePublic.Instance.GameStatesManager.WorldMapState)
    m_view.m_confirmBox:SetActive(false)
end

--取消
function OverOnButtonCancel()

    m_menuListRoot = true
    m_view.m_confirmBox:SetActive(false)

end



--菜单项选择响应
function OnMenuItemClick(go)

    if not m_isMenuEnable then
        return
    end
    
    local ID = m_menuItem[go]
    if ID == 10 then 
        m_isMenuEnable = false
        m_view.m_confirmBox:SetActive(true)
    end

end