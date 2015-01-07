module(..., package.seeall);

m_ButtonsRoot = nil

function Initialize(viewPanel)

    m_setGeneralSkillAnchor = viewPanel.transform:FindChild("BattleUI/GeneralSkillAnchor").gameObject
    m_ButtonsRootGeneralSkill = viewPanel.transform:FindChild("BattleUI/GeneralSkillAnchor/GeneralSkill").gameObject

    m_setFightAnchor = viewPanel.transform:FindChild("BattleUI/FightAnchor").gameObject
    m_ButtonsRoot = viewPanel.transform:FindChild("BattleUI/FightAnchor/Button").gameObject
    m_btForwardGo = viewPanel.transform:FindChild("BattleUI/FightAnchor/Button/ForwardGo").gameObject
    m_btForwardBack = viewPanel.transform:FindChild("BattleUI/FightAnchor/Button/ForwardBack").gameObject
    m_btScatteredAround = viewPanel.transform:FindChild("BattleUI/FightAnchor/Button/ScatteredAround").gameObject
    m_btAllMiddle = viewPanel.transform:FindChild("BattleUI/FightAnchor/Button/AllMiddle").gameObject
    m_btStandby = viewPanel.transform:FindChild("BattleUI/FightAnchor/Button/Standby").gameObject
    m_btProtection = viewPanel.transform:FindChild("BattleUI/FightAnchor/Button/Protection").gameObject
    m_btCharge = viewPanel.transform:FindChild("BattleUI/FightAnchor/Button/Charge").gameObject
    m_btGeneralSkill = viewPanel.transform:FindChild("BattleUI/FightAnchor/Button/GeneralSkill").gameObject
    m_btGeneralGo = viewPanel.transform:FindChild("BattleUI/FightAnchor/Button/GeneralGo").gameObject
    m_btGeneralBack = viewPanel.transform:FindChild("BattleUI/FightAnchor/Button/GeneralBack").gameObject
    m_btRetreat = viewPanel.transform:FindChild("BattleUI/FightAnchor/Button/Retreat").gameObject
   

    m_l_RAGEbar = viewPanel.transform:FindChild("BattleUI/MinAnchor/LeftGeneral/RAGEbar").gameObject
    m_l_Name = viewPanel.transform:FindChild("BattleUI/MinAnchor/LeftGeneral/Name").gameObject
    m_l_Face = viewPanel.transform:FindChild("BattleUI/MinAnchor/LeftGeneral/Face").gameObject
    m_l_LevelInt = viewPanel.transform:FindChild("BattleUI/MinAnchor/LeftGeneral/LevelInt").gameObject
    m_l_VitInt = viewPanel.transform:FindChild("BattleUI/MinAnchor/LeftGeneral/VitInt").gameObject
    m_l_VitMaxInt = viewPanel.transform:FindChild("BattleUI/MinAnchor/LeftGeneral/VitMaxInt").gameObject
    m_l_VitIntbar = viewPanel.transform:FindChild("BattleUI/MinAnchor/LeftGeneral/VitIntbar").gameObject
    m_l_SPInt = viewPanel.transform:FindChild("BattleUI/MinAnchor/LeftGeneral/SPInt").gameObject
    m_l_SPMaxInt = viewPanel.transform:FindChild("BattleUI/MinAnchor/LeftGeneral/SPMaxInt").gameObject
    m_l_SPIntbar = viewPanel.transform:FindChild("BattleUI/MinAnchor/LeftGeneral/SPIntbar").gameObject
    m_l_MorInt = viewPanel.transform:FindChild("BattleUI/MinAnchor/LeftGeneral/MorInt").gameObject
    m_l_StrInt = viewPanel.transform:FindChild("BattleUI/MinAnchor/LeftGeneral/StrInt").gameObject
    m_l_IntInt = viewPanel.transform:FindChild("BattleUI/MinAnchor/LeftGeneral/IntInt").gameObject

    m_r_RAGEbar = viewPanel.transform:FindChild("BattleUI/MinAnchor/RightGeneral/RAGEbar").gameObject
    m_r_Name = viewPanel.transform:FindChild("BattleUI/MinAnchor/RightGeneral/Name").gameObject
    m_r_Face = viewPanel.transform:FindChild("BattleUI/MinAnchor/RightGeneral/Face").gameObject
    m_r_LevelInt = viewPanel.transform:FindChild("BattleUI/MinAnchor/RightGeneral/LevelInt").gameObject
    m_r_VitInt = viewPanel.transform:FindChild("BattleUI/MinAnchor/RightGeneral/VitInt").gameObject
    m_r_VitMaxInt = viewPanel.transform:FindChild("BattleUI/MinAnchor/RightGeneral/VitMaxInt").gameObject
    m_r_VitIntbar = viewPanel.transform:FindChild("BattleUI/MinAnchor/RightGeneral/VitIntbar").gameObject
    m_r_SPInt = viewPanel.transform:FindChild("BattleUI/MinAnchor/RightGeneral/SPInt").gameObject
    m_r_SPMaxInt = viewPanel.transform:FindChild("BattleUI/MinAnchor/RightGeneral/SPMaxInt").gameObject
    m_r_SPIntbar = viewPanel.transform:FindChild("BattleUI/MinAnchor/RightGeneral/SPIntbar").gameObject
    m_r_MorInt = viewPanel.transform:FindChild("BattleUI/MinAnchor/RightGeneral/MorInt").gameObject
    m_r_StrInt = viewPanel.transform:FindChild("BattleUI/MinAnchor/RightGeneral/StrInt").gameObject
    m_r_IntInt = viewPanel.transform:FindChild("BattleUI/MinAnchor/RightGeneral/IntInt").gameObject

    m_TimeInt = viewPanel.transform:FindChild("BattleUI/MinAnchor/Time").gameObject
    
end