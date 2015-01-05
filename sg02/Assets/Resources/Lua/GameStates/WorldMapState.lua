module(..., package.seeall);

function OnEnter()

    UIManager.Instance:ShowView(UINamesConfig.HistoryTime)

end

function  OnExit()

    UIManager.Instance:DestroyView(UINamesConfig.HistoryTime)

end
