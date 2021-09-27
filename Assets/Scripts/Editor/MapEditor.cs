using UnityEditor;

[CustomEditor (typeof(GenerateMaps))]
public class MapEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GenerateMaps map = target as GenerateMaps;
        
        map.GenerateMap();
    }
}
