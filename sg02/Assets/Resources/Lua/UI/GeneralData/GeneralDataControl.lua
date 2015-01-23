module(..., package.seeall);


m_view = nil
m_generalID = nil

--初始化函数
function Initialize(viewPanel)
    
    m_SelectGeneralData = SelectGeneralDataView
    m_view = GeneralDataView
    m_view.Initialize(viewPanel)
    m_view.InitView(m_generalID)
    InputManager.Instance:AddOnClickEvent(m_view.m_BtReturn,FnReturn)

end

--反初始化函数
function UnInitialize()

end

function ShowGeneralView(generalID)
	m_generalID = generalID
	UIManager.Instance:ShowView(UINamesConfig.GeneralData)
	
end

function FnReturn()

	UIManager.Instance:HideView(UINamesConfig.GeneralData)
	m_SelectGeneralData.m_UP_Anchor:SetActive(true)
	m_SelectGeneralData.m_Min_Anchor:SetActive(true)
	m_generalID = nil

end