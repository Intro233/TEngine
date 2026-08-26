using System.IO;
using UnityEditor;
using UnityEngine;

namespace TEngine.Editor
{
    public static class LubanTools
    {
        private static string GameConfigRoot =>
            Path.GetFullPath(Path.Combine(Application.dataPath, "../../Configs/GameConfig"));

        [MenuItem("TEngine/Luban/转表 &X", priority = -100)]
        private static void ZhuanXiaoYi()
        {
#if UNITY_EDITOR_OSX || UNITY_EDITOR_LINUX
            string path = Path.Combine(GameConfigRoot, "gen_code_bin_to_project_lazyload.sh");
#elif UNITY_EDITOR_WIN
            string path = Path.Combine(GameConfigRoot, "gen_code_bin_to_project_lazyload.bat");
#endif
            Debug.Log($"执行转表：{path}");
            ShellHelper.RunByPath(path);
        }

        [MenuItem("TEngine/Luban/打开表目录", priority = -99)]
        private static void OpenGameConfigFolder()
        {
            string path = GameConfigRoot;
            if (!Directory.Exists(path))
            {
                Debug.LogError($"表目录不存在：{path}");
                return;
            }

            OpenFolderHelper.Execute(path);
        }
    }
}
