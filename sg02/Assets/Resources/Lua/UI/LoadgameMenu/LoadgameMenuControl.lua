module(..., package.seeall);


--��ʼ������
function Initialize(viewPanel)

m_view = LoadgameMenuView
    m_view.Initialize(viewPanel)

    InitButtonEvent()
end

--����ʼ������
function UnInitialize()

UIManager.Instance:DestroyView(UINamesConfig.LoadgameMenu)
    

end

--��ʼ����ť�¼�
function InitButtonEvent()

    InputManager.Instance:AddOnClickEvent(m_view.m_btReturn,fn_btReturn)
    

end

--���ؿ�ʼ����
function fn_btReturn()
	print("OK")
    UnInitialize()
    UIManager.Instance:ShowView(UINamesConfig.StartMenu)

end