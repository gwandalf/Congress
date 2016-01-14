using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Period of the day.
/// </summary>
public class Period : MonoBehaviour {

    /// <summary>
    /// Activities held during this period.
    /// </summary>
    private List<Activity> activities;

	/// <summary>
	/// Gets a value indicating whether this <see cref="Period"/> is active.
	/// </summary>
	/// <value><c>true</c> if active; otherwise, <c>false</c>.</value>
	public bool active
	{
		get
        {
            return periodHolder.activeSelf;
        }
		private set
        {
           periodHolder.SetActive(value);
        }
	}

	/// <summary>
	/// The GameObject holding the period.
	/// </summary>
	public GameObject periodHolder;

	/// <summary>
	/// The period group.
	/// </summary>
	private PeriodGroup group;

	// Use this for initialization
	void Start () {
		group = (PeriodGroup) gameObject.transform.parent.gameObject.GetComponent (typeof(PeriodGroup));
        activities = new List<Activity>();
        addActivities();
    }

	/// <summary>
	/// Sets the active property.
	/// </summary>
	/// <param name="value">If set to <c>true</c> value.</param>
	public void setActive(bool value) {
		active = value;
        if (value)
        {
            addActivities();
            group.deactivateAllButOne(this);
        }
        else activities.Clear();
    }

    /// <summary>
    /// Retrieves a random activity among the ones held during this Period.
    /// </summary>
    /// <returns>A random activity among the ones held during this Period.</returns>
    public Activity GetRandomActivity()
    {
        int index = (int)(Random.value * activities.Count);
        if (index == activities.Count && index != 0) index--;
        return activities[index];
    }

    /// <summary>
    /// Add activities.
    /// </summary>
    void addActivities()
    {
        foreach (Component cmp in periodHolder.GetComponentsInChildren(typeof(Activity)))
            activities.Add((Activity)cmp);
    }

}
