/******************************************************************************
 *
 * Name:     GdalConfiguration.cs.pp
 * Project:  GDAL CSharp Interface
 * Purpose:  A static configuration utility class to enable GDAL/OGR.
 * Author:   Felix Obermaier
 *
 ******************************************************************************
 * Copyright (c) 2012-2018, Felix Obermaier
 *
 * Permission is hereby granted, free of charge, to any person obtaining a
 * copy of this software and associated documentation files (the "Software"),
 * to deal in the Software without restriction, including without limitation
 * the rights to use, copy, modify, merge, publish, distribute, sublicense,
 * and/or sell copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included
 * in all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
 * OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
 * THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
 * DEALINGS IN THE SOFTWARE.
 *****************************************************************************/

using System;
using System.IO;
using UnityEngine;
using Gdal = OSGeo.GDAL.Gdal;
using Ogr = OSGeo.OGR.Ogr;
using Osr = OSGeo.OSR.Osr;
using Debug = UnityEngine.Debug;

namespace OSGeo
{
    public static class GdalConfiguration
    {
        private static volatile bool _configuredOgr;
        private static volatile bool _configuredGdal;
        private static volatile bool _usable;

        /// <summary>
        /// Construction of Gdal/Ogr
        /// </summary>
        static GdalConfiguration()
        {
            try
            {
                // Set the GDAL environment variables.
                string gdalPath = Application.streamingAssetsPath;
                string gdalData = Path.Combine(gdalPath, "gdal");
                string projData = Path.Combine(gdalPath, "proj");
                Gdal.SetConfigOption("GDAL_DATA", gdalData);

                Gdal.SetConfigOption("GDAL_DRIVER_PATH", gdalData);
                Gdal.SetConfigOption("GEOTIFF_CSV", gdalData);

                Gdal.SetConfigOption("CURL_CA_BUNDLE", Path.Combine(gdalData, "cacert.pem"));
                Environment.SetEnvironmentVariable("PROJ_CURL_CA_BUNDLE", Path.Combine(projData, "cacert.pem"));
                Osr.SetPROJSearchPath(projData);
                Osr.SetPROJEnableNetwork(true);

                //Other gdal configs
                Gdal.SetConfigOption("OGR_WFS_LOAD_MULTIPLE_LAYER_DEFN", "NO");
                Gdal.SetConfigOption("OGR_WFS_PAGING_ALLOWED", "YES");
                Gdal.SetConfigOption("OGR_WFS_USE_STREAMING", "NO");

                _usable = true;

                Debug.Log($"GDAL version string : {Gdal.VersionInfo(null)}");
            }
            catch (Exception e)
            {
                _usable = false;
                Debug.LogError(e.ToString());
                throw;
            }
        }

        /// <summary>
        /// Gets a value indicating if the GDAL package is set up properly.
        /// </summary>
        public static bool Usable
        {
            get { return _usable; }
        }

        /// <summary>
        /// Method to ensure the static constructor is being called.
        /// </summary>
        /// <remarks>Be sure to call this function before using Gdal/Ogr/Osr</remarks>
        public static void ConfigureOgr()
        {
            if (!_usable)
                return;
            if (_configuredOgr)
                return;

            // Register drivers
            Ogr.RegisterAll();
            _configuredOgr = true;

            PrintDriversOgr();
        }

        /// <summary>
        /// Method to ensure the static constructor is being called.
        /// </summary>
        /// <remarks>Be sure to call this function before using Gdal/Ogr/Osr</remarks>
        public static void ConfigureGdal()
        {
            if (!_usable)
                return;
            if (_configuredGdal)
                return;

            // Register drivers
            Gdal.AllRegister();
            _configuredGdal = true;

            PrintDriversGdal();
        }


        /// <summary>
        /// Function to determine which platform we're on
        /// </summary>
        private static string GetPlatform()
        {
            return Environment.Is64BitProcess ? "x64" : "x86";
        }

        /// <summary>
        /// Gets a value indicating if we are on a windows platform
        /// </summary>
        private static bool IsWindows
        {
            get
            {
                var res = !(Environment.OSVersion.Platform == PlatformID.Unix ||
                            Environment.OSVersion.Platform == PlatformID.MacOSX);

                return res;
            }
        }
        private static void PrintDriversOgr()
        {
            if (_usable)
            {
                string drivers = "";
                var num = Ogr.GetDriverCount();
                for (var i = 0; i < num; i++)
                {
                    var driver = Ogr.GetDriver(i);
                    drivers += $"OGR {i}: {driver.GetName()}";
                    drivers += ", ";
                }
                Debug.Log($"OGR Drivers : {drivers}");

            }
        }

        private static void PrintDriversGdal()
        {
            if (_usable)
            {
                string drivers = "";
                var num = Gdal.GetDriverCount();
                for (var i = 0; i < num; i++)
                {
                    var driver = Gdal.GetDriver(i);
                    drivers += $"GDAL {i}: {driver.ShortName}-{driver.LongName}";
                    drivers += ", ";
                }
                Debug.Log($"GDAL Drivers : {drivers}");

            }
        }
    }
}
