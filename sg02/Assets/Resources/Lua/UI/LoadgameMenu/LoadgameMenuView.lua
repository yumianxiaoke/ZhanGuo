module(..., package.seeall);


function Initialize(viewPanel)

    m_confirmBox = viewPanel.transform:FindChild("confirmBox").gameObject
    m_btNo = viewPanel.transform:FindChild("confirmBox/No").gameObject
    m_btYes = viewPanel.transform:FindChild("confirmBox/Yes").gameObject
    m_btReturn = viewPanel.transform:FindChild("confirmBox/Return").gameObject

    m_menuListRoot = viewPanel.transform:FindChild("Buttons").gameObject



   -- m_confirmBox:SetActive(false)
   -- m_menuListRoot.transform.localPosition = Vector3.New(0, 110, 0)
end