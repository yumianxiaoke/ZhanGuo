module(..., package.seeall);


m_view = nil

m_timer = nil
m_month = 1

--初始化函数
function Initialize(viewPanel)

    m_view = HistoryTimeView
    m_view.Initialize(viewPanel)

    m_month = 1
    ShowTime()

    m_timer = TimerManager.Instance:AddTimer(1, -1, true, OnTimer)

end

--反初始化函数
function UnInitialize()

    TimerManager.Instance:Stop(m_timer)

end

function ShowTime()
	
	local text = XMLManager.Language:GetInfoByName("A.D.").Content .. "  "
    text = text .. GamePublic.Instance.CurrentYear .. XMLManager.Language:GetInfoByName("Year").Content .. " "
    text = text .. m_month .. XMLManager.Language:GetInfoByName("Month").Content
    m_view.ShowTime(text)

end

function OnTimer ()
	
	m_month = m_month + 1
    if m_month <= 12 then
        ShowTime()
        OnMonthPassed.OnMonthPassed()
    else
        m_month = 1
        OnYearPassed.OnYearPassed()
    end

end