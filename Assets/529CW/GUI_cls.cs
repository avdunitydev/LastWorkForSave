using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class GUI_cls : MonoBehaviour 
{
    public GUISkin mGuiSkin;

    public float speedV, speedMin, speedMax;
    public float scrolBarV, scrolBarSize;

    public Texture mSomeTexture;

    Rect mWindowsOne = new Rect(320, 60, 250, 200);
	Rect mWindowsTwo = new Rect(320, 60, 250, 200);
    Rect mRectMainPanel, mRectTogglePanel, mRectSettingsPanel, mRectTabPanel;
 
    string labelTxtField = "", labelPassField = "", labelTxtArea = "";
    string[] tabNames = new string[] { "Tab 1", "Tab 2", "Tab 3" };

    bool toggle1, toggle2, toggle3;
    bool mButton;
    bool mPanel;

    int mID;

    void OnGUI()
    {
        GUI.skin = mGuiSkin;
        if (mPanel){
            
        } else
        {
            
        }

		// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ MAIN PANEL
		mRectMainPanel = new Rect(0, 0, 280, 200);
		GUI.BeginGroup(mRectMainPanel); // -------------------- Start group elements
		
		GUI.Label(new Rect(10,10,240,20),("My screen width = " + 
		                                  Screen.width + 
		                                  "  height = " + 
		                                  Screen.height));
		labelTxtField = GUI.TextField(new Rect(10, 40, 180, 20), labelTxtField);
		labelPassField = GUI.PasswordField(new Rect(10, 70, 180, 20), labelPassField, '$');
		labelTxtArea = GUI.TextArea(new Rect(10, 100, 180, 140), labelTxtArea);
		
		GUI.EndGroup(); // ------------------------------------ End group elements

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ TOGGLE PANEL
        mRectTogglePanel = new Rect(10, 270, 220, 120);
        GUI.BeginGroup(mRectTogglePanel); // -------------------- Start group elements

        toggle1 = GUI.Toggle(new Rect(0, 0, 180, 20), toggle1, "Main Panel");
        toggle2 = GUI.Toggle(new Rect(0, 30, 180, 20), toggle2, "Panel Left");
        toggle3 = GUI.Toggle(new Rect(0, 60, 180, 20), toggle3, "Panel Right");
        
        GUI.EndGroup(); // ------------------------------------ End group elements

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ADD BUTTON
        mButton = GUI.Button(new Rect(Screen.width - (Screen.width - 10), Screen.height - (30 + 10), 80, 30), "FIRE");

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ SETTINGS PANEL
        GUI.BeginGroup(new Rect( 
                                (Screen.width) - 200 - 10,
                                (Screen.height) - 200 - 10, 
                                200, 200)); // -------------------- Start group elements

        GUI.Box(new Rect(0, 0, 200, 200), "Settings");
		GUI.EndGroup(); // ------------------------------------ End group elements
    }

}
