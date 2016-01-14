using UnityEngine;
using System.Collections;

/// <summary>
/// Manages the period change event.
/// </summary>
public class PeriodChangeController : MonoBehaviour {

    // Holder GameObjects.
    public GameObject periodGroupHolder;
    public GameObject personSetHolder;

    /// <summary>
    /// Period group.
    /// </summary>
    private PeriodGroup periodGroup;

    /// <summary>
    /// Person set.
    /// </summary>
    private PersonSetModel personSet;

    /// <summary>
    /// Current period.
    /// </summary>
    private Period currentPeriod;

	// Use this for initialization
	void Start () {
        periodGroup = (PeriodGroup)periodGroupHolder.GetComponent(typeof(PeriodGroup));
        personSet = (PersonSetModel)personSetHolder.GetComponent(typeof(PersonSetModel));
        setCurrentPeriod();
	}
	
	// Update is called once per frame
	void Update () {
	    if(!currentPeriod.active)
        {
            setCurrentPeriod();
            personSet.Move(currentPeriod);
        }
	}

    /// <summary>
    /// Research the current period.
    /// </summary>
    void setCurrentPeriod()
    {
        foreach (Period p in periodGroup.periods.Values)
        {
            if (p.active)
            {
                currentPeriod = p;
                break;
            }
        }
    }
}
