module(..., package.seeall);


m_view = nil

--初始化函数
function Initialize(viewPanel)

    m_view = GeneralDataView
    m_view.Initialize(viewPanel)
    test()

end

--反初始化函数
function UnInitialize()

end

--测试函数
function test()
	m_view.InitView(100)
end