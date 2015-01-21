module(..., package.seeall);


m_view = nil

--初始化函数
function Initialize(viewPanel)

    m_view = SelectGeneralDataView
    m_view.Initialize(viewPanel)
    m_view.InitView()

end

--反初始化函数
function UnInitialize()

end