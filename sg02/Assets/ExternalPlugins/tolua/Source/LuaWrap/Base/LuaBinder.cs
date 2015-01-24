﻿using System;

public static class LuaBinder
{
	public static void Bind(IntPtr L)
	{
		objectWrap.Register(L);
		ObjectWrap.Register(L);
		coroutineWrap.Register(L);
		WrapAnimationComponent.Register(L);
		WrapBehaviour.Register(L);
		WrapCityInfo.Register(L);
		WrapComponent.Register(L);
		WrapDataManager.Register(L);
		WrapDebugging.Register(L);
		WrapDictEnumerator.Register(L);
		WrapDictInt2Str.Register(L);
		WrapDictionary.Register(L);
		WrapEntity.Register(L);
		WrapFSMBase.Register(L);
		WrapGameObject.Register(L);
		WrapGamePublic.Register(L);
		WrapGameStatesManager.Register(L);
		WrapGeneralInfo.Register(L);
		WrapGlobalConfig.Register(L);
		WrapInputManager.Register(L);
		WrapIState.Register(L);
		WrapKingInfo.Register(L);
		WrapList_int.Register(L);
		WrapList_string.Register(L);
		WrapMapCameraControl.Register(L);
		WrapMonoBehaviour.Register(L);
		WrapMovmentComponent.Register(L);
		WrapObjectPool.Register(L);
		WrapPathFinding.Register(L);
		WrapResources.Register(L);
		WrapResourcesManager.Register(L);
		WrapScreenControl.Register(L);
		WrapSpriteRenderer.Register(L);
		WrapStateBase.Register(L);
		WrapStateManager.Register(L);
		WrapTestLuaFunctionType.Register(L);
		WrapText.Register(L);
		WrapTextAsset.Register(L);
		WrapTime.Register(L);
		WrapTimerManager.Register(L);
		WrapToggle.Register(L);
		WrapTransform.Register(L);
		WrapUIButton.Register(L);
		WrapUIManager.Register(L);
		WrapUIToggle.Register(L);
		WrapUtility.Register(L);
		WrapVector2.Register(L);
		WrapVector3.Register(L);
		WrapWorldMapControl.Register(L);
		WrapXMLConfigPath.Register(L);
		WrapXMLDataAnimations.Register(L);
		WrapXMLDataBattle.Register(L);
		WrapXMLDataCity.Register(L);
		WrapXMLDataCityPoints.Register(L);
		WrapXMLDataForce.Register(L);
		WrapXMLDataGenerals.Register(L);
		WrapXMLDataKings.Register(L);
		WrapXMLDataLanguage.Register(L);
		WrapXMLDataMagic.Register(L);
		WrapXMLDataMenuItem.Register(L);
		WrapXMLDataPathInfo.Register(L);
		WrapXMLDataThings.Register(L);
		WrapXMLDataTimes.Register(L);
		WrapXMLDataWiseSkill.Register(L);
		WrapXMLLoader_XMLDataAnimations.Register(L);
		WrapXMLLoader_XMLDataBattle.Register(L);
		WrapXMLLoader_XMLDataCity.Register(L);
		WrapXMLLoader_XMLDataCityPoints.Register(L);
		WrapXMLLoader_XMLDataForce.Register(L);
		WrapXMLLoader_XMLDataGenerals.Register(L);
		WrapXMLLoader_XMLDataKings.Register(L);
		WrapXMLLoader_XMLDataLanguage.Register(L);
		WrapXMLLoader_XMLDataMagic.Register(L);
		WrapXMLLoader_XMLDataMenuItem.Register(L);
		WrapXMLLoader_XMLDataPathInfo.Register(L);
		WrapXMLLoader_XMLDataThings.Register(L);
		WrapXMLLoader_XMLDataTimes.Register(L);
		WrapXMLLoader_XMLDataWiseSkill.Register(L);
		WrapXMLManager.Register(L);
	}
}
