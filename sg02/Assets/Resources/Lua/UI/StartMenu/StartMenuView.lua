module(..., package.seeall);

m_btnStartGame = nil
m_btnLoadGame = nil
m_btnSetting = nil
m_btnQuit = nil

m_btnTestLUA = nil
m_menuListRoot = nil

function Initialize(viewPanel)

    m_btnStartGame = viewPanel.transform:FindChild("Buttons/Start_game").gameObject
    m_btnLoadGame = viewPanel.transform:FindChild("Buttons/Load_game").gameObject
    m_btnSetting = viewPanel.transform:FindChild("Buttons/Setting_game").gameObject
    m_btnQuit = viewPanel.transform:FindChild("Buttons/Quit_game").gameObject

    m_btnTestLUA = viewPanel.transform:FindChild("TestLUAView").gameObject
    m_menuListRoot = viewPanel.transform:FindChild("TestLUAView/Root").gameObject

end