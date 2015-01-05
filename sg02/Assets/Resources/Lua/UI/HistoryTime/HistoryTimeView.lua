module(..., package.seeall);

m_textTime = nil


function Initialize(viewPanel)

	m_textTime = viewPanel.transform:FindChild("Text").gameObject

end

function ShowTime ( text )
	
	m_textTime:GetComponent("Text").text = text

end