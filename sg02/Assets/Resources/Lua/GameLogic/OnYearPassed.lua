module(..., package.seeall);

function OnYearPassed ()
	
	GamePublic.Instance.GameStatesManager:ChangeState(GamePublic.Instance.GameStatesManager.InternalAffairsState)
	
end