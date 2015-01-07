module(..., package.seeall);

m_ButtonsRoot = nil

function Initialize(viewPanel)

    m_l_strGeneralName = viewPanel.transform:FindChild("LeftAnchor/GeneralName").gameObject
    m_l_Face = viewPanel.transform:FindChild("LeftAnchor/Face").gameObject
    m_l_strMilitarySkill = viewPanel.transform:FindChild("LeftAnchor/MilitarySkill").gameObject
    m_l_strMilitarySkillStr = viewPanel.transform:FindChild("LeftAnchor/MilitarySkill/MilitarySkillStr").gameObject
    
    m_l_ArmyTotalSoldierInt = viewPanel.transform:FindChild("MinAnchor/Information/LeftArmy/Army/TotalSoldierInt").gameObject
    m_l_ArmyTotalPowerInt = viewPanel.transform:FindChild("MinAnchor/Information/LeftArmy/Army/TotalPowerInt").gameObject
    m_l_ArmyMorInt = viewPanel.transform:FindChild("MinAnchor/Information/LeftArmy/Army/MorInt").gameObject
    m_l_ArmyFormationInt = viewPanel.transform:FindChild("MinAnchor/Information/LeftArmy/Army/FormationInt").gameObject
    m_l_ArmyLandformInt = viewPanel.transform:FindChild("MinAnchor/Information/LeftArmy/Army/LandformInt").gameObject
    m_l_ArmyArmsInt = viewPanel.transform:FindChild("MinAnchor/Information/LeftArmy/Army/ArmsInt").gameObject

    m_r_ArmyTotalSoldierInt = viewPanel.transform:FindChild("MinAnchor/Information/RightArmy/Army/TotalSoldierInt").gameObject
    m_r_ArmyTotalPowerInt = viewPanel.transform:FindChild("MinAnchor/Information/RightArmy/Army/TotalPowerInt").gameObject
    m_r_ArmyMorInt = viewPanel.transform:FindChild("MinAnchor/Information/RightArmy/Army/MorInt").gameObject
    m_r_ArmyFormationInt = viewPanel.transform:FindChild("MinAnchor/Information/RightArmy/Army/FormationInt").gameObject
    m_r_ArmyLandformInt = viewPanel.transform:FindChild("MinAnchor/Information/RightArmy/Army/LandformInt").gameObject
    m_r_ArmyArmsInt = viewPanel.transform:FindChild("MinAnchor/Information/RightArmy/Army/ArmsInt").gameObject

    m_r_strGeneralName = viewPanel.transform:FindChild("RightAnchor/GeneralName").gameObject
    m_r_Face = viewPanel.transform:FindChild("RightAnchor/Face").gameObject
    m_r_strMilitarySkill = viewPanel.transform:FindChild("RightAnchor/MilitarySkill").gameObject
    m_r_strMilitarySkillStr = viewPanel.transform:FindChild("RightAnchor/MilitarySkill/MilitarySkillStr").gameObject

end