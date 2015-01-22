module(..., package.seeall);

m_view = nil

--
local m_tableTimes = {}

--��ʼ������
function Initialize(viewPanel)

    m_view = SelectTimesView
    m_view.Initialize(viewPanel)

    InitButtons()

end

--����ʼ������
function UnInitialize()

    for key, value in pairs(m_tableTimes) do      
        Utility.RemoveButton(key)
    end

    m_tableTimes = {}

end

--��ʼ����ť�б�
function InitButtons()

    local timesList = GamePublic.Instance.TimesList
    local count = timesList.Count

    for i=0, count - 1 do
        local go = Utility.AddChildButton(m_view.m_ButtonsRoot, timesList:get_Item(i))

        go.transform.localPosition = Vector3.New(0, GlobalConfig.FontButtonsVSpace * i)

        m_tableTimes[go] = i+1
        InputManager.Instance:AddOnClickEvent(go, OnButtonClick)
    end

end

--������Ӧ
function OnButtonClick(go)

    local currentTimes = m_tableTimes[go]
    GamePublic.Instance.CurrentTimes = currentTimes
    GamePublic.Instance.CurrentYear = XMLManager.Times:GetInfoById(currentTimes).Year

    GamePublic.Instance.GameStatesManager:ChangeState(GamePublic.Instance.GameStatesManager.SelectKingState)

end