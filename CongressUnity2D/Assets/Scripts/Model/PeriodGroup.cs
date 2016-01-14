using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Period group.
/// </summary>
public class PeriodGroup : MonoBehaviour {

	// Holders.
	public GameObject morningHolder;
    public GameObject noonHolder;
    public GameObject afternoonHolder;
    public GameObject eveningHolder;
    public GameObject nightHolder;

	// Periods of the day.
	public Dictionary<string, Period> periods;

	// Use this for initialization
	void Start () {
        periods = new Dictionary<string, Period>();
		periods["morning"] = (Period)morningHolder.GetComponent (typeof(Period));
		periods["afternoon"] = (Period)afternoonHolder.GetComponent (typeof(Period));
		periods["noon"] = (Period)noonHolder.GetComponent (typeof(Period));
        periods["evening"] = (Period)eveningHolder.GetComponent(typeof(Period));
        periods["night"] = (Period)nightHolder.GetComponent(typeof(Period));
    }

    /// <summary>
    /// Deactivates all the periods, except the specified one.
    /// </summary>
    /// <param name="exception">Period to not deactivate.</param>
    public void deactivateAllButOne(Period exception)
    {
        
        foreach(Period p in periods.Values)
        {
            if (exception != p)
                p.setActive(false);
        }
    }

}
