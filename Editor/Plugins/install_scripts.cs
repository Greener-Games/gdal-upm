using UnityEngine;
using UnityEditor;
using System.IO;
using System.Diagnostics;
using System;
using System.Linq;
using System.Collections.Generic;
using Debug = UnityEngine.Debug;
using OSGeo.GDAL;

#if UNITY_EDITOR
namespace OSGeo.Install {

    public class Install{

        const string packageVersion = "2.0.0a1";

        [InitializeOnLoadMethod]
        static void OnProjectLoadedinEditor()
        {
            Stopwatch stopwatch = new Stopwatch();
            string response = "";
            stopwatch.Start();
            EditorUtility.DisplayProgressBar("Restoring Conda Package", "GDAL", 0);
             
            if (Application.isEditor) {
                try
                {
                    List<Conda.CondaItem> list = Conda.Conda.Info().Items.ToList();
                    Conda.CondaItem entry = list.Find(item => item.name == "gdal-csharp");
                    if (entry == null || entry.version != packageVersion)
                    {
                        response = UpdatePackage();
                        AssetDatabase.Refresh();
                    }
                    string currentVersion = Gdal.VersionInfo(null);
                }
                catch (Exception e)
                {
                    Debug.Log($"Error in Conda Package GDAL: {e.ToString()}");
                    response = UpdatePackage();
                    AssetDatabase.Refresh();
                };
            };

            EditorUtility.ClearProgressBar();
            stopwatch.Stop();
            Debug.Log($"Gdal refresh took {stopwatch.Elapsed.TotalSeconds} seconds" + response);
        }


        static string UpdatePackage()
        {
            Debug.Log("Gdal Install Script Awake");
            string path = Path.GetDirectoryName(new StackTrace(true).GetFrame(0).GetFileName());
#if UNITY_EDITOR_WIN
            string script = "install_script.ps1";
#else
            string script = "install_script.sh";
#endif
            return Conda.Conda.Install($"gdal-csharp={packageVersion}",script, path);

        }
    }
}
#endif
