using UnityEngine;
using UnityEngine.UI;

public class DisplayChangedTextContent : MonoBehaviour
{
	// a reference to the UI Input Field
    // - so we can retrieve its text content when user finishes editing
	public InputField inputField;

    // reference to UI Text on screen to display new content
	private Text textDisplay;

	// get reference to the Text component
	// of the parent GameObject
	void Awake()
	{
		textDisplay = GetComponent<Text>();
	}

	// update the onscreen text with current value of the input field
	// this will be called each time the InputField receives an 'EndEdit' event message
	public void DisplayNewValue ()
	{
		textDisplay.text = "last entry = '" + inputField.text + "'";
	}
}
