module(..., package.seeall);


m_view = nil

--初始化函数
function Initialize(viewPanel)

    m_view = BattleReadyView
    m_view.Initialize(viewPanel)

end

--反初始化函数
function UnInitialize()

end