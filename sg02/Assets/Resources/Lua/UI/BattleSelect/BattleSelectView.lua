module(..., package.seeall);

m_ButtonsRoot = nil

function Initialize(viewPanel)

    m_l_LeftArmyMilitaryName = viewPanel.transform:FindChild("LeftAnchor/LeftArmy/Army/MilitaryName").gameObject
    m_l_LeftArmyLeaderName = viewPanel.transform:FindChild("LeftAnchor/LeftArmy/Army/LeaderName").gameObject
    m_l_LeftArmyForceName = viewPanel.transform:FindChild("LeftAnchor/LeftArmy/Army/ForceName").gameObject
    m_l_LeftArmyMilitarySkillStr = viewPanel.transform:FindChild("LeftAnchor/LeftArmy/Army/MilitarySkillStr").gameObject
    m_l_LeftArmyTotalSoldierInt = viewPanel.transform:FindChild("LeftAnchor/LeftArmy/Army/TotalSoldierInt").gameObject
    m_l_LeftArmyTotalGeneralInt = viewPanel.transform:FindChild("LeftAnchor/LeftArmy/Army/TotalGeneralInt").gameObject

    m_l_LeftGeneralListRoot = viewPanel.transform:FindChild("LeftAnchor/LeftGeneralList").gameObject
    m_l_General = viewPanel.transform:FindChild("LeftAnchor/LeftGeneralList/General").gameObject
    m_l_Face = viewPanel.transform:FindChild("LeftAnchor/LeftGeneralList/General/Face").gameObject
    m_l_Name = viewPanel.transform:FindChild("LeftAnchor/LeftGeneralList/General/Name").gameObject
    m_l_VitInt = viewPanel.transform:FindChild("LeftAnchor/LeftGeneralList/General/VitInt").gameObject
    m_l_SPInt = viewPanel.transform:FindChild("LeftAnchor/LeftGeneralList/General/SPInt").gameObject


    m_l_RightArmyMilitaryName = viewPanel.transform:FindChild("RightAnchor/RightArmy/Army/MilitaryName").gameObject
    m_l_RightArmyLeaderName = viewPanel.transform:FindChild("RightAnchor/RightArmy/Army/LeaderName").gameObject
    m_l_RightArmyForceName = viewPanel.transform:FindChild("RightAnchor/RightArmy/Army/ForceName").gameObject
    m_l_RightArmyMilitarySkillStr = viewPanel.transform:FindChild("RightAnchor/RightArmy/Army/MilitarySkillStr").gameObject
    m_l_RightArmyTotalSoldierInt = viewPanel.transform:FindChild("RightAnchor/RightArmy/Army/TotalSoldierInt").gameObject
    m_l_RightArmyTotalGeneralInt = viewPanel.transform:FindChild("RightAnchor/RightArmy/Army/TotalGeneralInt").gameObject

    m_l_LeftGeneralListRoot = viewPanel.transform:FindChild("RightAnchor/RightGeneralList").gameObject
    m_l_General = viewPanel.transform:FindChild("RightAnchor/RightGeneralList/General").gameObject
    m_l_Face = viewPanel.transform:FindChild("RightAnchor/RightGeneralList/General/Face").gameObject
    m_l_Name = viewPanel.transform:FindChild("RightAnchor/RightGeneralList/General/Name").gameObject
    m_l_VitInt = viewPanel.transform:FindChild("RightAnchor/RightGeneralList/General/VitInt").gameObject
    m_l_SPInt = viewPanel.transform:FindChild("RightAnchor/RightGeneralList/General/SPInt").gameObject


    m_l_LeftGeneralName = viewPanel.transform:FindChild("MinAnchor/LeftGeneral/Name").gameObject
    m_l_LeftGeneralFace = viewPanel.transform:FindChild("MinAnchor/LeftGeneral/Face").gameObject
    m_l_LeftGeneralLevelInt = viewPanel.transform:FindChild("MinAnchor/LeftGeneral/LevelInt").gameObject
    m_l_LeftGeneralStrInt = viewPanel.transform:FindChild("MinAnchor/LeftGeneral/StrInt").gameObject
    m_l_LeftGeneralIntInt = viewPanel.transform:FindChild("MinAnchor/LeftGeneral/IntInt").gameObject
    m_l_LeftGeneralMorInt = viewPanel.transform:FindChild("MinAnchor/LeftGeneral/MorInt").gameObject

    m_l_RightGeneralName = viewPanel.transform:FindChild("MinAnchor/RightGeneral/Name").gameObject
    m_l_RightGeneralFace = viewPanel.transform:FindChild("MinAnchor/RightGeneral/Face").gameObject
    m_l_RightGeneralLevelInt = viewPanel.transform:FindChild("MinAnchor/RightGeneral/LevelInt").gameObject
    m_l_RightGeneralStrInt = viewPanel.transform:FindChild("MinAnchor/RightGeneral/StrInt").gameObject
    m_l_RightGeneralIntInt = viewPanel.transform:FindChild("MinAnchor/RightGeneral/IntInt").gameObject
    m_l_RightGeneralMorInt = viewPanel.transform:FindChild("MinAnchor/RightGeneral/MorInt").gameObject

    m_l_LeftLeftArmyDefenseInt = viewPanel.transform:FindChild("MinAnchor/LeftLeftArmy/DefenseInt").gameObject
    m_l_LeftLeftArmylandformInt = viewPanel.transform:FindChild("MinAnchor/LeftLeftArmy/landformInt").gameObject
    m_l_LeftLeftArmyFormationInt = viewPanel.transform:FindChild("MinAnchor/LeftLeftArmy/FormationInt").gameObject
    m_l_LeftLeftArmyGeneralSetStr = viewPanel.transform:FindChild("MinAnchor/LeftLeftArmy/GeneralSetStr").gameObject

    m_l_RightLeftArmyDefenseInt = viewPanel.transform:FindChild("MinAnchor/RightLeftArmy/DefenseInt").gameObject
    m_l_RightLeftArmylandformInt = viewPanel.transform:FindChild("MinAnchor/RightLeftArmy/landformInt").gameObject
    m_l_RightLeftArmyFormationInt = viewPanel.transform:FindChild("MinAnchor/RightLeftArmy/FormationInt").gameObject
    m_l_RightLeftArmyGeneralSetStr = viewPanel.transform:FindChild("MinAnchor/RightLeftArmy/GeneralSetStr").gameObject

    m_BtFighting = viewPanel.transform:FindChild("MinAnchor/Button/Fighting").gameObject
    m_BtSelectFormation = viewPanel.transform:FindChild("MinAnchor/Button/SelectFormation").gameObject
    m_BtSelectMilitarySkill = viewPanel.transform:FindChild("MinAnchor/Button/SelectMilitarySkill").gameObject
    m_BtSelectGeneralSet = viewPanel.transform:FindChild("MinAnchor/Button/SelectGeneralSet").gameObject
    m_BtRetreat = viewPanel.transform:FindChild("MinAnchor/Button/Retreat").gameObject


    m_FormationRoot = viewPanel.transform:FindChild("Formation_Anchor/Formation").gameObject

    m_MilitarySkillRoot = viewPanel.transform:FindChild("Formation_Anchor/MilitarySkill").gameObject

    m_BtFront = viewPanel.transform:FindChild("SelectGeneralSet_Anchor/Front_Frame/Front").gameObject
    m_BtBack = viewPanel.transform:FindChild("SelectGeneralSet_Anchor/Back_Frame/Back").gameObject

end