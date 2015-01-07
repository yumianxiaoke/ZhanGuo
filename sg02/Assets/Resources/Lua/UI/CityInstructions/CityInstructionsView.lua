module(..., package.seeall);

m_ButtonsRoot = nil

function Initialize(viewPanel)

    m_Face = viewPanel.transform:FindChild("RightAnchor/Face").gameObject


    m_btFight = viewPanel.transform:FindChild("LeftAnchor_Down/Fight").gameObject
    m_btConscription = viewPanel.transform:FindChild("LeftAnchor_Down/Conscription").gameObject
    m_btMajor = viewPanel.transform:FindChild("LeftAnchor_Down/Major").gameObject
    m_btAdviser = viewPanel.transform:FindChild("LeftAnchor_Down/Adviser").gameObject
    m_btData = viewPanel.transform:FindChild("LeftAnchor_Down/Data").gameObject
    m_Autonomy = viewPanel.transform:FindChild("LeftAnchor_Down/Autonomy").gameObject

    m_btAutonomyFight = viewPanel.transform:FindChild("AutonomyAnchor/Fight").gameObject
    m_btConscription = viewPanel.transform:FindChild("AutonomyAnchor/Conscription").gameObject
    m_btAutonomyMajor = viewPanel.transform:FindChild("AutonomyAnchor/Major").gameObject
    m_btAdviser = viewPanel.transform:FindChild("AutonomyAnchor/Adviser").gameObject
       

end