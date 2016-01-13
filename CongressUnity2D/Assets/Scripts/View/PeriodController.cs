using UnityEngine;
using System.Collections;

/// <summary>
/// Handles the intercations with a period button.
/// </summary>
public class PeriodController : MonoBehaviour {

    /// <summary>
    /// Corresponding Period.
    /// </summary>
    private Period model;

	// Use this for initialization
	void Start () {
        model = (Period) gameObject.GetComponent(typeof(Period));
	}
	
    /// <summary>
    /// Inverts the 'active' value of the model (true or false).
    /// </summary>
    void OnMouseDown()
    {
        model.setActive(!model.active);
    }

}
