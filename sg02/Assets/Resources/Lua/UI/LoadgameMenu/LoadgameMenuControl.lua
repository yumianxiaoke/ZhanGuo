module(..., package.seeall);


--初始化函数
function Initialize(viewPanel)

m_view = LoadgameMenuView
    m_view.Initialize(viewPanel)

    InitButtonEvent()
end

--反初始化函数
function UnInitialize()

UIManager.Instance:DestroyView(UINamesConfig.LoadgameMenu)
    

end

--初始化按钮事件
function InitButtonEvent()

    InputManager.Instance:AddOnClickEvent(m_view.m_btReturn,fn_btReturn)
    

end

--返回开始界面
function fn_btReturn()
	print("OK")
    UnInitialize()
    UIManager.Instance:ShowView(UINamesConfig.StartMenu)

end