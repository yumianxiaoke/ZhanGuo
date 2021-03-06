﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class KingInfo
{
    public bool Active { get; set; }
    public int ID { get; set; }

    public string Name { get; set; }
    public int GeneralID { get; set; }

    private List<int> m_citys;
    public List<int> Citys { get { return m_citys; } }

    private List<int> m_generals;
    public List<int> Generals { get { return m_generals; } }

    private List<int> m_prisons;
    public List<int> Prisons { get { return m_prisons; } }

    public int totalCitys {
        get
        {               
            int num_ = 0;
            for (int i = 0; i < Citys.Count; i++)
            {  
                CityInfo cityinfo = GamePublic.Instance.DataManager.GetCityInfo(Citys[i]);
                if (cityinfo.Level==3) 
                    num_++; 
            }
            return num_;
        }
    }
    public int totalLevel
    {
        get
        {
            int num_ = 0;
            for (int i = 0; i < Citys.Count; i++)
            {
                CityInfo cityinfo = GamePublic.Instance.DataManager.GetCityInfo(Citys[i]);
                if (cityinfo.Level == 1)
                    num_++;
            }
            return num_;
        }
    }
    public int totalMoney
    {
        get
        {
            int num_ = 0;
            for (int i = 0; i < Citys.Count; i++)
            {
                CityInfo cityinfo = GamePublic.Instance.DataManager.GetCityInfo(Citys[i]);
                num_ += cityinfo.Money;
            }
            return num_;
        }
    }
    public int totalPopulation
    {
        get
        {
            int num_ = 0;
            for (int i = 0; i < Citys.Count; i++)
            {
                CityInfo cityinfo = GamePublic.Instance.DataManager.GetCityInfo(Citys[i]);
                num_ += cityinfo.Population;
            }
            return num_;
        }
    }
    public int totalSoldier
    {
        get
        {
            int num_ = 0;
            for (int i = 0; i < Citys.Count; i++)
            {
                GeneralInfo info = GamePublic.Instance.DataManager.GetGeneralInfo(Generals[i]);
                num_ += info.SoldierCur;
            }
            return num_;
        }
    }
    public KingInfo()
    {
    }

    public KingInfo(int id)
    {
        ID = id;

        m_citys = new List<int>();
        m_generals = new List<int>();
        m_prisons = new List<int>();

        XMLDataKings data = XMLManager.Kings.GetInfoById(ID);

        Name = data.Name;
        GeneralID = DataManager.FindGeneralID(data.Name);

        int currentPeriod = GamePublic.Instance.CurrentTimes;
        if (data.Times[currentPeriod] == 0)
        {
            Active = false;
        }
        else
        {
            Active = true;
        }
    }

    public void AddCity(int cityID)
    {
        if (Citys.Contains(cityID))
        {
            return;
        }

        Citys.Add(cityID);

        CityInfo city = GamePublic.Instance.DataManager.GetCityInfo(cityID);
        city.KingID = ID;
    }

    public void RemoveCity(int cityID)
    {
        if (Citys.Contains(cityID) == false)
        {
            return;
        }

        Citys.Remove(cityID);

        CityInfo city = GamePublic.Instance.DataManager.GetCityInfo(cityID);
        city.KingID = 0;
    }

    public void AddGeneral(int generalID)
    {
        if (Generals.Contains(generalID))
        {
            return;
        }

        Generals.Add(generalID);

        GeneralInfo general = GamePublic.Instance.DataManager.GetGeneralInfo(generalID);

        if (general.KingID != 0)
        {
            KingInfo king = GamePublic.Instance.DataManager.GetKingInfo(general.KingID);
            king.RemoveGeneral(generalID);
        }

        general.KingID = ID;
    }

    public void RemoveGeneral(int generalID)
    {
        if (Generals.Contains(generalID) == false)
        {
            return;
        }

        Generals.Remove(generalID);

        GeneralInfo general = GamePublic.Instance.DataManager.GetGeneralInfo(generalID);
        general.KingID = 0;
    }

    public void AddPrisons(int generalID)
    {
        if (Prisons.Contains(generalID))
        {
            return;
        }

        Prisons.Add(generalID);

        GeneralInfo general = GamePublic.Instance.DataManager.GetGeneralInfo(generalID);
        if (general.PrisonerID != 0)
        {
            KingInfo king = GamePublic.Instance.DataManager.GetKingInfo(general.PrisonerID);
            king.RemovePrisons(generalID);
        }

        general.PrisonerID = ID;
    }

    public void RemovePrisons(int generalID)
    {
        if (Prisons.Contains(generalID) == false)
        {
            return;
        }

        Prisons.Remove(generalID);

        GeneralInfo general = GamePublic.Instance.DataManager.GetGeneralInfo(generalID);
        general.PrisonerID = 0;
    }
}
