module(..., package.seeall);


m_view = nil
m_generals = {}

--初始化函数
function Initialize(viewPanel)
	
	m_generals = {}
	m_InternalAffairs = InternalAffairsView
    m_view = SelectGeneralDataView
    m_view.Initialize(viewPanel)
    m_view.InitView()
    InputManager.Instance:AddOnClickEvent(m_view.m_BtReturn,FnReturn)
    InputManager.Instance:AddOnClickEvent(m_view.m_UP, OnUpButtonClick)
    InputManager.Instance:AddOnClickEvent(m_view.m_Down, OnDownButtonClick)    

end

--反初始化函数
function UnInitialize()
	m_generals = {}
end

--武将信息按钮
function InitButtonEvent(go, generalID)
	
	m_generals[go] = generalID
	InputManager.Instance:AddOnClickEvent(go,OnGeneralSelect)
	
end

function OnGeneralSelect(go)
	local generalID = m_generals[go]
	
	m_view.m_UP_Anchor:SetActive(false)
	m_view.m_Min_Anchor:SetActive(false)
	GeneralDataControl.ShowGeneralView(generalID)

end

--滚动条的向上按钮点击事件
--固定步长，step = 1
function OnUpButtonClick()

	local KingID = GamePublic.Instance.CurrentKing
    local KingInfo = GamePublic.Instance.DataManager:GetKingInfo(KingID)

    m_view.m_SBComponent.Value = m_view.m_SBComponent.Value + 1 / KingInfo.Generals.Count
end

--滚动条的向下按钮点击事件
function OnDownButtonClick()
	
	local KingID = GamePublic.Instance.CurrentKing
    local KingInfo = GamePublic.Instance.DataManager:GetKingInfo(KingID)

    m_view.m_SBComponent.Value = m_view.m_SBComponent.Value - 1 / KingInfo.Generals.Count
	
end

--返回内政按钮
function FnReturn()

	UIManager.Instance:HideView(UINamesConfig.SelectGeneralData)
	m_InternalAffairs.m_Left:SetActive(true)
    m_InternalAffairs.m_Right:SetActive(true)
end