using UnityEngine;
using UnityEditor;

namespace SerializableUnityTag.Editor
{
    // タグ名のプロパティを表示するためのPropertyDrawer
    [CustomPropertyDrawer(typeof(UnityTag))]
    public class UnityTagDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var tagNameProperty = property.FindPropertyRelative("_tagName");

            // タグフィールドを表示
            var tag = EditorGUI.TagField(position, label, tagNameProperty.stringValue);

            // タグ名を反映
            tagNameProperty.stringValue = tag;
        }
    }
}