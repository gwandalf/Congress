using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Period group.
/// </summary>
public class PeriodGroup : MonoBehaviour {

	// Holders.
	public GameObject morningHolder;
	public GameObject afternoonHolder;
	public GameObject noonHolder;

	// Periods of the day.
	private Dictionary<string, Period> periods;

	// Use this for initialization
	void Start () {
        this.periods = new Dictionary<string, Period>();
		this.periods["morning"] = (Period)this.morningHolder.GetComponent (typeof(Period));
		this.periods["afternoon"] = (Period)this.afternoonHolder.GetComponent (typeof(Period));
		this.periods["noon"] = (Period)this.noonHolder.GetComponent (typeof(Period));
	}

    /// <summary>
    /// Deactivates all the periods, except the specified one.
    /// </summary>
    /// <param name="exception">Period to not deactivate.</param>
    public void deactivateAllButOne(Period exception)
    {
        foreach(Period p in this.periods.Values)
        {
            if (exception != p)
                p.setActive(false);
        }
    }

}
