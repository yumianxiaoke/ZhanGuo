module(..., package.seeall);

m_view = nil
m_menuItem = {}

m_isMenuEnable = true

--??ʼ?????
function Initialize(viewPanel)

    m_view = InternalAffairsView
    m_view.Initialize(viewPanel)
    m_view.InitView()

    m_menuItem = {}
    m_isMenuEnable = true

    InitButtonEvent()

end

--????ʼ?????
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

--??ʼ????ť???
function InitButtonEvent()

    InputManager.Instance:AddOnClickEvent(m_view.m_btAutonomyDo, OnAutonomyDoClick)
    InputManager.Instance:AddOnClickEvent(m_view.m_btSearch, OnSearchClick)
    InputManager.Instance:AddOnClickEvent(m_view.m_btDevelop, OnDevelopClick)
    InputManager.Instance:AddOnClickEvent(m_view.m_btUseItem, OnUseItemClick)
    InputManager.Instance:AddOnClickEvent(m_view.m_btInformation,btInformation)
    InputManager.Instance:AddOnClickEvent(m_view.m_btForcesMap, OnForcesMapClick)
    InputManager.Instance:AddOnClickEvent(m_view.m_btSaveGame, OnSaveGameClick)
    InputManager.Instance:AddOnClickEvent(m_view.m_btLoadGame, OnLoadGameClick)
    InputManager.Instance:AddOnClickEvent(m_view.m_btOver,btOver)
    InputManager.Instance:AddOnClickEvent(m_view.m_buttonConfirmOK, OverOnButtonOK)
    InputManager.Instance:AddOnClickEvent(m_view.m_buttonConfirmCancel, OverOnButtonCancel)

end

function OnAutonomyDoClick()
    
    print("OnAutonomyDoClick")

end

function OnSearchClick()
    
    m_view.m_Left:SetActive(false)
    m_view.m_Right:SetActive(false)
    UIManager.Instance:ShowView(UINamesConfig.SearchAndDevelop)

end

function OnDevelopClick()
    
    m_view.m_Left:SetActive(false)
    m_view.m_Right:SetActive(false)
    UIManager.Instance:ShowView(UINamesConfig.SearchAndDevelop)

end

function OnUseItemClick()
    
    m_view.m_Left:SetActive(false)
    m_view.m_Right:SetActive(false)
    UIManager.Instance:ShowView(UINamesConfig.ItemUse)

end

function OnForcesMapClick()
    
    m_view.m_Left:SetActive(false)
    m_view.m_Right:SetActive(false)
    UIManager.Instance:ShowView(UINamesConfig.ForceMap)

end

function OnSaveGameClick()
    
    m_view.m_Left:SetActive(false)
    m_view.m_Right:SetActive(false)
    UIManager.Instance:ShowView(UINamesConfig.SaveGame)

end

function OnLoadGameClick()
    
    m_view.m_Left:SetActive(false)
    m_view.m_Right:SetActive(false)
    UIManager.Instance:ShowView(UINamesConfig.LoadGame)

end

--??????Ϣ
function btInformation()

    m_view.m_Left:SetActive(false)
    m_view.m_Right:SetActive(false)
    UIManager.Instance:ShowView(UINamesConfig.SelectGeneralData)
  
end

--???????
function btOver()

    --m_menuListRoot = false

    m_view.m_mask:SetActive(true)
    m_view.m_confirmBox:SetActive(true)

end

--ȷ??????
function OverOnButtonOK()

    --m_menuListRoot = true

    GamePublic.Instance.GameStatesManager:ChangeState(GamePublic.Instance.GameStatesManager.WorldMapState)
    m_view.m_confirmBox:SetActive(false)
end

--ȡ?
function OverOnButtonCancel()

    --m_menuListRoot = true
    
    m_view.m_mask:SetActive(false)
    m_view.m_confirmBox:SetActive(false)

end



--?˵??ѡ??Ӧ
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