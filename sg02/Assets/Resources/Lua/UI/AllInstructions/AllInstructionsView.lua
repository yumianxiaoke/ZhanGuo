module(..., package.seeall);

m_ButtonsRoot = nil

function Initialize(viewPanel)

    m_setAllInstructions = viewPanel.transform:FindChild("set").gameObject

    m_btForcesMap = viewPanel.transform:FindChild("set/frame_5/ForcesMap").gameObject
    m_btFindGeneral = viewPanel.transform:FindChild("set/frame_5/FindGeneral").gameObject
    m_btLoadGame = viewPanel.transform:FindChild("set/frame_5/LoadGame").gameObject
    m_btSaveGame = viewPanel.transform:FindChild("set/frame_5/SaveGame").gameObject
    m_btLeaveGame = viewPanel.transform:FindChild("set/frame_5/LeaveGame").gameObject

end