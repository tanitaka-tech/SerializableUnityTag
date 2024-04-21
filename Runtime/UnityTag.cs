using System;
using UnityEngine;

namespace SerializableUnityTag
{
    [Serializable]
    public struct UnityTag
    {
        // タグ名
        [SerializeField] private string _tagName;

        // タグ名のプロパティ
        public string Name
        {
            get => _tagName;
            set => _tagName = value;
        }

        // タグ付けされているかどうか
        public bool IsTagged => !string.IsNullOrEmpty(_tagName) && _tagName != "Untagged";

        // タグ名の比較
        public static bool operator ==(UnityTag unityTag, string tagName) => unityTag._tagName == tagName;
        public static bool operator !=(UnityTag unityTag, string tagName) => unityTag._tagName != tagName;
        public bool Equals(UnityTag other) => _tagName == other._tagName;
        public override bool Equals(object obj) => obj is UnityTag other && Equals(other);

        // ハッシュコードの取得
        public override int GetHashCode() => (_tagName != null ? _tagName.GetHashCode() : 0);

        // 文字列への変換
        public override string ToString() => _tagName;
    }
}