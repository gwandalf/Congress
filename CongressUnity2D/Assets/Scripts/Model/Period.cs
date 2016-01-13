using UnityEngine;
using System.Collections;

/// <summary>
/// Period of the day.
/// </summary>
public class Period : MonoBehaviour {

    /// <summary>
    /// GameObject holding the activities.
    /// </summary>
    public GameObject activitiesHolder;

	/// <summary>
	/// Gets a value indicating whether this <see cref="Period"/> is active.
	/// </summary>
	/// <value><c>true</c> if active; otherwise, <c>false</c>.</value>
	public bool active
	{
		get { return this.activitiesHolder.activeSelf; }
		private set { this.activitiesHolder.SetActive(value); }
	}

	/// <summary>
	/// The GameObjetc holding the period group.
	/// </summary>
	public GameObject groupHolder;

	/// <summary>
	/// The period group.
	/// </summary>
	private PeriodGroup group;

	// Use this for initialization
	void Start () {
		this.group = (PeriodGroup) this.groupHolder.GetComponent (typeof(PeriodGroup));
	}

	/// <summary>
	/// Sets the active property.
	/// </summary>
	/// <param name="value">If set to <c>true</c> value.</param>
	public void setActive(bool value) {
		this.active = value;
		if (value)
			this.group.deactivateAllButOne(this);
	}
}
