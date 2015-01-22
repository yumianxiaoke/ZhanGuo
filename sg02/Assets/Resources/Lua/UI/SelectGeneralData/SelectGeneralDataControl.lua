module(..., package.seeall);


m_view = nil

m_generals = {}

--初始化函数
function Initialize(viewPanel)

	m_generals = {}
    m_view = SelectGeneralDataView
    m_view.Initialize(viewPanel)
    m_view.InitView()

end

--反初始化函数
function UnInitialize()
	m_generals = {}
end


function InitButtonEvent(go, generalID)
	
	InputManager.Instance:AddOnClickEvent(go,OnGeneralSelect)
	m_generals[go] = generalID
end

function OnGeneralSelect(go)
	local generalID = m_generals[go]
	
	GeneralDataControl.ShowGeneralView(generalID)
end