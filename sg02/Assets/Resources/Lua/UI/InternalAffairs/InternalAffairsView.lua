module(..., package.seeall);

m_menuListRoot = nil
m_imageFace = nil

m_confirmBox = nil
m_buttonConfirmOK = nil
m_buttonConfirmCancel = nil

function Initialize(viewPanel)

    m_menuListRoot = viewPanel.transform:FindChild("Left Anchor/MenuList").gameObject

    m_btAutonomyDo = viewPanel.transform:FindChild("Left Anchor/MenuList/AutonomyDo").gameObject
    m_btSearch = viewPanel.transform:FindChild("Left Anchor/MenuList/Search").gameObject
    m_btDevelop = viewPanel.transform:FindChild("Left Anchor/MenuList/Develop").gameObject
    m_btUseItem = viewPanel.transform:FindChild("Left Anchor/MenuList/UseItem").gameObject
    m_btInformation = viewPanel.transform:FindChild("Left Anchor/MenuList/Information").gameObject
    m_btForcesMap = viewPanel.transform:FindChild("Left Anchor/MenuList/ForcesMap").gameObject
    m_btSaveGame = viewPanel.transform:FindChild("Left Anchor/MenuList/SaveGame").gameObject
    m_btLoadGame = viewPanel.transform:FindChild("Left Anchor/MenuList/LoadGame").gameObject
    m_btOver = viewPanel.transform:FindChild("Left Anchor/MenuList/Over").gameObject


    m_imageFace = viewPanel.transform:FindChild("Right Anchor/Face").gameObject

    m_TimeStr = viewPanel.transform:FindChild("Right Anchor/TimeStr").gameObject
    m_KingName = viewPanel.transform:FindChild("Right Anchor/KingName").gameObject
    m_CityInt = viewPanel.transform:FindChild("Right Anchor/CityInt").gameObject
    m_TollgateInt = viewPanel.transform:FindChild("Right Anchor/TollgateInt").gameObject
    m_GeneralInt = viewPanel.transform:FindChild("Right Anchor/GeneralInt").gameObject
    m_SoldierInt = viewPanel.transform:FindChild("Right Anchor/SoldierInt").gameObject
    m_MoneyInt = viewPanel.transform:FindChild("Right Anchor/MoneyInt").gameObject
    m_PopulationInt = viewPanel.transform:FindChild("Right Anchor/PopulationInt").gameObject

    m_confirmBox = viewPanel.transform:FindChild("Left Anchor/ConfirmBox").gameObject
    m_buttonConfirmOK = viewPanel.transform:FindChild("Left Anchor/ConfirmBox/ButtonOK").gameObject
    m_buttonConfirmCancel = viewPanel.transform:FindChild("Left Anchor/ConfirmBox/ButtonCancel").gameObject


    m_confirmBox:SetActive(false)
    m_menuListRoot.transform.localPosition = Vector3.New(0, 110, 0)
end