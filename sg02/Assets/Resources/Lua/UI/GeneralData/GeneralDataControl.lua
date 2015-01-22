module(..., package.seeall);


m_view = nil
m_generalID = nil

--初始化函数
function Initialize(viewPanel)

    m_view = GeneralDataView
    m_view.Initialize(viewPanel)
    m_view.InitView(m_generalID)

end

--反初始化函数
function UnInitialize()

end

function ShowGeneralView(generalID)
	m_generalID = generalID
	UIManager.Instance:ShowView(UINamesConfig.GeneralData)
	
end