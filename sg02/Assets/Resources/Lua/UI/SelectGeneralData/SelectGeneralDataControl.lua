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

end

--反初始化函数
function UnInitialize()
	m_generals = {}
end

--武将信息按钮
function InitButtonEvent(go, generalID)
	
	InputManager.Instance:AddOnClickEvent(go,OnGeneralSelect)
	m_generals[go] = generalID
end

function OnGeneralSelect(go)
	local generalID = m_generals[go]
	
	GeneralDataControl.ShowGeneralView(generalID)
	m_view.m_UP_Anchor:SetActive(false)
	m_view.m_Min_Anchor:SetActive(false)

end

--返回内政按钮
function FnReturn()

	UIManager.Instance:HideView(UINamesConfig.SelectGeneralData)
	m_InternalAffairs.m_Left:SetActive(true)
    m_InternalAffairs.m_Right:SetActive(true)
end