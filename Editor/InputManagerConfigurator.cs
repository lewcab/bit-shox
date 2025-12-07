using UnityEditor;
using UnityEngine;

public static class InputManagerConfigurator
{
    public static void AddAxis(
        string name, string descriptiveName, 
        string negativeButton, string positiveButton, 
        string altNegativeButton, string altPositiveButton, 
        float gravity, float dead, float sensitivity, bool snap, bool invert, 
        int type, int joyAxis = 0
    )
    {
        SerializedObject serializedObject = new SerializedObject(AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/InputManager.asset")[0]);
        SerializedProperty axesProperty = serializedObject.FindProperty("m_Axes");

        // Check if the axis already exists
        for (int i = 0; i < axesProperty.arraySize; i++)
        {
            SerializedProperty axis = axesProperty.GetArrayElementAtIndex(i);
            if (axis.FindPropertyRelative("m_Name").stringValue == name)
            {
                Debug.Log($"Axis '{name}' already exists.");
                return;
            }
        }

        // Add new axis
        axesProperty.arraySize++;
        SerializedProperty newAxis = axesProperty.GetArrayElementAtIndex(axesProperty.arraySize - 1);

        newAxis.FindPropertyRelative("m_Name").stringValue = name;
        newAxis.FindPropertyRelative("descriptiveName").stringValue = descriptiveName;
        newAxis.FindPropertyRelative("negativeButton").stringValue = negativeButton;
        newAxis.FindPropertyRelative("positiveButton").stringValue = positiveButton;
        newAxis.FindPropertyRelative("altNegativeButton").stringValue = altNegativeButton;
        newAxis.FindPropertyRelative("altPositiveButton").stringValue = altPositiveButton;
        newAxis.FindPropertyRelative("gravity").floatValue = gravity;
        newAxis.FindPropertyRelative("dead").floatValue = dead;
        newAxis.FindPropertyRelative("sensitivity").floatValue = sensitivity;
        newAxis.FindPropertyRelative("snap").boolValue = snap;
        newAxis.FindPropertyRelative("invert").boolValue = invert;
        newAxis.FindPropertyRelative("type").intValue = type;
        newAxis.FindPropertyRelative("axis").intValue = joyAxis;

        serializedObject.ApplyModifiedProperties();
        Debug.Log($"Axis '{name}' added successfully.");
    }

    [MenuItem("Tools/Bit Shox/Configure Vehicle Controls")]
    public static void ConfigureVehicleControls()
    {
        AddAxis("L-Stick-X", "Left Stick Horizontal", "", "", "", "", 3, 0.001f, 1, false, false, 2, 0);
        AddAxis("R-Stick-X", "Right Stick Horizontal", "", "", "", "", 3, 0.001f, 1, false, false, 2, 3);
        AddAxis("L-Trigger", "Left Trigger", "", "", "", "", 3, 0.001f, 1, false, false, 2, 8);
        AddAxis("R-Trigger", "Right Trigger", "", "", "", "", 3, 0.001f, 1, false, false, 2, 9);
    }
}